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
    public partial class GroupInformationF : Form
    {
        public TransparentForm transparentFormObj;
        public GroupInformationF(Group group)
        {
            InitializeComponent();

            KeyPreview = true;
            KeyDown += FormKeyDown;
            FeaturesMethods.AltTabFormShowStop(this.Handle);
            groupnameLB.Text = group.GroupName;
            adminnameLB.Text = ContactsManager.getName(group.AdminHostName);
            numberOfMembersLB.Text = ""+group.GroupMembers.Count;
            createdDateAndTimeLabel.Text = group.CreatedDateAndTime.ToString("dd-MM-yyyy hh:mm tt");
            adminHostNameLabel.Text = group.AdminHostName;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers & Keys.Alt) == Keys.Alt)
            {   if (transparentFormObj!=null)
                transparentFormObj.Dispose();
            }
        }
    }
}
