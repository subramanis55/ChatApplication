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
    public partial class ContactInformationF : Form
    {
        public TransparentForm transparentFormObj;
        public ContactInformationF(Contact contact)
        {

            InitializeComponent();
            KeyDown += FormKeyDown;
            KeyPreview = true;
            firstnameLB.Text = contact.FirstName;
            lastnameLB.Text = contact.LastName;
            hostNameLB.Text = contact.HostName;
            lastOnlineLB.Text = GetLastMessageDate(contact.LastOnlineTime);
            FeaturesMethods.AltTabFormShowStop(this.Handle);
        }
        private string GetLastMessageDate(DateTime dateTime)
        {
            if (dateTime.Day == DateTime.Now.Day && dateTime.Month == DateTime.Now.Month && dateTime.Year == DateTime.Now.Year)
            {
                return dateTime.ToString("hh:mm tt");
            }
            else if (dateTime.Day == DateTime.Now.AddDays(-1).Day && dateTime.Month == DateTime.Now.AddDays(-1).Month && dateTime.Year == DateTime.Now.AddDays(-1).Year)
            {
                return "Yesterday";
            }
            else
            {
                return dateTime.ToString("dd-MM-yyyy");
            }
        }
        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers & Keys.Alt) == Keys.Alt)
            {
                if (transparentFormObj != null)
                {
                    transparentFormObj.Dispose();
                }
            }
        }
    }
}
