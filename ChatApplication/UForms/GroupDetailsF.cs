using ChatApplication.Manager;

using ChatApplication.UControl;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication.UForms
{
    public partial class GroupDetailsF : Form
    {
        public TransparentForm transparentFormObj;
        private Group group;
        private bool isAddGroupMember;
        public event EventHandler OnClickFormClose;
        public event EventHandler<Contact> OnClickContactGet;
        public event EventHandler<Group> OnclickLeaveFromGroupInvoke;
        public bool isAdmin = false;
        public bool IsAdmin
        {
            set
            {
                isAdmin = value;
                dpPictureU.EditBtnVisible = isAdmin;
                groupNameTBEditBtn.Visible = isAdmin;
                addOrRemoveChoiceP.Visible = isAdmin;
            }
            get
            {
                return isAdmin;
            }
        }
        public string GroupProfilePicturePath
        {
            set
            {
                if (dpPictureU.Image != null)
                    dpPictureU.Image.Dispose();
                try
                {
                    if (value != "File Not Found")
                    {

                        dpPictureU.Image = Image.FromFile(value);
                    }
                    else
                        dpPictureU.Image = Properties.Resources.profile_user;
                }
                catch
                {
                    dpPictureU.Image = Properties.Resources.profile_user;
                }
            }
            get
            {
                return dpPictureU.DpPicturPath;
            }
        }
        public Group Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
                groupNameTB.Text = group.GroupName;
                GroupProfilePicturePath = group.DpPicture;
                if (group.AdminHostName == NetworkManager.PcHostName)
                {
                    IsAdmin = true;
                }
                else
                {
                    IsAdmin = false;
                }
            }
        }
        public GroupDetailsF(Group group)
        {
            InitializeComponent();
            KeyPreview = true;
            groupMainTabControl.SelectedTab = overviewPage;
            groupMainTabControl.ItemSize = new Size(0, 1);
            KeyDown += FormKeyDown;
            // theme SetUp
            addGroupMemberNextBtn.BackColor = SettingManager.PrimaryThemeColor;
            addGroupMemberBtn.BackColor = SettingManager.PrimaryThemeColor;
            groupNameTB.BorderColor = SettingManager.PrimaryThemeColor;
            searchBox.BorderColor = SettingManager.PrimaryThemeColor;
            Disposed += GroupMemberFDisposed;
            addGroupMemberNextBtn.Click += AddGroupMemberNextBtnClick;
            RemoveGroupMemberBtn.Click += RemoveGroupMemberBtnClick;
            addGroupMemberBtn.Click += AddGroupMemberBtnClick;
            cancelBtn.Click += CancelBtnClick;
            groupMenuControl.OnClickMemberBtn += GroupMenuControlOnClickMemberBtn;
            groupMenuControl.OnClickOverviewBtn += GroupMenuControlOnClickOverviewBtn;
            LostFocus += GroupMemberFLostFocus;
            searchBox.Textchanged += SearchBoxTextchanged;
            groupNameTB.KeyPressDown += groupNameTBKeyDown;
            groupNameTB.Textchanged += GroupNameTBTextchanged;
            dpPictureU.OnClickDpPicturePathGet += dpPictureUOnClickDpPicturePathGet;
            groupNameTBEditBtn.Click += groupNameTBEditBtnClick;
            groupLeaveBtn.Click += GroupLeaveBtnClick;
            Group = group;
            adminNameLabel.Text = "AdminName  :  " + ContactsManager.getName(group.AdminHostName);
            GroupMembersCreate();
            FeaturesMethods.AltTabFormShowStop(this.Handle);
        }

        private void GroupNameTBTextchanged(object sender, EventArgs e)
        {
          
                if (groupNameTB.Text.Length > 16)
                {
                groupnameErrorLB.Visible = true;
                groupnameErrorLB.Text = "Lastname should be\nless  than 16 character";
                }
                else if (groupNameTB.Text.Length == 0)
                {
                groupnameErrorLB.Visible = true;
                groupnameErrorLB.Text = "Enter the lastname";
                }
                else
                {
                groupnameErrorLB.Visible = false;
                }
            
        }

        private void GroupLeaveBtnClick(object sender, EventArgs e)
        {
            MessageConfirmForm messageConfirmForm = new MessageConfirmForm("Do you want Leave this group");
            DialogResult result = messageConfirmForm.ShowDialog();
            if (result == DialogResult.Yes)
            {
                if (DatabaseManager.ChatApplicationServerConnection())
                {
                    if (group.AdminHostName == NetworkManager.PcHostName)
                    {
                        GroupMember LowestJoinDateAndTimeGroupMember = null;
                        for (int i = 0; i < group.GroupMembers.Count; i++)
                        {
                            if (group.GroupMembers[i].Contact.HostName != NetworkManager.PcHostName)
                            {
                                if (LowestJoinDateAndTimeGroupMember == null || (LowestJoinDateAndTimeGroupMember != null && LowestJoinDateAndTimeGroupMember.JoinDate > group.GroupMembers[i].JoinDate))
                                {
                                    LowestJoinDateAndTimeGroupMember = group.GroupMembers[i];
                                }
                            }
                        }
                        if (LowestJoinDateAndTimeGroupMember != null)
                            GroupsManager.UpdateGroupAdminHostname(group.GroupID, LowestJoinDateAndTimeGroupMember.Contact.HostName);
                    }
                    GroupsManager.DeleteGroupMember(Group.GroupID, NetworkManager.PcHostName);
                    DatabaseManager.DataBaseTablesUpdateFromServer();
                    GroupsManager.GroupsManagerSetUp();
                    DatabaseManager.ChatApplicationLocalConnection();
                    OnclickLeaveFromGroupInvoke.Invoke(this, Group);
                    Dispose();
                }
                else
                {
                    SettingManager.notificationThrowManager.CreateNotification("Server not respond !", NotificationType.Information);
                    Dispose();
                }
            }
            else
            Dispose();
        }
        private void dpPictureUOnClickDpPicturePathGet(object sender, string dpPicturePath)
        {
            try
            {

                if (DatabaseManager.ChatApplicationServerConnection())
                {
                    string imageStringFormat = FilesManager.ConvertImageToBase64(dpPicturePath);
                    GroupsManager.ChangeGroupDppicture(group.GroupID, imageStringFormat);
                    DatabaseManager.ChatApplicationLocalConnection();
                    GroupsManager.ChangeGroupDppicture(group.GroupID, imageStringFormat);
                }
                else
                    SettingManager.notificationThrowManager.CreateNotification("Server not respond", NotificationType.Information);
            }
            catch
            {
                SettingManager.notificationThrowManager.CreateNotification("Server not respond", NotificationType.Information);
            }
        }
        private void groupNameTBEditBtnClick(object sender, EventArgs e)
        {
            groupNameTB.Enabled = true;
            groupNameTBEditBtn.Visible = false;
        }
        private void groupNameTBKeyDown(object sender, KeyEventArgs e)
        {
            if (groupNameTB.Enabled == true && e.KeyCode == Keys.Enter&& groupNameTB.Text!=""&&groupnameErrorLB.Visible == false && groupNameTB.Text.Length > 0)
            {
                groupNameTBEditBtn.Visible = true;
                groupNameTB.Enabled = false;
                if (DatabaseManager.ChatApplicationServerConnection())
                {
                    GroupsManager.ChangeGroupName(group.GroupID, groupNameTB.Text);
                    DatabaseManager.ChatApplicationLocalConnection();
                    GroupsManager.ChangeGroupName(group.GroupID, groupNameTB.Text);
                }
                else
                {
                    SettingManager.notificationThrowManager.CreateNotification("Server not respond", NotificationType.Information);
                }
            }
        }
        private void GroupMenuControlOnClickOverviewBtn(object sender, EventArgs e)
        {
            groupMainTabControl.SelectedTab = overviewPage;
        }

        private void GroupMenuControlOnClickMemberBtn(object sender, EventArgs e)
        {
            groupMainTabControl.SelectedTab = groupMemberPage;
        }

        private void GroupMemberFDisposed(object sender, EventArgs e)
        {
            GroupMembersShowPControlsDispose();
            if (dpPictureU.Image != null)
                dpPictureU.Image.Dispose();
        }

        private void SearchBoxTextchanged(object sender, EventArgs e)
        {
            groupMembersShowP.SuspendLayout();
            if (!searchBox.IsPlaceholder && searchBox.Text != searchBox.PlaceholderText)
            {
                if (!string.IsNullOrWhiteSpace(searchBox.Text))
                {
                    string searchText = searchBox.Text.Trim();
                    for (int i = 0; i < groupMembersShowP.Controls.Count; i++)
                    {
                        ContactSimpleU contactU = groupMembersShowP.Controls[i] as ContactSimpleU;
                        if (contactU != null && contactU.Contact.FirstName.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) == 0)
                        {
                            contactU.SendToBack();
                        }
                    }
                }
            }
            groupMembersShowP.ResumeLayout();
        }

        private void RemoveGroupMemberBtnClick(object sender, EventArgs e)
        {
            titleLB.Text = "Remove GroupMember";
            addOrRemoveChoiceP.Visible = false;
            addGroupMemberNextP.Visible = true;
            GroupMembeCheckedBoxVisible();
        }

        private void GroupMembeCheckedBoxVisible()
        {
            for (int i = 0; i < groupMembersShowP.Controls.Count; i++)
            {
                if (!(Group.AdminHostName == ((ContactSimpleU)groupMembersShowP.Controls[i]).Contact.HostName))
                {
                    ((ContactSimpleU)groupMembersShowP.Controls[i]).IsCheckBoxVisible = true;
                }
            }
        }
        private void GroupMemberFLostFocus(object sender, EventArgs e)
        {
            //  this.Close();
        }

        private void CancelBtnClick(object sender, EventArgs e)
        {
            titleLB.Text = "Group Members";
            addOrRemoveChoiceP.Visible = true;
            addGroupMemberNextP.Visible = false;
            if (isAddGroupMember)
            {
                GroupMembersCreate();
                isAddGroupMember = false;
            }
            else
            {
                for (int i = 0; i < groupMembersShowP.Controls.Count; i++)
                {
                    ((ContactSimpleU)groupMembersShowP.Controls[i]).IsCheckBoxVisible = false;
                }
            }
        }
        public void GroupMembersShowPControlsDispose()
        {
            for (int i = 0; i < groupMembersShowP.Controls.Count; i++)
            {
                ((ContactSimpleU)(groupMembersShowP.Controls[i])).Dispose();
                //  groupMembersShowP.Controls.Remove((ContactSimpleU)(groupMembersShowP.Controls[i]));
                i--;
            }
        }
        private void GroupMembersCreate()
        {
            GroupMembersShowPControlsDispose();
            for (int i = 0; i < Group.GroupMembers.Count; i++)
            {
                ContactSimpleU contactSimpleU = new ContactSimpleU(Group.GroupMembers[i].Contact) { Dock = DockStyle.Top };
                if (Group.AdminHostName == Group.GroupMembers[i].Contact.HostName)
                {
                    contactSimpleU.IsGroupAdmin = true;
                }
                contactSimpleU.OnClickContactSimpleU += ContactGet;
                groupMembersShowP.Controls.Add(contactSimpleU);
            }
        }

        private void ContactGet(object sender, Contact contact)
        {
            OnClickContactGet?.Invoke(sender, contact);
            OnClickFormClose?.Invoke(this, EventArgs.Empty);
        }

        private void NonGroupMemberCreate()
        {
            GroupMembersShowPControlsDispose();
            for (int i = 0; i < ContactsManager.Contacts_list.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < Group.GroupMembers.Count; j++)
                {
                    if (ContactsManager.Contacts_list[i].HostName == Group.GroupMembers[j].Contact.HostName)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    ContactSimpleU contactSimpleU = new ContactSimpleU(ContactsManager.Contacts_list[i]) { Dock = DockStyle.Top };
                    contactSimpleU.IsCheckBoxVisible = true;
                    contactSimpleU.OnClickContactSimpleU += ContactGet;
                    groupMembersShowP.Controls.Add(contactSimpleU);
                }
            }
        }
        private void AddGroupMemberNextBtnClick(object sender, EventArgs e)
        {
            if (DatabaseManager.ChatApplicationServerConnection())
            {
                if (isAddGroupMember)
                {
                    for (int i = 0; i < groupMembersShowP.Controls.Count; i++)
                    {
                        if (groupMembersShowP.Controls[i] is ContactSimpleU && ((ContactSimpleU)groupMembersShowP.Controls[i]).IsSelected)
                        {
                            GroupsManager.CreateGroupMember(Group.GroupID, ((ContactSimpleU)groupMembersShowP.Controls[i]).Contact.HostName, DateTime.Now);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < groupMembersShowP.Controls.Count; i++)
                    {
                        if (groupMembersShowP.Controls[i] is ContactSimpleU && ((ContactSimpleU)groupMembersShowP.Controls[i]).IsSelected)
                        {
                            GroupsManager.DeleteGroupMember(Group.GroupID, ((ContactSimpleU)groupMembersShowP.Controls[i]).Contact.HostName);
                        }
                    }
                }
                DatabaseManager.DataBaseTablesUpdateFromServer();
                DatabaseManager.ChatApplicationLocalConnection();
                Group.GroupMembers = GroupsManager.GetGroupMembers(Group.GroupID);
            }
            else
            {
                MessageBox.Show("Server Not Respond");
            }
            OnClickFormClose?.Invoke(this, EventArgs.Empty);
        }

        private void AddGroupMemberBtnClick(object sender, EventArgs e)
        {
            addOrRemoveChoiceP.Visible = false;
            addGroupMemberNextP.Visible = true;
            titleLB.Text = "Add GroupMember";
            isAddGroupMember = true;
            NonGroupMemberCreate();
        }

        private void addGroupMemberBtn_MouseEnter(object sender, EventArgs e)
        {
            ForeColor = Color.White;
        }
        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers & Keys.Alt) == Keys.Alt)
            {
                if (transparentFormObj != null)
                    transparentFormObj.Dispose();
            }
        }
    }
}
