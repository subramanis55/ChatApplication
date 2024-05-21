using ChatApplication.Manager;

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
    public partial class ContactListF : Form
    {
        public TransparentForm transparentFormObj;
        public event EventHandler<Contact> onClickContactGet;
        public event EventHandler OnGroupCreatedInvoke;
        public event EventHandler OnclickClose;
        private int heightLimit = 400;
        List<Contact> contacts_List;
        private List<Contact> groupContacts;
        private Timer timer = new Timer();
        public int HeightLimit
        {
            set
            {
                heightLimit = value;
            }
            get
            {
                return heightLimit;
            }
        }

        public ContactListF(List<Contact> contacts_List)
        {
            InitializeComponent();

            KeyPreview = true;
            KeyDown += FormKeyDown;
            this.contacts_List = contacts_List;
            timer.Interval = 5;
            timer.Tick += VisibleChangeAnimation;
            AddContactListU();
            FeaturesMethods.AltTabFormShowStop(this.Handle);

        }

        private void AddContactListU()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Dispose();
            }
            ContactListU contactListU = new ContactListU() { Dock = DockStyle.Fill };
            Controls.Add(contactListU);
            contactListU.Contacts_List = contacts_List;
            contactListU.OnclickContactGet += ContactListOnclickContactGet;
            contactListU.OnClickNextGroupContactsGet += ContactListUOnClickNextGroupContactsGet;

        }
        private void ContactListUOnClickNextGroupContactsGet(object sender, List<Contact> groupContacts)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Dispose();
            }
            CreateGroupPageU createGroupPageU = new CreateGroupPageU() { Dock = DockStyle.Fill };
            createGroupPageU.OnClickGroupCreate += CreateGroupPageUOnClickGroupCreate;
            createGroupPageU.OnClickGroupCancel += CreateGroupPageUOnClickGroupCancel;
            Controls.Add(createGroupPageU);
            this.groupContacts = groupContacts;

        }

        private void CreateGroupPageUOnClickGroupCancel(object sender, EventArgs e)
        {

            AddContactListU();
        }

        private void CreateGroupPageUOnClickGroupCreate(object sender, Group group)
        {
            List<GroupMember> groupMembers = new List<GroupMember>();
            for (int i = 0; i < groupContacts.Count; i++)
            {
                groupMembers.Add(new GroupMember(DateTime.Now, groupContacts[i]));
            }
            group.GroupMembers = groupMembers;
            if (DatabaseManager.ChatApplicationServerConnection())
            {
                GroupsManager.CreateGroupInServerDatabase(group);
                GroupsManager.GroupsManagerSetUp();
                OnGroupCreatedInvoke?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                SettingManager.notificationThrowManager.CreateNotification("Server not Respond for create\n group", NotificationType.Information);
            }
            CreateGroupPageUOnClickGroupCancel(this, EventArgs.Empty);

        }

        private void ContactListOnclickContactGet(object sender, Contact contact)
        {
            onClickContactGet?.Invoke(this, contact);
            OnclickClose?.Invoke(this, EventArgs.Empty);
        }

        private void ContactListF_Shown(object sender, EventArgs e)
        {
            timer.Start();
        }


        private void VisibleChangeAnimation(object sender, EventArgs e)
        {
            if (Height < HeightLimit)
            {
                Height += 10;
            }
            else
            {
                timer.Stop();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {

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
