using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatApplication.UForms;
using ChatApplication.Manager;

namespace ChatApplication
{
    public partial class ChatPageTitleU : UserControl
    {
        public event EventHandler<Group> OnclickLeaveFromGroupInvoke;
        public event EventHandler<Contact> OnclickGroupMemberContactGet;
        public event EventHandler<bool> OnclickAddArchivedBtn;
        public event EventHandler OnclickProfilePicture;
        private Color OnlineColor = ColorTranslator.FromHtml("#1FB141");
        private string conatctImagePath;
        private Group group;
        private Contact contact;
        private bool isArchived;
        private bool isGroup = false;
        private bool isOnline;
        public object ContactOrGroup;
        public bool IsOnline
        {
            set
            {
                isOnline = value;
                if (isOnline)
                {
                    contactStatusLabel.Text = "Online";
                    contactStatusLabel.ForeColor = OnlineColor;
                }
                else
                {
                    contactStatusLabel.Text = "Offline";
                    contactStatusLabel.ForeColor = Color.Gray;
                }
            }
            get
            {
                return isOnline;
            }
        }
        public bool IsGroup
        {
            set
            {
                isGroup = value;
            }
            get
            {
                return isGroup;
            }
        }

        public Group Group
        {
            set
            {
                
                 group = value;
                ContactOrGroup = group;
                if (value != null)
                {
                   
                    IsGroup = true;
                    ConatctName = group.GroupName;
                    ContactImagePath = group.DpPicture;
                    contactStatusLabel.Text = "Group";
                    contactStatusLabel.ForeColor = Color.Gray;
                    addGroupMemberBtn.Visible = true;
                    IsArchived = group.IsArchived;
                }
            }
            get
            {
                return group;
            }
        }


        public Contact Contact
        {
            set
            {
                contact = value;
                ContactOrGroup = contact;
                if (value != null)
                {
                    IsGroup = false;
                  
                    IsOnline = contact.IsOnline;
                    ConatctName = contact.FirstName;
                    ContactImagePath = contact.DpPicture;
                    addGroupMemberBtn.Visible = false;
                    IsArchived = contact.IsArchived;
                }
            }
            get
            {
                return contact;
            }
        }
        public bool IsArchived
        {
            set
            {
                isArchived = value;
                addToArchivedBtn.Image = isArchived ? Properties.Resources.ArchivedIcon : Properties.Resources.AddToArchivedIcon;
            }
            get
            {
                return isArchived;
            }
        }
        public string ContactImagePath
        {
            set
            {
                if (contactDpPicturePB.Image != null)
                    contactDpPicturePB.Image.Dispose();
                try
                {

                    if (value != "File Not Found")
                    {
                        conatctImagePath = value;
                        contactDpPicturePB.Image = Image.FromFile(value);

                    }
                    else
                        contactDpPicturePB.Image = Properties.Resources.profile_user;
                }
                catch
                {
                    contactDpPicturePB.Image = Properties.Resources.profile_user;
                }
            }
            get
            {
                return conatctImagePath;
            }
        }
        public Image ConatctImage
        {
            set
            {
                contactDpPicturePB.Image = value;
            }

        }
        public string ConatctName
        {
            set
            {
                nameLB.Text = value;
            }
            get
            {
                return nameLB.Text;
            }
        }
        public string groupinfoText
        {
            set
            {
                contactStatusLabel.Text = value;
            }
            get
            {
                return contactStatusLabel.Text;
            }
        }
        public ChatPageTitleU()
        {
            InitializeComponent();
            addToArchivedBtn.Click += AddToArchivedBtnClick;
            addGroupMemberBtn.Click += GroupMemberBtnClick;
            contactDpPicturePB.Click += ContactDpPicturePBClick;

        }

        private void AddToArchivedBtnClick(object sender, EventArgs e)
        {
            IsArchived = !IsArchived;
            if (isGroup)
            {
                GroupsManager.ChangeIsArchived(group.GroupID, IsArchived);
                group.IsArchived = IsArchived;
            }
            else
            {
                ContactsManager.ChangeIsArchived(contact.HostName, IsArchived);
                contact.IsArchived = IsArchived;
            }
            OnclickAddArchivedBtn?.Invoke(this, IsArchived);
        }

        private void ContactDpPicturePBClick(object sender, EventArgs e)
        {
            OnclickProfilePicture?.Invoke(this, EventArgs.Empty);
        }

        private void GroupMemberBtnClick(object sender, EventArgs e)
        {
            TransparentForm transparentForm = new TransparentForm();

            Point point = addGroupMemberBtn.PointToScreen(new Point(0, 0));
            GroupDetailsF groupMemberF = new GroupDetailsF(Group);
            groupMemberF.transparentFormObj = transparentForm;
            groupMemberF.OnClickContactGet += GroupMemberFOnClickContactGet;
            groupMemberF.OnclickLeaveFromGroupInvoke += OnclickLeaveFromGroupInvoke;
            groupMemberF.Location = new Point(point.X - groupMemberF.Width + addGroupMemberBtn.Width, point.Y + 60);
            transparentForm.Control = groupMemberF;
            groupMemberF.OnClickFormClose += transparentForm.TransparentFormClick;
            transparentForm.Show();
            groupMemberF.Show();
        }

        private void GroupMemberFOnClickContactGet(object sender, Contact contact)
        {
            OnclickGroupMemberContactGet?.Invoke(this, contact);
        }

        private void ChatPageTitleUClick(object sender, EventArgs e)
        {

        }
        public new void ImageDispose()
        {
            if (contactDpPicturePB.Image != null)
                contactDpPicturePB.Image.Dispose();
        }
        public Form InformationForm;
        private void nameLBEnter(object sender, EventArgs e)
        {
            Point point = nameLB.PointToScreen(new Point(0, 0));


            if (IsGroup)
            {
                GroupInformationF groupInformationF = new GroupInformationF(Group);
                groupInformationF.Location = new Point(point.X, point.Y + 25);
                groupInformationF.Show();
                InformationForm = groupInformationF;
            }
            else
            {

                ContactInformationF contactInformationF = new ContactInformationF(Contact);
                contactInformationF.Location = new Point(point.X, point.Y + 25);
                contactInformationF.Show();
                InformationForm = contactInformationF;
            }

        }

        private void nameLBLeave(object sender, EventArgs e)
        {
            if (InformationForm != null)
            {
                InformationForm.Dispose();
            }
        }
    }
}
