using ChatApplication.Manager;
using ChatApplication.UForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ChatApplication.UControl;
using System.Diagnostics;
using System.Threading.Tasks;

using System.IO;

namespace ChatApplication
{
    public partial class MainForm : Form
    {
       
        public static bool IsMessageSelectionOn;
        private object ContactOrGroupObject;
        // public static TransparentForm transparentForm = new TransparentForm();
        private ContactU prevContactU;
        private string selectedAttachMentFilePath;
        private string sendingText = "";
        public static System.Windows.Forms.ToolTip toolTip;      
        private DateTime prevDateAndTime = DateTime.MinValue;
        public bool isGroup = false;
        public Contact Contact = null;
        public Group Group = null;
        public bool IsAllMessagesReaded;
        public static int prevMessageReadCount = 0;
        public static int MessageReadCount = 0;
        public Color chatPageColor = Color.FromArgb(250, 246, 243);
        public  Dictionary<string, ContactU> ContactUDictionary = new Dictionary<string, ContactU>();
        public Dictionary<ChatUPanel, ChatU> SelectedMessagesChatU = new Dictionary<ChatUPanel, ChatU>();
       
        public object ContactUObject
        {
            set
            {
                if (value != null)
                {
                    ContactOrGroupObject = value;
                    SelectedMessagesChatU.Clear();
                    messageShowP.Controls.Clear();
                    MessagesManager.Message_List.Clear();
                    MessageReadCount = 0;
                    prevMessageReadCount = 0;
                    IsAllMessagesReaded = false;
                    IsMessageSelectionOn = false;
                    if (ContactOrGroupObject is Group)
                    {
                        isGroup = true;
                        this.Group = (Group)ContactOrGroupObject;
                        DateTime JoinDateTime = DateTime.MinValue;
                        for (int i = 0; i < this.Group.GroupMembers.Count; i++)
                        {
                            if (this.Group.GroupMembers[i].Contact.HostName == NetworkManager.PcHostName)
                            {
                                JoinDateTime = this.Group.GroupMembers[i].JoinDate;
                                break;
                            }
                        }
                        MessagesManager.Message_List.AddRange(MessagesManager.GetMessages(this.Group.GroupID, JoinDateTime, ref MessageReadCount, ref IsAllMessagesReaded, messageShowP.MaximumSize.Height / 50 + 1));
                        chatPageTitleU.Group = Group;
                    }
                    else
                    {
                        isGroup = false;
                        this.Contact = (Contact)ContactOrGroupObject;
                        chatPageTitleU.Contact = Contact;
                        MessagesManager.Message_List.AddRange(MessagesManager.GetMessages(NetworkManager.PcHostName, Contact.HostName, ref MessageReadCount, ref IsAllMessagesReaded, messageShowP.MaximumSize.Height / 50 + 1)); ;
                        if(Contact.IsArchived) {
                            menuControl.ISSelectedArchivedBtn = true;
                            mainTabControl.SelectedTab = chatTabpage;
                        }  
                    }
                    prevDateAndTime = DateTime.MaxValue;
                    MessagesAlign();
                    mainTabControl.SelectedTab = chatTabpage;
                   
                }
                else
                {
                    ContactOrGroupObject = value;
                    mainTabControl.SelectedTab = defaultPage;
                }
            }
            get
            {
                return ContactOrGroupObject;
            }
        }
        public Color ChatPageColor
        {
            set
            {
                messageShowP.BackColor = value;
                chatPageColor = value;
            }
            get
            {
                return messageShowP.BackColor;
            }
        }
        //Flicker Issuee solve tempory code
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}
        public MainForm()
        {
            InitializeComponent();
            KeyPreview = true;
            // ThemeSetUp
            ThemeSetUp(this, EventArgs.Empty);
         
            GotFocus += MainFormGotFocus;         

            //menuControlSetUp
            menuControl.OnClickArchivedBtn += ArchivedPageBtnClicked;
            menuControl.OnClickCallsBtn += CallsPageBtnClicked;
            menuControl.OnClickChatsBtn += ChatsPageBtnClicked;
            menuControl.OnClickStatusBtn += StatusPageBtnClicked;
            menuControl.OnClickStarBtn += StartedMessagePageBtnClicked;
            menuControl.OnClickSettingBtn += SettingPageBtnClicked;
            menuControl.OnClickProfilePicture += ProfilePicturePictureBoxClicked;
            SettingManager.ThemeSetUpInvoke += ThemeSetUp;
            messageShowP.MouseWheel += MessageShowPMouseWheel;

            //contactListBtn
            contactListBtn.Click += ContactListBtnClick;
            //ContactTitleU
            chatPageTitleU.OnclickLeaveFromGroupInvoke += ChatPageTitleULeaveFromGroupBtnClicked;
            chatPageTitleU.OnclickGroupMemberContactGet += ChatPageTitleUGroupMemberContactNameGet;
            chatPageTitleU.OnclickProfilePicture += ChatPageTitleUProfilePictureClicked;
            chatPageTitleU.OnclickAddArchivedBtn += ChatPageTitleUAddArchivedBtnClicked;
            //MainForm 
            Load += MainFormLoad;
            FormClosed += MainFormFormClosed;
            Resize += MainFormResize;

            //Subcribe to MessageAlign()
            NetworkManager.MessageAlignInvoke = SingleMessageAlign;
            NetworkManager.NewMessageArrivedInvoke = NewMessageArrivedUpdate;
            NetworkManager.OnlineStatusInvoke += OnlineStatusUpdateToContact;
            //Notification Manager
            SettingManager.notificationThrowManager.OnClickNotification += NotificationOnClick;
            //sentBtn
            sentBtn.Click += SentBtnClick;

            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance, null, messageShowP, new object[] { true });

            //FilterContactBtn
            filterContactsBtn.Click += FilterContactsBtnClicked;
            editSheet.MessageSelected += FilterSelected;
            chatPageSearchBox.Textchanged += ChatPageSearchBoxTextchanged;
            editSheet.Show();
            editSheet.Visible = false;

