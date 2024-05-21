using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatApplication.Manager;

namespace ChatApplication
{
    public partial class ContactListU : UserControl
    {


        public event EventHandler<List<Contact>> OnClickNextGroupContactsGet;
        public event EventHandler<Contact> OnclickContactGet;

        private List<Contact> contacts_List;
        public List<Contact> Contacts_List
        {
            get
            {
                return contacts_List;
            }
            set
            {
                if (value != null)
                {
                    contacts_List = value;
                    AddContacts();
                }
            }
        }


        public ContactListU()
        {
            InitializeComponent();
            Disposed += ContactListUDisposed;
            //Theme setup
            groupCreateNextBtn.BackColor = SettingManager.PrimaryThemeColor;
            searchBox.BorderColor = SettingManager.PrimaryThemeColor;

            groupCreateNextBtn.Click += GroupCreateNextBtnClick;
            searchBox.Textchanged += SearchBoxTextchanged;
            cancelBtn.Click += CancelBtnClick;
            addGroupSimpleU.OnClickAddGroupSimpleU += AddGroupSimpleUOnClick;
        }

        private void ContactListUDisposed(object sender, EventArgs e)
        {
            for (int i = 0; i < contactLoadP.Controls.Count; i++)
            {
                ((ContactSimpleU)(contactLoadP.Controls[i])).Dispose();
                contactLoadP.Controls.Remove((ContactSimpleU)(contactLoadP.Controls[i]));
                i--;
            }
        }

        public ContactListU(List<Contact> _contacts_List)
        {
            InitializeComponent();
            contacts_List = _contacts_List;

            groupCreateNextBtn.Click += GroupCreateNextBtnClick;
            searchBox.Textchanged += SearchBoxTextchanged;

            cancelBtn.Click += CancelBtnClick;
            addGroupSimpleU.OnClickAddGroupSimpleU += AddGroupSimpleUOnClick;
            //add contacts details;
            AddContacts();
        }

        private void AddGroupSimpleUOnClick(object sender, EventArgs e)
        {
            groupCreateNextP.Visible = !groupCreateNextP.Visible;
            for (int i = 0; i < contactLoadP.Controls.Count; i++)
            {
                ((ContactSimpleU)contactLoadP.Controls[i]).IsCheckBoxVisible = !((ContactSimpleU)contactLoadP.Controls[i]).IsCheckBoxVisible;
                if (((ContactSimpleU)contactLoadP.Controls[i]).Contact.HostName == NetworkManager.PcHostName)
                {
                    if (groupCreateNextP.Visible)
                    {
                        ((ContactSimpleU)contactLoadP.Controls[i]).IsSelected = true;

                        ((ContactSimpleU)contactLoadP.Controls[i]).Visible = false;
                        ((ContactSimpleU)contactLoadP.Controls[i]).IsCheckBoxVisible = true;
                    }
                    else
                    {
                        ((ContactSimpleU)contactLoadP.Controls[i]).Visible = true;
                        ((ContactSimpleU)contactLoadP.Controls[i]).IsCheckBoxVisible = false;
                    }


                }
            }
            if (groupCreateNextP.Visible)
            {
                headingLB.Text = "Create Group";
                addGroupSimpleU.Visible = false;
            }
            else
            {
                headingLB.Text = "New Chat";
                addGroupSimpleU.Visible = true;
            }
        }

        private void CancelBtnClick(object sender, EventArgs e)
        {
            AddGroupSimpleUOnClick(this, EventArgs.Empty);
        }

        private void GroupCreateNextBtnClick(object sender, EventArgs e)
        {
            List<Contact> temp_Contacts_List = new List<Contact>();
            for (int i = 0; i < contactLoadP.Controls.Count; i++)
            {
                if (((ContactSimpleU)contactLoadP.Controls[i]).IsSelected)
                {
                    temp_Contacts_List.Add(((ContactSimpleU)contactLoadP.Controls[i]).Contact);
                }
            }
            if (temp_Contacts_List.Count > 0)
                OnClickNextGroupContactsGet(this, temp_Contacts_List);
        }


        private void SearchBoxTextchanged(object sender, EventArgs e)
        {
            contactLoadP.SuspendLayout();

            if (!searchBox.IsPlaceholder && searchBox.Text != searchBox.PlaceholderText)
            {
                if (!string.IsNullOrWhiteSpace(searchBox.Text))
                {
                    string searchText = searchBox.Text.Trim();
                    for (int i = 0; i < contactLoadP.Controls.Count; i++)
                    {
                        ContactSimpleU contactU = contactLoadP.Controls[i] as ContactSimpleU;
                        if (contactU != null && contactU.Contact.FirstName.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) == 0)
                        {
                            contactU.SendToBack();
                        }
                    }
                }
            }
            contactLoadP.ResumeLayout();
        }

        private void AddContacts()
        {
            try
            {
                for (int i = 0; i < contacts_List.Count; i++)
                {
                    ContactSimpleU contactSimpleU = new ContactSimpleU(contacts_List[i]) { Dock = DockStyle.Top };
                    contactSimpleU.OnClickContactSimpleU += ContactGet;
                    contactLoadP.Controls.Add(contactSimpleU);
                }
            }
            catch
            {

            }

        }

        private void ContactGet(object sender, Contact contact)
        {

            if (addGroupSimpleU.Visible)
            {
                OnclickContactGet.Invoke(this, contact);
            }
        }

    }
}
