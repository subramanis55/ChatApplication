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

namespace ChatApplication
{
    public partial class MenuControl : UserControl
    {

        List<HoverButton> buttonArray;
        private HoverButton currentObject;
        private Color HoverColor = Color.FromArgb(234, 234, 234);
        public EventHandler OnClickChatsBtn;
        public EventHandler OnClickCallsBtn;
        public EventHandler OnClickStatusBtn;
        public EventHandler OnClickStarBtn;
        public EventHandler OnClickArchivedBtn;
        public EventHandler OnClickSettingBtn;
        public EventHandler OnClickProfilePicture;
        private MessageDateU messageFormobj = null;
        public bool ISSelectedChatsBtn
        {
            set
            {
                if (value)
                {
                    
                    ChatsBtn.SideLineEffectMouseClick(ChatsBtn, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
                    ButtonClick(ChatsBtn, EventArgs.Empty);
                    ChatsBtnClick(this, EventArgs.Empty);
                }
            }
        }
        public bool ISSelectedCallsBtn
        {
            set
            {
                if (value)
                {
                    CallsBtn.SideLineEffectMouseClick(CallsBtn, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
                    ButtonClick(CallsBtn, EventArgs.Empty);
                    CallsBtnClick(this, EventArgs.Empty);
                }
            }
        }
        public bool ISSelectedStatusBtn
        {
            set
            {
                if (value)
                {
                    StatusBtn.SideLineEffectMouseClick(StatusBtn, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
                    ButtonClick(StatusBtn, EventArgs.Empty);
                    StatusBtnClick(this, EventArgs.Empty);
                }
            }
        }
        public bool ISSelectedStarBtn
        {
            set
            {
                if (value)
                {
                    StarBtn.SideLineEffectMouseClick(StarBtn, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
                    ButtonClick(StarBtn, EventArgs.Empty);
                    StarBtnClick(this, EventArgs.Empty);
                }
            }
        }
        public bool ISSelectedArchivedBtn
        {
            set
            {
                if (value)
                {
                   
                    ArchivedBtn.SideLineEffectMouseClick(ArchivedBtn, new MouseEventArgs(MouseButtons.Left,0,0,0,0));
                    ButtonClick(ArchivedBtn, EventArgs.Empty);
                    ArchivedBtnClick(this, EventArgs.Empty);
                }
            }
        }
        public string ProfilePicturePath
        {
            set
            {
                if (profilePictureBox.Image != null)
                    profilePictureBox.Image.Dispose();
                try
                {
                    profilePictureBox.Image = Image.FromFile(value);
                }
                catch
                {
                    profilePictureBox.Image = Properties.Resources.profile_user;
                }
            }
        }
        Timer timer = new Timer();
        public MenuControl()
        {
            InitializeComponent();

            buttonArray = new List<HoverButton> { ChatsBtn, CallsBtn, StatusBtn, StarBtn, ArchivedBtn };
            messageFormobj = new MessageDateU();
            currentObject = ChatsBtn;
            for (int i = 0; i < buttonArray.Count; i++)
            {
                buttonArray[i].Click += ButtonClick;
                buttonArray[i].ButtonSideHoverlineColor = SettingManager.PrimaryThemeColor;
            }
            Resize += MenuControlResize;

            ChatsBtn.Click += ChatsBtnClick;
            CallsBtn.Click += CallsBtnClick;
            StatusBtn.Click += StatusBtnClick;
            StarBtn.Click += StarBtnClick;
            ArchivedBtn.Click += ArchivedBtnClick;
            SettingBtn.Click += SettingBtnClick;
            profilePictureBox.Click += ProfilePictureBoxClick;
            SettingManager.ThemeSetUpInvoke += ThemeSetUp;

        }

        private void MenuControlResize(object sender, EventArgs e)
        {
            //for(int i=0;i<Controls.Count;i++){
            //if(Controls[i] is HoverButton)
            //     Controls[i].Height = Height / 10;
            //}
        }

        private void ProfilePictureBoxClick(object sender, EventArgs e)
        {
            OnClickProfilePicture?.Invoke(sender, EventArgs.Empty);
        }

        private void SettingBtnClick(object sender, EventArgs e)
        {
            OnClickSettingBtn?.Invoke(sender, EventArgs.Empty);
        }

        private void ArchivedBtnClick(object sender, EventArgs e)
        {
            OnClickArchivedBtn?.Invoke(sender, EventArgs.Empty);
        }

        private void StarBtnClick(object sender, EventArgs e)
        {
            OnClickStarBtn?.Invoke(sender, EventArgs.Empty);
        }
        private void StatusBtnClick(object sender, EventArgs e)
        {
            OnClickStatusBtn?.Invoke(sender, EventArgs.Empty);
        }

        private void CallsBtnClick(object sender, EventArgs e)
        {
            OnClickCallsBtn?.Invoke(sender, EventArgs.Empty);
        }

        private void ChatsBtnClick(object sender, EventArgs e)
        {
            OnClickChatsBtn?.Invoke(sender, EventArgs.Empty);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (sender != currentObject)
            {
                HoverButton obj = (HoverButton)(sender);
                if (currentObject != null)
                {
                    if (buttonArray.IndexOf(obj) > buttonArray.IndexOf(currentObject))
                    {
                        currentObject.IsFormUp = false;
                        obj.IsFormUp = true;
                    }
                    else
                    {
                        currentObject.IsFormUp = true;
                        obj.IsFormUp = false;
                    }
                    currentObject.CallToLeaveSideLineEffect();
                }
                currentObject = obj;

            }
        }
        private void customPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DPPanelHover(object sender, EventArgs e)
        {
            profilePictureBox.BackColor = HoverColor;
        }

        private void DPPanelLeave(object sender, EventArgs e)
        {
            profilePictureBox.BackColor = Color.Transparent;

        }


        public void ThemeSetUp(object sender, EventArgs e)
        {
            for (int i = 0; i < buttonArray.Count; i++)
            {

                buttonArray[i].ButtonSideHoverlineColor = SettingManager.PrimaryThemeColor;
            }
        }
        public new void ImageDispose()
        {
            if (profilePictureBox.Image != null)
                profilePictureBox.Image.Dispose();
        }

    }
}
