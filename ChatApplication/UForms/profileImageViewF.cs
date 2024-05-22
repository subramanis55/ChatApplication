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

    public partial class profileImageViewF : Form
    {
        public TransparentForm2 TransparentFormObj;
        private bool isGroup = false;
        private Group group;
        private string dpPicturePath;
        public Group Group
        {
            set
            {
                if (value != null)
                {
                    group = value;
                    DpPicturePath = value.DpPicture;

                }
            }
            get
            {
                return group;
            }
        }

        private Contact contact;
        public Contact Contact
        {
            set
            {
                if (value != null)
                {
                    contact = value;
                    DpPicturePath = value.DpPicture;
                }
            }
            get
            {
                return contact;
            }
        }
        public string DpPicturePath
        {
            set
            {
                if (profilePB.Image != null)
                    profilePB.Image.Dispose();
                dpPicturePath = value;
                try
                {
                    if (dpPicturePath != "File Not Found")
                    {
                        profilePB.Image = Image.FromFile(dpPicturePath);
                    }
                    else
                        profilePB.Image = Properties.Resources.profile_user;
                }
                catch
                {
                    profilePB.Image = Properties.Resources.profile_user;
                }
            }
            get
            {
                return dpPicturePath;
            }
        }

        public profileImageViewF()
        {
            InitializeComponent();
            KeyPreview = true;
            FormClosed += ProfileImageViewFFormClosed;
            KeyDown += FormKeyDown;
            Disposed += ProfileImageViewFDisposed;
            bottomP.BackColor = SettingManager.PrimaryThemeColor;
            informationBtn.Click += InformationBtnClick;
            FeaturesMethods.AltTabFormShowStop(this.Handle);
        }

        private void ProfileImageViewFFormClosed(object sender, FormClosedEventArgs e)
        {
            if (TransparentFormObj != null)
                TransparentFormObj.Dispose();
            if (profilePB.Image != null)
                profilePB.Image.Dispose();
        }

        private void ProfileImageViewFDisposed(object sender, EventArgs e)
        {
            if (profilePB.Image != null)
                profilePB.Image.Dispose();
        }

        private void InformationBtnClick(object sender, EventArgs e)
        {
            TransparentForm transparentForm = new TransparentForm();
            if (isGroup)
            {
                GroupInformationF groupInformationF = new GroupInformationF(group);
                transparentForm.Control = groupInformationF;
                groupInformationF.transparentFormObj = transparentForm;
                groupInformationF.Location = new Point(Location.X + (Width / 2) - groupInformationF.Width / 2, Location.Y + (Height / 2) - groupInformationF.Height / 2);
                transparentForm.Show();
                groupInformationF.Show();
            }
            else
            {
                ContactInformationF contactInformationF = new ContactInformationF(Contact);
                transparentForm.Control = contactInformationF;
                contactInformationF.transparentFormObj = transparentForm;
                contactInformationF.Location = new Point(Location.X + (Width / 2) - contactInformationF.Width / 2, Location.Y + (Height / 2) - contactInformationF.Height / 2);
                transparentForm.Show();
                contactInformationF.Show();
            }
        }
        OpenFileDialog OpenFileDialog = new OpenFileDialog();
        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers & Keys.Alt) == Keys.Alt)
            {
                if (TransparentFormObj != null)
                    TransparentFormObj.Dispose();
            }
        }

        private void closeBtnClick(object sender, EventArgs e)
        {          
            Close();
           
        }
    }
}
