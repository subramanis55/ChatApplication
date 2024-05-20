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
  
    public partial class CreateGroupPageU : UserControl
    {
        public event EventHandler OnClickGroupCancel;
        public string dpPicturePath="";
        public event EventHandler<Group> OnClickGroupCreate;           

        private void pPictureUOnClickDpPicturePathGet(object sender, string DpPicturePath)
        {
            dpPicturePath = DpPicturePath;
        }

        public CreateGroupPageU()
        {
            InitializeComponent();
            // ThemeSetup
            CreateBtn.BackColor = SettingManager.PrimaryThemeColor;
            groupNameTB.BorderColor= SettingManager.PrimaryThemeColor;

            dpPictureU.OnClickDpPicturePathGet += pPictureUOnClickDpPicturePathGet;         
            CreateBtn.Click += GroupCreateBtnClick;
            cancelBtn.Click += CancelBtnClick;
            groupNameTB.Textchanged += GroupNameTBTextchanged;
            Dock = DockStyle.Fill;
        }

        private void GroupNameTBTextchanged(object sender, EventArgs e)
        {
            if (groupNameTB.Text.Length > 16)
            {
                groupnameErrorLB.Visible = true;
                groupnameErrorLB.Text = "Groupname should be less than  16\n character";
            }
            else if(groupNameTB.Text.Length ==0)
            {
                groupnameErrorLB.Visible = true;
                groupnameErrorLB.Text = "Enter the groupname";
            }
            else
            {
                groupnameErrorLB.Visible = false;
            }
        }

        private void CancelBtnClick(object sender, EventArgs e)
        {
            OnClickGroupCancel?.Invoke(this,EventArgs.Empty);
        }

        private void GroupCreateBtnClick(object sender, EventArgs e)
        {   
        if(!groupnameErrorLB.Visible&& groupNameTB.Text.Length >0)
            {
                Group group = new Group() { GroupName = groupNameTB.Text, DpPicture =FilesManager.ConvertImageToBase64(dpPicturePath)  ,AdminHostName=NetworkManager.PcHostName,CreatedDateAndTime=DateTime.Now};
                OnClickGroupCreate?.Invoke(this, group);
            }
            if (groupNameTB.Text.Length == 0)
            {
                groupnameErrorLB.Visible = true;
                groupnameErrorLB.Text = "Enter the groupname";
            }
        }
       
    }
}