            //Flicker issue Solve tempory
            //FeaturesMethods.SetPanelExStyle(messageShowP);
        }

        private void OnlineStatusUpdateToContact(object sender, Contact contact)
        {
            if (ContactUDictionary.ContainsKey(contact.HostName)) {
                BeginInvoke((Action)(() => {
                ContactUDictionary[contact.HostName].IsOnline = contact.IsOnline;
                if(chatPageTitleU.IsGroup==false&& contact== chatPageTitleU.Contact)
                {
                        chatPageTitleU.IsOnline = contact.IsOnline;
                }                
                }));      
            }    
        }

        private void MainFormGotFocus(object sender, EventArgs e)
        {
            
        }

        private void ChatPageTitleUAddArchivedBtnClicked(object sender, bool isArchived)
        {
            if (isArchived)
            {
                menuControl.ISSelectedArchivedBtn = true;
                mainTabControl.SelectedTab = chatTabpage;
                for (int i = 0; i < alreadyMessagedContactsPanel.Controls.Count; i++)
                {
                    if (chatPageTitleU.IsGroup)
                    {
                        if (((ContactU)alreadyMessagedContactsPanel.Controls[i]).IsGroup && ((ContactU)alreadyMessagedContactsPanel.Controls[i]).Group.GroupID == chatPageTitleU.Group.GroupID)
                        {
                            ArchivedContactsPanel.Controls.Add(alreadyMessagedContactsPanel.Controls[i]);
                            break;
                        }
                    }
                    else
                    {
                        if (!((ContactU)alreadyMessagedContactsPanel.Controls[i]).IsGroup && ((ContactU)alreadyMessagedContactsPanel.Controls[i]).Contact.HostName == chatPageTitleU.Contact.HostName)
                        {
                            ArchivedContactsPanel.Controls.Add(alreadyMessagedContactsPanel.Controls[i]);
                            break;
                        }
                    }
                }
            }
            else
            {
                menuControl.ISSelectedChatsBtn = true;
                mainTabControl.SelectedTab = chatTabpage;
                for (int i = 0; i < ArchivedContactsPanel.Controls.Count; i++)
                {
                    if (chatPageTitleU.IsGroup)
                    {
                        if (((ContactU)ArchivedContactsPanel.Controls[i]).IsGroup && ((ContactU)ArchivedContactsPanel.Controls[i]).Group.GroupID == chatPageTitleU.Group.GroupID)
                        {
                            alreadyMessagedContactsPanel.Controls.Add(ArchivedContactsPanel.Controls[i]);
                            break;
                        }
                    }
                    else
                    {
                        if (!((ContactU)ArchivedContactsPanel.Controls[i]).IsGroup && ((ContactU)ArchivedContactsPanel.Controls[i]).Contact.HostName == chatPageTitleU.Contact.HostName)
                        {
                            alreadyMessagedContactsPanel.Controls.Add(ArchivedContactsPanel.Controls[i]);
                            break;
                        }
                    }
                }
            }
        }

        private void NotificationOnClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }
        public static void NotificationOnClickFileSaveInvoke(object sender, Message message)
        {
            string DestinationFilePath = FilesManager.saveFileUsingSaveFileDialog(message.FileName);
            DestinationFilePath = DestinationFilePath.Replace("\\", "/");
            if (DestinationFilePath != "")
            {
                message.FileName = DestinationFilePath;
                MessagesManager.FilePathChange(message.MessageId, DestinationFilePath);
                ((NotificationForm)sender).Dispose();
            }
        }
        private void ChatPageTitleUProfilePictureClicked(object sender, EventArgs e)
        {
            profileImageViewF profileImageViewForm = new profileImageViewF();
            if (isGroup)
                profileImageViewForm.Group = Group;
            else
                profileImageViewForm.Contact = Contact;
            TransparentForm2 transparentForm = new TransparentForm2();
            profileImageViewForm.TransparentFormObj = transparentForm;
            profileImageViewForm.StartPosition = FormStartPosition.CenterParent;
           transparentForm.Control = profileImageViewForm;       
            transparentForm.Size = new Size(Size.Width - 10, Size.Height - 6);
         
            transparentForm.Location = new Point(Location.X + 5, Location.Y + 1);
          
            transparentForm.Opacity = 0.1;
            profileImageViewForm.Location = new Point(Location.X + (Width / 2) - profileImageViewForm.Width / 2, Location.Y + (Height / 2) - profileImageViewForm.Height / 2);
            transparentForm.Show();
            profileImageViewForm.ShowDialog();
        }

        private void ChatPageSearchBoxTextchanged(object sender, EventArgs e)
        {
            alreadyMessagedContactsPanel.SuspendLayout();
            foreach (Control control in alreadyMessagedContactsPanel.Controls)
            {
                ContactU contactU = control as ContactU;
                if (contactU != null)
                {
                    contactU.Visible = true;
                }
            }
            if (!chatPageSearchBox.IsPlaceholder && chatPageSearchBox.Text != chatPageSearchBox.PlaceholderText)
            {
                if (!string.IsNullOrWhiteSpace(chatPageSearchBox.Text))
                {
                    string searchText = chatPageSearchBox.Text.Trim();
                    for (int i = 0; i < alreadyMessagedContactsPanel.Controls.Count; i++)
                    {
                        ContactU contactU = alreadyMessagedContactsPanel.Controls[i] as ContactU;
                        if (contactU != null && contactU.ContactName.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) == 0)
                        {
                            contactU.SendToBack();
                        }
                        else
                        {
                            contactU.Visible = false;
                        }
                    }
                }
            }
            alreadyMessagedContactsPanel.ResumeLayout();
        }

        private void ChatPageTitleUGroupMemberContactNameGet(object sender, Contact contact)
        {
            string temp = messageTB.Text;
            string contactName = ContactsManager.getName(contact.HostName);
            if (!messageTB.Text.Contains("@" + contactName + "\n"))
            {
                messageTB.SelectionColor = Color.DodgerBlue;
                messageTB.Text = "@" + contactName + "\n";
                //  messageTB.SelectionColor = messageTB.ForeColor;
                messageTB.Text += temp;
            }
        }

        private void ChatPageTitleULeaveFromGroupBtnClicked(object sender, Group group)
        {
            if(group.IsArchived){
                ArchivedContactsPanel.Controls.Remove(ContactUDictionary[group.GroupID+""]);
            }
            else
                alreadyMessagedContactsPanel.Controls.Remove(ContactUDictionary[group.GroupID + ""]);
        }
        private void FilterContactsBtnClicked(object sender, EventArgs e)
        {
            Point point = filterContactsBtn.PointToScreen(new Point(0, 0));
            FilterChatByF filterChatByF = new FilterChatByF();
            filterChatByF.OnClickContactBtn += FilterChatByFOnClickContactBtn;
            filterChatByF.OnClickGroupBtn += FilterChatByFOnClickGroupBtn;
            filterChatByF.OnClickUnreadBtn += FilterChatByFOnClickUnreadBtn;
            filterChatByF.OnClickAllBtn += FilterChatByFOnClickAllBtn;
            filterChatByF.Location = new Point(point.X, point.Y + 60);
            TransparentForm transparentForm = new TransparentForm();
            filterChatByF.transparentFormObj = transparentForm;
            filterChatByF.OnClickFilterContactsBy += transparentForm.TransparentFormClick;
            transparentForm.Control = filterChatByF;
            transparentForm.Show();
            filterChatByF.Show();
        }
        private void FilterChatByFOnClickAllBtn(object sender, EventArgs e)
        {
            chatLB.Text = "Chats";
            alreadyMessagedContactsPanel.SuspendLayout();
            for (int i = 0; i < alreadyMessagedContactsPanel.Controls.Count; i++)
            {
                ContactU contactU = (ContactU)alreadyMessagedContactsPanel.Controls[i];
                contactU.Visible = true;
            }
            alreadyMessagedContactsPanel.ResumeLayout();
        }
        private void FilterChatByFOnClickUnreadBtn(object sender, EventArgs e)
        {
            chatLB.Text = "UnRead";
            alreadyMessagedContactsPanel.SuspendLayout();
            for (int i = 0; i < alreadyMessagedContactsPanel.Controls.Count; i++)
            {
                ContactU contactU = (ContactU)alreadyMessagedContactsPanel.Controls[i];
                if (contactU.NewMessageCount > 0)
                    contactU.Visible = true;
                else
                    contactU.Visible = false;
            }
            alreadyMessagedContactsPanel.ResumeLayout();
        }
        private void FilterChatByFOnClickGroupBtn(object sender, EventArgs e)
        {
            chatLB.Text = "Groups";
            alreadyMessagedContactsPanel.SuspendLayout();
            for (int i = 0; i < alreadyMessagedContactsPanel.Controls.Count; i++)
            {
                ContactU contactU = (ContactU)alreadyMessagedContactsPanel.Controls[i];
                if (contactU.IsGroup)
                    contactU.Visible = true;
                else
                    contactU.Visible = false;
            }
            alreadyMessagedContactsPanel.ResumeLayout();
        }
        private void FilterChatByFOnClickContactBtn(object sender, EventArgs e)
        {
            chatLB.Text = "Contacts";
            alreadyMessagedContactsPanel.SuspendLayout();
            for (int i = 0; i < alreadyMessagedContactsPanel.Controls.Count; i++)
            {
                ContactU contactU = (ContactU)alreadyMessagedContactsPanel.Controls[i];
                if (!contactU.IsGroup)
                    contactU.Visible = true;
                else
                    contactU.Visible = false;
            }
            alreadyMessagedContactsPanel.ResumeLayout();
        }

        private void NewMessageArrivedUpdate(Message message)
        {
            //Check Contact or Group exits or not
            if (message.GroupId == 0)
            {
                if (!ContactsManager.IsContactExistsinContactsList(message.FromHostName))
                {
                    if (NetworkManager.ServerHostName != NetworkManager.PcHostName)
                    {
                        DatabaseManager.UpdateServerContactsInPcDatabase();
                    }
                    ContactsManager.Contacts_list.Add(ContactsManager.getContactFromLocalDatabase(message.FromHostName));
                }
                BeginInvoke((Action)(() => ContactExitsAndCreate(message.FromHostName)));

            }
            else
            {
                if (NetworkManager.PcHostName == NetworkManager.ServerHostName)
                {
                  
                    if (!GroupExistsInChat(message.GroupId))
                    {
                        Group group = GroupsManager.GetGroupFromLocalDataBase(message.GroupId);
                        GroupsManager.Groups_List.Add(group);
                        BeginInvoke((Action)(() => ContactUCreateGroup(group)));
                    }
                }
                else
                {
                    if (!GroupsManager.GroupExitsInDatabase(message.GroupId))
                    {
                        if (DatabaseManager.UpdateServerGroupsInPcDatabase())
                        {
                            Group group = GroupsManager.GetGroupFromLocalDataBase(message.GroupId);
                            GroupsManager.Groups_List.Add(group);
                            BeginInvoke((Action)(() => ContactUCreateGroup(group)));
                        }
                    }
                }
            }
            //Notification  Create
            if (this.WindowState == FormWindowState.Minimized && !message.IsFile&&SettingManager.IsMuteTheMessageNotification==false)
                BeginInvoke((Action)(() => SettingManager.notificationThrowManager.CreateMessageNotification(message, message.GroupId > 0 ? GroupsManager.GetGroupName(message.GroupId) + ":" + ContactsManager.getName(message.FromHostName) : ContactsManager.getName(message.FromHostName))));
            if (message.IsFile)
                BeginInvoke((Action)(() => SettingManager.notificationThrowManager.CreateFileNotification(message, message.GroupId > 0 ? GroupsManager.GetGroupName(message.GroupId) + ":" + ContactsManager.getName(message.FromHostName) : ContactsManager.getName(message.FromHostName))));

            if ((isGroup == false && message.GroupId == 0 && (this.Contact != null) && (this.Contact.HostName == message.FromHostName)) || (isGroup && (this.Group != null) && Group.GroupID == message.GroupId))
            {
                MessagesManager.Message_List.Insert(0, message);
                BeginInvoke((Action)(() => SingleMessageAlign()));
            }
            else
                BeginInvoke((Action)(() => NewMessageArrived(message)));
        }
        public void ContactExitsAndCreate(string hostName)
        {
            for (int i = 0; i < ContactsManager.Contacts_list.Count; i++)
            {
                if (ContactsManager.Contacts_list[i].HostName == hostName)
                {
                    if (!ContactsManager.IsContactExitsInMessagedContactsList(ContactsManager.Contacts_list[i])){
                        ContactUCreateContact(ContactsManager.Contacts_list[i]);
                    }                    
                }
            }
        }
     
        private void NewMessageArrived(Message message)
        {
                if (message.GroupId == 0)
                {
                ContactUDictionary[message.FromHostName].NewMessageCount += 1;
                ContactUDictionary[message.FromHostName].LastMessage = message;
                ContactUDictionary[message.FromHostName].SendToBack();
                }
                if (message.GroupId > 0)
                {
                ContactUDictionary[message.GroupId+""].NewMessageCount += 1;
                ContactUDictionary[message.GroupId + ""].LastMessage = message;
                ContactUDictionary[message.GroupId + ""].SendToBack();
            }      
        }

        private void CreateGroupPageUOnClickGroupCreate(object sender, EventArgs e)
        {
            GroupsRefresh();
        }

        private void MainFormMinimumSizeChanged(object sender, EventArgs e)
        {

        }
        public ChatU SingleMessageAlign()
        {
            prevMessageReadCount++;
            MessageReadCount++;
            messageShowP.SuspendLayout();
            Panel Dateapanel = null;
            if (MessagesManager.Message_List.Count == 1 || (MessagesManager.Message_List[1].DateAndTime.ToShortDateString() != MessagesManager.Message_List[0].DateAndTime.ToShortDateString()))
            {
                MessageDateU hoverMessageU = new MessageDateU(MessagesManager.Message_List[0].DateAndTime) { Visible = true };
                Dateapanel = new Panel();
                Dateapanel.Resize += DatePanelResize;
                Dateapanel.Height = hoverMessageU.Height + 10;
                Dateapanel.Padding = new Padding(10, 5, 15, 5);
                Dateapanel.Controls.Add(hoverMessageU);
                messageShowP.Controls.Add(Dateapanel);
                Dateapanel.Dock = DockStyle.Top;
                hoverMessageU.Location = new Point(Dateapanel.Width / 2 - hoverMessageU.Width / 2 - 20, 0);
            }
            if (Dateapanel != null)
                Dateapanel.BringToFront();
            Panel chatPanel = ChatUAdd(MessagesManager.Message_List[0]);
            chatPanel.BringToFront();
            LastMessageSet(MessagesManager.Message_List[0]);
            messageShowP.ResumeLayout();
            messageShowP.ScrollControlIntoView(chatPanel);
            messageShowP.PerformLayout();
            return (ChatU)chatPanel.Controls[0];
        }


        public void LastMessageSet(Message message)
        {
            string hostname = "";
            if (NetworkManager.PcHostName == message.ToHostName)
            {
                hostname = message.FromHostName;
            }
            else
            {
                hostname = message.ToHostName;
            }
            if (message.GroupId == 0)
            {
                ContactUDictionary[hostname].LastMessage = message;
                ContactUDictionary[hostname].SendToBack();
            }
            else
            {
                ContactUDictionary[message.GroupId + ""].LastMessage = message;
                ContactUDictionary[message.GroupId + ""].SendToBack();
            }

        }

        private void DatePanelResize(object sender, EventArgs e)
        {
            Panel panel = (Panel)(sender);
            for (int i = 0; i < panel.Controls.Count; i++)
                panel.Controls[i].Location = new Point(panel.Width / 2 - panel.Controls[i].Width / 2 - 20, panel.Padding.Top);
        }

        private void SentBtnClick(object sender, EventArgs e)
        {
            if ((this.Contact != null || this.Group != null) && messageTB.Text != "" && messageTB.Text != "\n"&& messageTB.Text.Length<=8000)
            {
                sendingText = messageTB.Text;
                MessageSent();
            }
        }
        private void MessageSent()
        {
            Message message = null;
            sendingText = sendingText.Trim();
            if (!isGroup)
            {
                message = new Message(0, NetworkManager.PcHostName, this.Contact.HostName, 0, DateTime.Now, sendingText, false, false, "");
            }
            else
            {
                message = new Message(0, NetworkManager.PcHostName, "", this.Group.GroupID, DateTime.Now, sendingText, false, false, "");
            }
            message = MessagesManager.CreateMessage(message);
            ChatU messageChatU = null;
            if (message != null)
            {
                MessagesManager.Message_List.Insert(0, message);
                if (((message.GroupId == 0 && (this.Contact != null) && (this.Contact.HostName == message.ToHostName)) || ((this.Group != null) && Group.GroupID == message.GroupId)))
                {
                    messageChatU = SingleMessageAlign();
                }
            }
            Thread tread = new Thread(new ThreadStart(() => MessageSentThreadInvoke(message, messageChatU)));
            tread.Start();
            messageTB.Clear();
        }
        private void QueueMessageStartInvoke()
        {
            System.Windows.Forms.Timer QueueTimer = new System.Windows.Forms.Timer();
            QueueTimer.Interval = 10000;
            QueueTimer.Tick += QueueMessageStart;
            QueueTimer.Start();
        }
        private void QueueMessageStart(object sender, EventArgs e)
        {

            if (!QueueUnSentMessageManager.IsQueueOn)
            {
                QueueUnSentMessageManager.QueueSetUp();
                if (QueueUnSentMessageManager.QueueMessages_List.Count == 0)
                {
                    ((System.Windows.Forms.Timer)sender).Stop();
                }
                Thread tread = new Thread(new ThreadStart(threadmethod));
                tread.Priority = ThreadPriority.Highest;
                tread.Start();
            }

        }
        private void threadmethod()
        {
            QueueUnSentMessageManager.QueueStart();
        }
        private async void MessageSentThreadInvoke(Message message, ChatU messageChatU)
        {
            if (message.GroupId == 0)
            {
                var data = NetworkManager.MessageSent(message, ContactsManager.ContactDictionary[message.ToHostName]);
                if (data.Status != TaskStatus.Faulted)
                {
                    message.IsSent = true;
                    MessagesManager.UpdateIsSent(message);
                    BeginInvoke((Action)(() => { messageChatU.IsSent = true; }));
                }
            }
            else
            {
                GroupMessageSent(message, Group, messageChatU);
            }
        }
     
        private void GroupMessageSent(Message message, Group group, ChatU messageChatU)
        {
            bool isMessageSentToALL = true;
            int Count = 0;
            for(int i=0;i< group.GroupMembers.Count- Count; i++){
            if(group.GroupMembers[i].Contact.IsOnline==false){
                    GroupMember groupMember = group.GroupMembers[i];
                    group.GroupMembers.RemoveAt(i);
                    group.GroupMembers.Add(groupMember);
                    i--;
                    Count++;
            }
            }
            for (int i = 0; i < group.GroupMembers.Count; i++)
            {
                message.ToHostName = group.GroupMembers[i].Contact.HostName;
                var data = NetworkManager.MessageSent(message, ContactsManager.ContactDictionary[message.ToHostName]);
                if (data.Status == TaskStatus.Faulted)
                {
                    MessagesManager.CreateUnSentGroupMessage(message);
                    isMessageSentToALL = false;
                }
            }
            if (isMessageSentToALL)
            {
                message.IsSent = true;
                MessagesManager.UpdateIsSent(message);
                BeginInvoke((Action)(() => { messageChatU.IsSent = true; }));
            }
        }

        private void MainFormResize(object sender, EventArgs e)
        {
            menuTabControl.Size = new Size((int)((Width / 7)*2), menuTabControl.Size.Height);
            chatPageTitleU.Height = Height / 13;
            chatPageTopPanel.Height = Height / 13;
            //  contactUSearchBox.Height = Height / 18;
            // menuControl.Width = Width / 25;
        }

        private void MainFormFormClosed(object sender, FormClosedEventArgs e)
        {
            ContactsManager.UpdateLastOnlineTime(ContactsManager.PCContact.HostName, DateTime.Now);
            DatabaseManager.ChatApplicationServerConnection();
            ContactsManager.UpdateLastOnlineTime(ContactsManager.PCContact.HostName, DateTime.Now);
            Application.Exit();
        }

        private void ContactListBtnClick(object sender, EventArgs e)
        {
            ContactListF contactListF = new ContactListF(ContactsManager.Contacts_list);
            TransparentForm transparentForm = new TransparentForm();
            contactListF.transparentFormObj = transparentForm;
            transparentForm.Control = contactListF;
            Point point = contactListBtn.PointToScreen(new Point(0, 0));             
            contactListF.Location = new Point(point.X, point.Y + 60);
            contactListF.onClickContactGet += ContactListOnclickContactGet;
            contactListF.OnGroupCreatedInvoke += CreateGroupPageUOnClickGroupCreate;
            contactListF.OnclickClose += transparentForm.TransparentFormClick;
            transparentForm.Show();
            contactListF.Show();
        }

        private void ContactListOnclickContactGet(object sender, Contact contact)
        {
            prevDateAndTime = DateTime.MinValue;
            if (sender is ContactListU)
            {
                ((ContactListU)sender).Dispose();
            }
            ContactU contactU;
            if (prevContactU != null)
            {
                prevContactU.IsSelected = false;
            }
            if (!ContactsManager.IsContactExitsInMessagedContactsList(contact))
            {
                    contactU = ContactUCreateContact(contact);
            }
            else
            {
                contactU = ContactUGet(contact);
            }
            contactU.IsSelected = true;
            prevContactU = contactU;
            ContactUObject = contact;
        }
        private ContactU ContactUGet(Contact contact)
        {
           if(ContactUDictionary.ContainsKey(contact.HostName))
            return ContactUDictionary[contact.HostName];
            return null;
        }
        private ContactU ContactUCreateGroup(Group group)
        {
            ContactU contactU = new ContactU(group) { Dock = DockStyle.Top };
            ContactUDictionary.Add(""+group.GroupID, contactU);
        //    contactU.DataBindings.Add("NewMessageCount", group, "NewMessageCount");
            contactU.LastMessage = MessagesManager.GetLastSentedMessage(group.GroupID);
            if (contactU.IsArchived)
                ArchivedContactsPanel.Controls.Add(contactU);
            else
                alreadyMessagedContactsPanel.Controls.Add(contactU);

            contactU.OnclickGetContact += ContactUOnClickContactOrGroupGet;
            return contactU;
        }

        private bool GroupExistsInChat(int groupId)
        {
            return ContactUDictionary.ContainsKey(groupId + ""); 
        }

        private ContactU ContactUCreateContact(Contact contact)
        {
            ContactU contactU = new ContactU(contact) { Dock = DockStyle.Top };
            ContactUDictionary.Add(contact.HostName, contactU);
            contactU.LastMessage = MessagesManager.GetLastSentedMessage(contact.HostName, NetworkManager.PcHostName);
            if (contact.IsArchived)
                ArchivedContactsPanel.Controls.Add(contactU);
            else
                alreadyMessagedContactsPanel.Controls.Add(contactU);
            contactU.OnclickGetContact += ContactUOnClickContactOrGroupGet;
            Thread thread = new Thread(()=>ConntectAndCheckToContact(contact));
            thread.Start();
            return contactU;
        }
        private void ConntectAndCheckToContact(Contact contact){
            NetworkManager.ConnectToPC(contact);
        }
        private void ContactUOnClickContactOrGroupGet(object sender, object contactOrGroup)
        {
            ContactU contactU = (ContactU)(sender);
            selectedContactU = contactU;
            if (ContactUObject == null || ContactUObject != contactOrGroup)
            {
                ContactUObject = contactOrGroup;
                if (prevContactU != null)
                {
                    prevContactU.IsSelected = false;
                }
                contactU.IsSelected = true;
                prevContactU = contactU;

                if (prevContactU != null)
                {
                    prevContactU.IsSelected = false;
                }
                contactU.IsSelected = true;
                prevContactU = contactU;
            }
        }
  
        private void MainFormLoad(object sender, EventArgs e)
        {
            menuTabControl.ItemSize = new Size(0, 1);
            mainTabControl.ItemSize = new Size(0, 1);

            //Load the Datas
            refreshBtnClicked(this, EventArgs.Empty);
            try
            {
                menuControl.ProfilePicturePath = ContactsManager.PCContact.DpPicture;
            }
            catch
            {

            }
            mainTabControl.SelectedTab = defaultPage;

            // Queue start
            QueueMessageStartInvoke();

            //SetUp
            ChatPageColor = SettingManager.ChatPageBackGroundColor;
        }


        private void StartedMessagePageBtnClicked(object sender, EventArgs e)
        {

            menuTabControl.SelectedTab = starredMessagePage;
            mainTabControl.SelectedTab = defaultPage;
        }

        private void StatusPageBtnClicked(object sender, EventArgs e)
        {
            menuTabControl.SelectedTab = StatusPage;
            mainTabControl.SelectedTab = defaultPage;
        }

        private void ChatsPageBtnClicked(object sender, EventArgs e)
        {
            menuTabControl.SelectedTab = chatPage;
            if (ContactOrGroupObject!=null)
            {
              
                if (chatPageTitleU.IsArchived)
                    mainTabControl.SelectedTab = defaultPage;
                else
                    mainTabControl.SelectedTab = chatTabpage;
            }
        }

        private void CallsPageBtnClicked(object sender, EventArgs e)
        {
            menuTabControl.SelectedTab = callsPage;
            mainTabControl.SelectedTab = defaultPage;
        }

        private void ArchivedPageBtnClicked(object sender, EventArgs e)
        {
            menuTabControl.SelectedTab = archivedPage;
            if (ContactOrGroupObject != null)
            {
                if (!chatPageTitleU.IsArchived)
                    mainTabControl.SelectedTab = defaultPage;
                else
                    mainTabControl.SelectedTab = chatTabpage;
            }
            else{
                mainTabControl.SelectedTab = defaultPage;
            }
        }
        private void ProfilePicturePictureBoxClicked(object sender, EventArgs e)
        {
            SettingF settingF = new SettingF();
            settingF.IsProfilePageSelected = true;
            SettingFormShow(settingF);
        }

        private void SettingPageBtnClicked(object sender, EventArgs e)
        {
            SettingF settingF = new SettingF();
            SettingFormShow(settingF);
        }
        private void SettingFormShow(SettingF settingF)
        {
            settingF.OnHoverChatPageColorChange += SettingFOnHoverChatPageColorChange;
            settingF.OnLeaveChatPageColorChange += SettingFOnLeaveChatPageColorChange;
            settingF.OnClickChatPageColorSelect += SettingFOnClickChatPageColorSelect;
            settingF.OnClickDeleteAllTheMessage += SettingFOnClickDeleteAllTheMessage;
            TransparentForm transparentForm = new TransparentForm();
            settingF.transparentFormObj = transparentForm;
            transparentForm.Control = settingF;
            transparentForm.Size = new Size(Size.Width - 10, Size.Height - 6);
            transparentForm.Location = new Point(Location.X + 5, Location.Y + 1);
            transparentForm.WindowState = FormWindowState.Normal;
            transparentForm.Opacity = 0.1;
            Point point = PointToScreen(new Point(0, Height - 450 - 38));
            settingF.Location = point;
            transparentForm.Show();
            settingF.Show();
        }
        private void SettingFOnClickDeleteAllTheMessage(object sender, EventArgs e)
        {
            messageShowP.Controls.Clear();
            prevMessageReadCount = 0;
            MessageReadCount = 0;
        }

        private void SettingFOnClickChatPageColorSelect(object sender, EventArgs e)
        {
            ChatPageColor = SettingManager.ChatPageBackGroundColor;
        }

        private void SettingFOnLeaveChatPageColorChange(object sender, EventArgs e)
        {
            messageShowP.BackColor = chatPageColor;
        }

        private void SettingFOnHoverChatPageColorChange(object sender, Color color)
        {
            messageShowP.BackColor = color;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public void AlreadyExitsMessagedContactsCreate()
        {
            alreadyMessagedContactsPanel.SuspendLayout();
            for (int i = 0; i < ContactsManager.MessagedContacts_list.Count; i++)
            {
                ContactUCreateContact(ContactsManager.getContact(ContactsManager.MessagedContacts_list[i].HostName));
            }
            alreadyMessagedContactsPanel.ResumeLayout();
            alreadyMessagedContactsPanel.PerformLayout();
        }
    
        public void GroupsRefresh()
        {
            for (int i = 0; i < GroupsManager.Groups_List.Count; i++)
            {
                if (!GroupExistsInChat(GroupsManager.Groups_List[i].GroupID))
                    ContactUCreateGroup(GroupsManager.Groups_List[i]);
            }
        }
        public void AlreadyExitsGroupsCreate()
        {
            alreadyMessagedContactsPanel.SuspendLayout();
            for (int i = 0; i < GroupsManager.Groups_List.Count; i++)
            {
                ContactUCreateGroup(GroupsManager.Groups_List[i]);
            }
            alreadyMessagedContactsPanel.ResumeLayout();
            alreadyMessagedContactsPanel.PerformLayout();
        }
        private void messageTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainSearchBoxPanelResize(object sender, EventArgs e)
        {

            chatPageSearchBox.Width = (chatPageSearchBoxPanel.Width / 4) * 3;
            chatPageSearchBox.Location = new Point(chatPageSearchBoxPanel.Width / 2 - chatPageSearchBox.Width / 2, chatPageSearchBoxPanel.Height / 2 - chatPageSearchBox.Height / 2);
        }

        private void messageShowPScroll(object sender, ScrollEventArgs e)
        {

            if (messageShowP.VerticalScroll.Value == messageShowP.VerticalScroll.Minimum)
            {
                if (!IsAllMessagesReaded)
                {
                    if (!isGroup)
                    {
                        MessagesManager.Message_List.AddRange(MessagesManager.GetMessages(NetworkManager.PcHostName, Contact.HostName, ref MessageReadCount, ref IsAllMessagesReaded, messageShowP.MaximumSize.Height / 50 + 1));
                    }
                    else
                    {
                        DateTime JoinDateTime = DateTime.MinValue;
                        for (int i = 0; i < this.Group.GroupMembers.Count; i++)
                        {
                            if (this.Group.GroupMembers[i].Contact.HostName == NetworkManager.PcHostName)
                            {
                                JoinDateTime = this.Group.GroupMembers[i].JoinDate;
                                break;
                            }
                        }
                        MessagesManager.Message_List.AddRange(MessagesManager.GetMessages(this.Group.GroupID, JoinDateTime, ref MessageReadCount, ref IsAllMessagesReaded, messageShowP.MaximumSize.Height / 50 + 1));
                    }
                    MessagesAlign();
                }

            }
        }
        private void MessageShowPMouseWheel(object sender, MouseEventArgs e)
        {
            editSheet.Visible = false;
            messageShowPScroll(this, new ScrollEventArgs(ScrollEventType.LargeDecrement, 1));

        }
        private void MessagesAlign()
        {
            Panel scrollViewPanel = null;
            if (MessagesManager.Message_List != null && this.WindowState != FormWindowState.Minimized)
            {
                messageShowP.SuspendLayout();
                for (int i = prevMessageReadCount; i < MessageReadCount; i++)
                {
                    if (i > 0 && MessagesManager.Message_List[i].DateAndTime.ToShortDateString() != MessagesManager.Message_List[i - 1].DateAndTime.ToShortDateString())
                    {
                        DateUAdd(MessagesManager.Message_List[i - 1].DateAndTime);
                    }
                    Panel chatPanel = ChatUAdd(MessagesManager.Message_List[i]);
                    if (i == prevMessageReadCount)
                    {
                        scrollViewPanel = chatPanel;
                    }
                }
                messageShowP.ResumeLayout();
                if (MessagesManager.Message_List.Count > 0 && IsAllMessagesReaded)
                {
                    DateUAdd(MessagesManager.Message_List[MessagesManager.Message_List.Count - 1].DateAndTime);
                }
                if (scrollViewPanel != null)
                {
                    messageShowP.Invalidate();
                    messageShowP.ScrollControlIntoView(scrollViewPanel);
                    messageShowP.PerformLayout();
                }
                prevMessageReadCount = MessageReadCount;
            }
        }

        private Panel ChatUAdd(Message message)
        {
            ChatU chatU = new ChatU(message) { IsNormal = true, ChatUMaximumWidth = (messageShowP.Width / 5) * 3 };
            chatU.OnClickMessageGet += HandleChatUCliked;
            ChatUPanel chatPanel = new ChatUPanel(chatU);
            chatPanel.OnclickChatUPanel += ChatPanelOnclickChatUPanel;
            chatPanel.SelectedChatUPanelInvoke += ChatPanelSelectedChatUPanelInvoke;
            chatPanel.UnSelectedChatUPanelInvoke += ChatPanelUnSelectedChatUPanelInvoke;
            messageShowP.Controls.Add(chatPanel);
            return chatPanel;
        }

        private void ChatPanelOnclickChatUPanel(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedMessageOperationForm selectedMessageOperationForm = new SelectedMessageOperationForm();
                selectedMessageOperationForm.OnclickCloseChatBtn += SelectedMessageOperationFormOnclickCloseChatBtn;
                selectedMessageOperationForm.OnclickdeleteSelectedMessageBtn += SelectedMessageOperationFormOnclickdeleteSelectedMessageBtn;
                selectedMessageOperationForm.Location = Cursor.Position;
                selectedMessageOperationForm.Show();
            }
        }

        private void SelectedMessageOperationFormOnclickdeleteSelectedMessageBtn(object sender, EventArgs e)
        {
            ((Form)sender).Close();
           
            IsMessageSelectionOn = false;
            foreach (var keyValue in SelectedMessagesChatU)
            {
                MessagesManager.DeleteMessage(keyValue.Value.Message.MessageId);
                keyValue.Value.Dispose();
                keyValue.Key.Dispose();
            }
            
        }

        private void SelectedMessageOperationFormOnclickCloseChatBtn(object sender, EventArgs e)
        {
            selectedContactU.IsSelected = false;
            ContactUObject = null;
              selectedContactU = null;
            ((Form)sender).Close();
            mainTabControl.SelectedTab = defaultPage;
            IsMessageSelectionOn = false;
             Contact = null;
            Group = null;
        }

        private void ChatPanelUnSelectedChatUPanelInvoke(object sender, EventArgs e)
        {
            SelectedMessagesChatU.Remove((ChatUPanel)(sender));
            if (SelectedMessagesChatU.Count == 0)
            {
                IsMessageSelectionOn = false;
            }
           
        }

        private void ChatPanelSelectedChatUPanelInvoke(object sender, EventArgs e)
        {
            SelectedMessagesChatU.Add((ChatUPanel)(sender), ((ChatUPanel)sender).ChatU);
        }

        private Panel DateUAdd(DateTime dateTime)
        {
            Panel panelforDate = null;
            MessageDateU hoverMessageU = new MessageDateU(dateTime) { Visible = true };
            panelforDate = new Panel();
            panelforDate.Resize += DatePanelResize;
            panelforDate.Height = hoverMessageU.Height + 10;
            panelforDate.Padding = new Padding(10, 7, 15, 5);
            panelforDate.Controls.Add(hoverMessageU);
            messageShowP.Controls.Add(panelforDate);
            panelforDate.Dock = DockStyle.Top;
            hoverMessageU.Location = new Point(panelforDate.Width / 2 - hoverMessageU.Width / 2 - 20, 0);
            return panelforDate;
        }
        //Kowshick
        private ChatU selectedChatU;
        private Message selectedMessage;
        private ContactU selectedContactU;
        private EditSheet editSheet = new EditSheet();
        private void HandleChatUCliked(object sender, Message message)
        {
            ChatU Temp = (ChatU)sender;
            selectedChatU = Temp;
            selectedMessage = message;
            editSheet.IsSelectedFile = message.IsFile;
            Point P = Temp.PointToScreen(Point.Empty); // Get screen coordinates of ChatU control
            if (Temp.IsReceivedMessage)
            {
                Point EditsheetLocation = new Point(P.X + Temp.Width + 5, P.Y);
                Point panelLocationforCheck = messageShowP.PointToScreen(new Point(0, 0));
                if (panelLocationforCheck.Y > EditsheetLocation.Y)
                    EditsheetLocation.Y = panelLocationforCheck.Y;
                else if (EditsheetLocation.Y + editSheet.Height > panelLocationforCheck.Y + messageShowP.Height)
                {
                    EditsheetLocation.Y = panelLocationforCheck.Y + messageShowP.Height - editSheet.Height;
                }
                editSheet.Location = EditsheetLocation;
                editSheet.Visible = true;
            }
            else
            {
                Point EditsheetLocation = new Point(P.X - editSheet.Width - 5, P.Y);
                Point panelLocationforcheck = messageShowP.PointToScreen(new Point(0, 0));
                if (panelLocationforcheck.Y > EditsheetLocation.Y)
                    EditsheetLocation.Y = panelLocationforcheck.Y;
                else if (EditsheetLocation.Y + editSheet.Height > panelLocationforcheck.Y + messageShowP.Height)
                {
                    EditsheetLocation.Y = panelLocationforcheck.Y + messageShowP.Height - editSheet.Height;
                }
                editSheet.Location = EditsheetLocation;
                editSheet.Visible = true;
            }
            editSheet.BringToFront();
            // EditSheet2.Show();                         
        }
        private void FilterSelected(object sender, string e)
        {
            if (e.Equals("Copy"))
            {
                Clipboard.SetText(selectedChatU.Message.MessageText);
            }

            else if (e.Equals("Delete"))
            {
                if (MessagesManager.DeleteMessage(selectedMessage.MessageId))
                {
                    if (MessagesManager.Message_List == null) MessagesManager.Message_List = new List<Message>();
                    if (selectedChatU != null)
                    {
                        Panel ChatUParent = (Panel)selectedChatU.Parent;
                        messageShowP.Controls.Remove(ChatUParent);
                        MessagesManager.Message_List.Remove(selectedChatU.Message);
                        MessageReadCount--;
                    }
                    if (MessagesManager.Message_List.Count > 0)
                        LastMessageSet(MessagesManager.Message_List[0]);
                }
            }

            else if (e.Equals("Open"))
            {
                try
                {
                    string path = selectedChatU.Message.FileName;
                    if (System.IO.File.Exists(path))
                    {
                        Process.Start(path);
                    }
                    else
                    {
                        SettingManager.notificationThrowManager.CreateNotification("File not Found", NotificationType.None);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (e.Equals("Select"))
            {
                SelectedMessagesChatU.Add((ChatUPanel)selectedChatU.Parent, selectedChatU);
                ((ChatUPanel)selectedChatU.Parent).IsSelected=true;
                IsMessageSelectionOn = true;
            }
            else if (e.Equals("DeleteAll"))
            {
                MessageConfirmForm messageConfirmForm = new MessageConfirmForm("Do you want delete all \n    messages");
                messageConfirmForm.Location = new Point(Location.X + (Width / 2) - messageConfirmForm.Width / 2, Location.Y + (Height / 2) - messageConfirmForm.Height / 2);

                if (messageConfirmForm.ShowDialog() == DialogResult.Yes)
                {
                    if (!selectedContactU.IsGroup) {
                        MessagesManager.DeleteAllMessage(selectedContactU.Contact.HostName, NetworkManager.PcHostName);
                    } 
                    else{
                        MessagesManager.DeleteAllMessage(selectedContactU.Group.GroupID);
                    }
                    selectedContactU.LastMessage = null;
                    MessagesManager.Message_List.Clear();
                    MessageReadCount = 0;
                    messageShowP.Controls.Clear();
                   
                }
            }
            editSheet.Visible = false;
        }


        private void messageTBKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SentBtnClick((object)sentBtn, EventArgs.Empty);
                messageTB.Text = "";
                messageTB.TabIndex = 0;
            }
          
        }
        private void FileSendInvoke()
        {
            string filename = Path.GetFileName(selectedAttachMentFilePath);
            selectedAttachMentFilePath = selectedAttachMentFilePath.Replace("\\", "\\\\\\\\");
            MessageConfirmForm confirmForm = new MessageConfirmForm("Do you want to sent the \n" + filename);
            confirmForm.StartPosition = FormStartPosition.Manual;
            confirmForm.Location = new Point(Location.X + (Width / 2) - confirmForm.Width / 2, Location.Y + (Height / 2) - confirmForm.Height / 2);
            if (confirmForm.ShowDialog() == DialogResult.Yes)
            {
                string fileName = Path.GetFileName(selectedAttachMentFilePath);
                long fileSize = new FileInfo(selectedAttachMentFilePath).Length;

                Message fileMessage;
                if (!isGroup)
                {
                    fileMessage = new Message(0, NetworkManager.PcHostName, Contact.HostName, 0, DateTime.Now, fileName, false, true, @"" + selectedAttachMentFilePath);
                }
                else
                {
                    fileMessage = new Message(0, NetworkManager.PcHostName, "", Group.GroupID, DateTime.Now, fileName, false, true, @"" + selectedAttachMentFilePath);
                }
              
                fileMessage = MessagesManager.CreateMessage(fileMessage);
                MessagesManager.Message_List.Insert(0, fileMessage);
                ChatU messageChatU = null;
                if (((fileMessage.GroupId == 0 && (this.Contact != null) && (this.Contact.HostName == fileMessage.ToHostName)) || ((this.Group != null) && Group.GroupID == fileMessage.GroupId)))
                {
                    BeginInvoke((Action)(() => messageChatU = SingleMessageAlign()));
                }
                fileMessage.FileSize = fileSize;
                try
                {
                if(!isGroup)
                    NetworkManager.FileSent(fileMessage, selectedAttachMentFilePath, ContactsManager.ContactDictionary[fileMessage.ToHostName]);
                else
                   {
                   for(int i=0;i<Group.GroupMembers.Count;i++){
                            
                            NetworkManager.FileSent(fileMessage, selectedAttachMentFilePath, ContactsManager.ContactDictionary[Group.GroupMembers[i].Contact.HostName]);
                        }
                   }
                    fileMessage.IsSent = true;
                    MessagesManager.UpdateIsSent(fileMessage);
                    BeginInvoke((Action)(() => { messageChatU.IsSent = true; }));
                }
                catch
                {
                    SettingManager.notificationThrowManager.CreateNotification("Receiver not respond to send File", NotificationType.Information);
                }
            }

        }
        private void attachmentBtnClick(object sender, EventArgs e)
        {
            using (OpenFileDialog saveFileDialog = new OpenFileDialog())
            {
                saveFileDialog.Filter = "All files (*.*)|*.*|" +
                        "Text files (*.txt)|*.txt|" +
                        "PDF files (*.pdf)|*.pdf|" +
                        "Word documents (*.docx)|*.docx|" +
                        "Excel files (*.xlsx)|*.xlsx|" +
                        "Image files (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif|" +
                        "Audio files (*.mp3, *.wav)|*.mp3;*.wav|" +
                        "Video files (*.mp4, *.avi)|*.mp4;*.avi|" +
                        "Executable files (*.exe)|*.exe|" +
                        "Compressed files (*.zip, *.rar)|*.zip;*.rar";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedAttachMentFilePath = saveFileDialog.FileName;
                    Thread tread = new Thread(new ThreadStart(FileSendInvoke));
                    tread.Start();
                }
            }

        }
        private void ThemeSetUp(object sender, EventArgs e)
        {
            chatPageSearchBox.BorderColor = SettingManager.PrimaryThemeColor;
            if (SettingManager.ThemeNumber == 0)
            {
                defaultPage.BackgroundImage = Properties.Resources.Icon_LightGreen;
                Icon icon = Icon.FromHandle(Properties.Resources.Icon_LightGreen.GetHicon());
                Icon = icon;
            }
            else if (SettingManager.ThemeNumber == 1)
            {
                defaultPage.BackgroundImage = Properties.Resources.Icon_Purple;
                Icon icon = Icon.FromHandle(Properties.Resources.Icon_Purple.GetHicon());
                Icon = icon;
            }
            else if (SettingManager.ThemeNumber == 2)
            {
                defaultPage.BackgroundImage = Properties.Resources.Icon_SkyBlue;
                Icon icon = Icon.FromHandle(Properties.Resources.Icon_SkyBlue.GetHicon());
                Icon = icon;
            }
            else if (SettingManager.ThemeNumber == 3)                                                                 
            {
                defaultPage.BackgroundImage = Properties.Resources.Icon_Blue;
                Icon icon = Icon.FromHandle(Properties.Resources.Icon_Blue.GetHicon());
                Icon = icon;
            }
        }
        public void SortRecentContact(List<ContactU> contacts)
        {
            // Sort the contacts by lastMessageTime in descending order and return the sorted list
           List<ContactU> l=contacts.OrderByDescending(contact => contact.LastMessageTime).ToList();
           for(int i=0;i<l.Count;i++){
                l[i].BringToFront();
           }
        }
        private void refreshBtnClicked(object sender, EventArgs e)
        {         
            menuControl.ImageDispose();
            chatPageTitleU.ImageDispose();
            ContactOrGroupObject = null;
            chatPageTitleU.Contact = null;
            chatPageTitleU.Group = null;
            foreach (var contactU in ContactUDictionary){
                ((ContactU)contactU.Value).Dispose();
            }
            ContactUDictionary.Clear();
            DatabaseManager.DataBaseTablesUpdateFromServer();
            ContactsManager.ContactManagerSetup();
            GroupsManager.GroupsManagerSetUp();
            AlreadyExitsMessagedContactsCreate();
            AlreadyExitsGroupsCreate();
            SortRecentContact(ContactUDictionary.Values.ToList());
            menuControl.ProfilePicturePath = ContactsManager.PCContact.DpPicture;
            mainTabControl.SelectedTab = defaultPage;
        }      
    }
}