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
       
        public static bool IsMessageSelectedOn;
        private object contactUObject;
        // public static TransparentForm transparentForm = new TransparentForm();
        private ContactU prevContactU;
        private string attachMentFilePath;
        private string sendingText = "";
        System.Windows.Forms.ToolTip toolTip;
        private int chatU_Y = 5;
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
                    contactUObject = value;
                    SelectedMessagesChatU.Clear();
                    messageShowP.Controls.Clear();
                    MessagesManager.Message_List.Clear();
                    MessageReadCount = 0;
                    prevMessageReadCount = 0;
                    IsAllMessagesReaded = false;
                    IsMessageSelectedOn = false;
                    if (contactUObject is Group)
                    {
                        isGroup = true;
                        this.Group = (Group)contactUObject;
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
                        this.Contact = (Contact)contactUObject;
                        chatPageTitleU.Contact = Contact;
                        MessagesManager.Message_List.AddRange(MessagesManager.GetMessages(NetworkManager.PcHostName, Contact.HostName, ref MessageReadCount, ref IsAllMessagesReaded, messageShowP.MaximumSize.Height / 50 + 1)); ;
                        if(Contact.IsArchived) {
                            menuControl.ISSelectedArchivedBtn = true;
                            MainTabControl.SelectedTab = chattabpage;
                        }  
                    }
                    prevDateAndTime = DateTime.MaxValue;
                    MessagesAlign();
                    MainTabControl.SelectedTab = chattabpage;
                   
                }
                else
                {
                    contactUObject = value;
                    MainTabControl.SelectedTab = defaultPage;
                }
            }
            get
            {
                return contactUObject;
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
        public MainForm()
        {
            InitializeComponent();
            KeyPreview = true;
            // ThemeSetUp
            ThemeSetUp(this, EventArgs.Empty);
         
            GotFocus += MainFormGotFocus;

            //  panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));

            //menuControl
            menuControl.OnClickArchivedBtn += ChangeTabarchivedPage;
            menuControl.OnClickCallsBtn += ChangeTabCallsPage;
            menuControl.OnClickChatsBtn += ChangeTabChatsPage;
            menuControl.OnClickStatusBtn += ChangeTabStatusPage;
            menuControl.OnClickStarBtn += ChangeTabStartedMessagePage;
            menuControl.OnClickSettingBtn += menuControlOnClickSettingBtn;
            menuControl.OnClickProfilePicture += menuControlOnClickProfilePicture;
            SettingManager.ThemeSetUpInvoke += ThemeSetUp;
            messageShowP.MouseWheel += MessageShowP_MouseWheel;

            //contactList Btn
            contactListBtn.Click += ContactListBtnClick;

            chatPageTitleU.OnclickLeaveFromGroupInvoke += ChatPageTitleUOnclickLeaveFromGroupInvoke;
            chatPageTitleU.OnclickGroupMemberContactGet += ChatPageTitleUOnclickGroupMemberContactGet;
            chatPageTitleU.OnclickProfilePicture += ChatPageTitleUOnclickProfilePicture;
            chatPageTitleU.OnclickAddArchivedBtn += ChatPageTitleUOnclickAddArchivedBtn;
            //MainForm 
            Load += MainFormLoad;
            FormClosed += MainFormFormClosed;
            Resize += MainFormResize;


            //Subcribe to MessageAlign()
            NetworkManager.MessageAlignInvoke = SingleMessageAlign;
            NetworkManager.NewMessageArrivedInvoke = NewMessageArrivedInvokemethod;
            NetworkManager.OnlineStatusInvoke += OnlineStatusUpdateToContact;
            //Notification Manager
            notificationThrowManager.OnClickNotification += NotificationOnClick;
            //sentBtn
            sentBtn.Click += SentBtnClick;

            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance, null, messageShowP, new object[] { true });

            //FilterContactBtn
            filterContactsBtn.Click += FilterContactsBtnClick;
            editSheet.MessageSelected += FilterSelected;
            contactUSearchBox.Textchanged += ContactUSearchBoxTextchanged;
            editSheet.Show();
            editSheet.Visible = false;
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

        private void ChatPageTitleUOnclickAddArchivedBtn(object sender, bool isArchived)
        {
            if (isArchived)
            {
                menuControl.ISSelectedArchivedBtn = true;
                MainTabControl.SelectedTab = chattabpage;
                for (int i = 0; i < chatContactsPanel.Controls.Count; i++)
                {
                    if (chatPageTitleU.IsGroup)
                    {
                        if (((ContactU)chatContactsPanel.Controls[i]).IsGroup && ((ContactU)chatContactsPanel.Controls[i]).Group.GroupID == chatPageTitleU.Group.GroupID)
                        {
                            ArchivedContactsPanel.Controls.Add(chatContactsPanel.Controls[i]);
                            break;
                        }
                    }
                    else
                    {
                        if (!((ContactU)chatContactsPanel.Controls[i]).IsGroup && ((ContactU)chatContactsPanel.Controls[i]).Contact.HostName == chatPageTitleU.Contact.HostName)
                        {
                            ArchivedContactsPanel.Controls.Add(chatContactsPanel.Controls[i]);
                            break;
                        }
                    }
                }
            }
            else
            {
                menuControl.ISSelectedChatsBtn = true;
                MainTabControl.SelectedTab = chattabpage;
                for (int i = 0; i < ArchivedContactsPanel.Controls.Count; i++)
                {
                    if (chatPageTitleU.IsGroup)
                    {
                        if (((ContactU)ArchivedContactsPanel.Controls[i]).IsGroup && ((ContactU)ArchivedContactsPanel.Controls[i]).Group.GroupID == chatPageTitleU.Group.GroupID)
                        {
                            chatContactsPanel.Controls.Add(ArchivedContactsPanel.Controls[i]);
                            break;
                        }
                    }
                    else
                    {
                        if (!((ContactU)ArchivedContactsPanel.Controls[i]).IsGroup && ((ContactU)ArchivedContactsPanel.Controls[i]).Contact.HostName == chatPageTitleU.Contact.HostName)
                        {
                            chatContactsPanel.Controls.Add(ArchivedContactsPanel.Controls[i]);
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
        private void ChatPageTitleUOnclickProfilePicture(object sender, EventArgs e)
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
            profileImageViewForm.Show();
        }

        private void ContactUSearchBoxTextchanged(object sender, EventArgs e)
        {
            chatContactsPanel.SuspendLayout();
            foreach (Control control in chatContactsPanel.Controls)
            {
                ContactU contactU = control as ContactU;
                if (contactU != null)
                {
                    contactU.Visible = true;
                }
            }
            if (!contactUSearchBox.IsPlaceholder && contactUSearchBox.Text != contactUSearchBox.PlaceholderText)
            {
                if (!string.IsNullOrWhiteSpace(contactUSearchBox.Text))
                {
                    string searchText = contactUSearchBox.Text.Trim();
                    for (int i = 0; i < chatContactsPanel.Controls.Count; i++)
                    {
                        ContactU contactU = chatContactsPanel.Controls[i] as ContactU;
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
            chatContactsPanel.ResumeLayout();
        }

        private void ChatPageTitleUOnclickGroupMemberContactGet(object sender, Contact contact)
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

        private void ChatPageTitleUOnclickLeaveFromGroupInvoke(object sender, Group group)
        {
            if(group.IsArchived){
                ArchivedContactsPanel.Controls.Remove(ContactUDictionary[group.GroupID+""]);
            }
            else
                chatContactsPanel.Controls.Remove(ContactUDictionary[group.GroupID + ""]);
        }
        private void FilterContactsBtnClick(object sender, EventArgs e)
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
            chatContactsPanel.SuspendLayout();
            for (int i = 0; i < chatContactsPanel.Controls.Count; i++)
            {
                ContactU contactU = (ContactU)chatContactsPanel.Controls[i];
                contactU.Visible = true;
            }
            chatContactsPanel.ResumeLayout();
        }
        private void FilterChatByFOnClickUnreadBtn(object sender, EventArgs e)
        {
            chatLB.Text = "UnRead";
            chatContactsPanel.SuspendLayout();
            for (int i = 0; i < chatContactsPanel.Controls.Count; i++)
            {
                ContactU contactU = (ContactU)chatContactsPanel.Controls[i];
                if (contactU.NewMessageCount > 0)
                    contactU.Visible = true;
                else
                    contactU.Visible = false;
            }
            chatContactsPanel.ResumeLayout();
        }
        private void FilterChatByFOnClickGroupBtn(object sender, EventArgs e)
        {
            chatLB.Text = "Groups";
            chatContactsPanel.SuspendLayout();
            for (int i = 0; i < chatContactsPanel.Controls.Count; i++)
            {
                ContactU contactU = (ContactU)chatContactsPanel.Controls[i];
                if (contactU.IsGroup)
                    contactU.Visible = true;
                else
                    contactU.Visible = false;
            }
            chatContactsPanel.ResumeLayout();
        }
        private void FilterChatByFOnClickContactBtn(object sender, EventArgs e)
        {
            chatLB.Text = "Contacts";
            chatContactsPanel.SuspendLayout();
            for (int i = 0; i < chatContactsPanel.Controls.Count; i++)
            {
                ContactU contactU = (ContactU)chatContactsPanel.Controls[i];
                if (!contactU.IsGroup)
                    contactU.Visible = true;
                else
                    contactU.Visible = false;
            }
            chatContactsPanel.ResumeLayout();
        }

        private void NewMessageArrivedInvokemethod(Message message)
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
                    ContactsManager.ContactManagerSetup();
                }
                BeginInvoke((Action)(() => ContactExitsAndCreate(message.FromHostName)));

            }
            else
            {
                if (NetworkManager.PcHostName == NetworkManager.ServerHostName)
                {
                    Group group = GroupsManager.GetGroup(message.GroupId);
                    if (!GroupExistsInChat(group))
                    {
                        GroupsManager.GroupsManagerSetUp();
                        BeginInvoke((Action)(() => ContactUCreateGroup(group)));
                    }
                }
                else
                {
                    if (!GroupsManager.GroupExitsInDatabase(message.GroupId))
                    {
                        if (DatabaseManager.UpdateServerGroupsInPcDatabase())
                        {
                            GroupsManager.GroupsManagerSetUp();
                            BeginInvoke((Action)(() => ContactUCreateGroup(GroupsManager.GetGroup(message.GroupId))));
                        }
                    }
                }
            }
            //Notification  Create
            if (this.WindowState == FormWindowState.Minimized && !message.IsFile)
                BeginInvoke((Action)(() => notificationThrowManager.CreateMessageNotification(message, message.GroupId > 0 ? GroupsManager.GetGroupName(message.GroupId) + ":" + ContactsManager.getName(message.FromHostName) : ContactsManager.getName(message.FromHostName))));
            if (message.IsFile)
                BeginInvoke((Action)(() => notificationThrowManager.CreateFileNotification(message, message.GroupId > 0 ? GroupsManager.GetGroupName(message.GroupId) + ":" + ContactsManager.getName(message.FromHostName) : ContactsManager.getName(message.FromHostName))));

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
        public static NotificationThrowManager notificationThrowManager = new NotificationThrowManager();
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
            if ((this.Contact != null || this.Group != null) && messageTB.Text != "")
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
            menuTabeControl.Size = new Size((int)((Width / 7)*2), menuTabeControl.Size.Height);
            chatPageTitleU.Height = Height / 13;
            chatPageTopP.Height = Height / 13;
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
            //Point point = contactListBtn.PointToScreen(new Point(0, 0));         
            contactListF.Location = new Point(point.X, point.Y + 60);
            contactListF.onClickContactGet += ContactListOnclickContactGet;
            contactListF.OnGroupCreatedInvoke += CreateGroupPageUOnClickGroupCreate;
            contactListF.OnclickClose += transparentForm.TransparentFormClick;
            //contactListU.Location = Cursor.Position;
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
                chatContactsPanel.Controls.Add(contactU);

            contactU.OnclickGetContact += ContactUOnClickContactOrGroupGet;
            return contactU;
        }

        private bool GroupExistsInChat(Group group)
        {
            return ContactUDictionary.ContainsKey(group.GroupID + ""); 
        }

        private ContactU ContactUCreateContact(Contact contact)
        {
            ContactU contactU = new ContactU(contact) { Dock = DockStyle.Top };
            ContactUDictionary.Add(contact.HostName, contactU);
            contactU.LastMessage = MessagesManager.GetLastSentedMessage(contact.HostName, NetworkManager.PcHostName);
            if (contact.IsArchived)
                ArchivedContactsPanel.Controls.Add(contactU);
            else
                chatContactsPanel.Controls.Add(contactU);
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
            menuTabeControl.ItemSize = new Size(0, 1);
            MainTabControl.ItemSize = new Size(0, 1);

            //Load the Datas
            refreshBtnClicked(this, EventArgs.Empty);
            try
            {
                menuControl.ProFileImagePath = ContactsManager.PCContact.DpPicture;
            }
            catch
            {

            }
            MainTabControl.SelectedTab = defaultPage;

            // Queue start
            QueueMessageStartInvoke();

            //SetUp
            ChatPageColor = SettingManager.ChatPageBackGroundColor;
        }

        //menu 
        private void ChangeTabStartedMessagePage(object sender, EventArgs e)
        {

            menuTabeControl.SelectedTab = starredMessagePage;
            MainTabControl.SelectedTab = defaultPage;
        }

        private void ChangeTabStatusPage(object sender, EventArgs e)
        {
            menuTabeControl.SelectedTab = StatusPage;
            MainTabControl.SelectedTab = defaultPage;
        }

        private void ChangeTabChatsPage(object sender, EventArgs e)
        {
            menuTabeControl.SelectedTab = ChatPage;
            if (contactUObject!=null)
            {
              
                if (chatPageTitleU.IsArchived)
                    MainTabControl.SelectedTab = defaultPage;
                else
                    MainTabControl.SelectedTab = chattabpage;
            }
        }

        private void ChangeTabCallsPage(object sender, EventArgs e)
        {
            menuTabeControl.SelectedTab = callsPage;
            MainTabControl.SelectedTab = defaultPage;
        }

        private void ChangeTabarchivedPage(object sender, EventArgs e)
        {
            menuTabeControl.SelectedTab = archivedPage;
            if (contactUObject != null)
            {
                if (!chatPageTitleU.IsArchived)
                    MainTabControl.SelectedTab = defaultPage;
                else
                    MainTabControl.SelectedTab = chattabpage;
            }
        }
        private void menuControlOnClickProfilePicture(object sender, EventArgs e)
        {
            SettingF settingF = new SettingF();
            settingF.IsProfilePageSelected = true;
            SettingFormShow(settingF);
        }

        private void menuControlOnClickSettingBtn(object sender, EventArgs e)
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
            for (int i = 0; i < ContactsManager.MessagedContacts_list.Count; i++)
            {
                ContactUCreateContact(ContactsManager.getContact(ContactsManager.MessagedContacts_list[i].HostName));
            }
        }
    
        public void GroupsRefresh()
        {
            for (int i = 0; i < GroupsManager.Groups_List.Count; i++)
            {
                if (!GroupExistsInChat(GroupsManager.Groups_List[i]))
                    ContactUCreateGroup(GroupsManager.Groups_List[i]);
            }
        }
        public void AlreadyExitsGroupsCreate()
        {
            for (int i = 0; i < GroupsManager.Groups_List.Count; i++)
            {
                ContactUCreateGroup(GroupsManager.Groups_List[i]);
            }
        }
        private void messageTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainSearchBoxPanelResize(object sender, EventArgs e)
        {

            contactUSearchBox.Width = (mainSearchBoxPanel.Width / 4) * 3;
            contactUSearchBox.Location = new Point(mainSearchBoxPanel.Width / 2 - contactUSearchBox.Width / 2, mainSearchBoxPanel.Height / 2 - contactUSearchBox.Height / 2);
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
        private void MessageShowP_MouseWheel(object sender, MouseEventArgs e)
        {
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
           
            IsMessageSelectedOn = false;
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
            MainTabControl.SelectedTab = defaultPage;
            IsMessageSelectedOn = false;
             Contact = null;
            Group = null;
        }

        private void ChatPanelUnSelectedChatUPanelInvoke(object sender, EventArgs e)
        {
            SelectedMessagesChatU.Remove((ChatUPanel)(sender));
            if (SelectedMessagesChatU.Count == 0)
            {
                IsMessageSelectedOn = false;
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
                        notificationThrowManager.CreateNotification("File not Found", NotificationType.None);
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
                IsMessageSelectedOn = true;
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
                messageTB.TabIndex = 0;
            }
          
        }
        private void FileSendInvoke()
        {
            string filename = Path.GetFileName(attachMentFilePath);
            attachMentFilePath = attachMentFilePath.Replace("\\", "\\\\\\\\");
            MessageConfirmForm confirmForm = new MessageConfirmForm("Do you want to sent the \n" + filename);
            confirmForm.StartPosition = FormStartPosition.Manual;
            confirmForm.Location = new Point(Location.X + (Width / 2) - confirmForm.Width / 2, Location.Y + (Height / 2) - confirmForm.Height / 2);
            if (confirmForm.ShowDialog() == DialogResult.Yes)
            {
                string fileName = Path.GetFileName(attachMentFilePath);
                long fileSize = new FileInfo(attachMentFilePath).Length;

                Message fileMessage;
                if (!isGroup)
                {
                    fileMessage = new Message(0, NetworkManager.PcHostName, Contact.HostName, 0, DateTime.Now, fileName, false, true, @"" + attachMentFilePath);
                }
                else
                {
                    fileMessage = new Message(0, NetworkManager.PcHostName, "", Group.GroupID, DateTime.Now, fileName, false, true, @"" + attachMentFilePath);
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
                    NetworkManager.FileSent(fileMessage, attachMentFilePath, ContactsManager.ContactDictionary[fileMessage.ToHostName]);
                else
                   {
                   for(int i=0;i<Group.GroupMembers.Count;i++){
                            
                            NetworkManager.FileSent(fileMessage, attachMentFilePath, ContactsManager.ContactDictionary[Group.GroupMembers[i].Contact.HostName]);
                        }
                   }
                    fileMessage.IsSent = true;
                    MessagesManager.UpdateIsSent(fileMessage);
                    BeginInvoke((Action)(() => { messageChatU.IsSent = true; }));
                }
                catch
                {
                    notificationThrowManager.CreateNotification("Receiver not respond to send File", NotificationType.Information);
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
                    attachMentFilePath = saveFileDialog.FileName;
                    Thread tread = new Thread(new ThreadStart(FileSendInvoke));
                    tread.Start();
                }
            }

        }
        private void ThemeSetUp(object sender, EventArgs e)
        {
            contactUSearchBox.BorderColor = SettingManager.PrimaryThemeColor;
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

        private void ellipseButton1_Click(object sender, EventArgs e)
        {

        }

        private void refreshBtnClicked(object sender, EventArgs e)
        {
           
            menuControl.ImageDispose();
            chatPageTitleU.ImageDispose();
         //  NetworkManager.NetworkStreamClientDictionary.Clear();
         //foreach()
            foreach (var contactU in ContactUDictionary){
                ((ContactU)contactU.Value).Dispose();
            }
            ContactUDictionary.Clear();
            ContactsManager.ContactManagerSetup();
            GroupsManager.GroupsManagerSetUp();
            AlreadyExitsMessagedContactsCreate();
            AlreadyExitsGroupsCreate();
            MainTabControl.SelectedTab = defaultPage;
        }

       
    }
}