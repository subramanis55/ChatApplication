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
        private HoverMessageForm messageFormobj = null;
        Timer timer = new Timer();
        public MenuControl()
        {
            InitializeComponent();
            buttonArray = new List<HoverButton> { ChatsBtn, CallsBtn, StatusBtn, StarBtn, ArchivedBtn, SettingBtn };
            messageFormobj = new HoverMessageForm();
            currentObject = ChatsBtn;
            for(int i=0;i< buttonArray.Count;i++){
                buttonArray[i].MouseEnter += HoverMessageShow;
                buttonArray[i].MouseLeave += HoverMessageLeave;
                buttonArray[i].Click += ButtonClick;
            }

            ChatsBtn.Click += ChatsBtnClick;
            CallsBtn.Click += CallsBtnClick;
            StatusBtn.Click += StatusBtnClick;
            StarBtn.Click += StarBtnClick;
            ArchivedBtn.Click += ArchivedBtnClick;
            SettingBtn.Click += SettingBtnClick;
            ProfilePictureBox.Click += ProfilePictureBoxClick;
            timer.Interval += 500;
            timer.Tick += messageFormobjShow;
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
            OnClickStarBtn?.Invoke(sender, EventArgs.Empty);
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
             ProfilePictureBox.BackColor = HoverColor;
        }

        private void DPPanelLeave(object sender, EventArgs e)
        {
            ProfilePictureBox.BackColor = Color.Transparent;

        }

        private void HoverMessageShow(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            if (obj == SettingBtn)
            {
                messageFormobj.MessageText = "Setting";
               
            }

            else if (obj == ArchivedBtn)
            {
                messageFormobj.MessageText = "Archived Chats";
              
            }

            else if (obj == StarBtn)
            {
                messageFormobj.MessageText = "Starred messages";     
            }
            else if (obj == ChatsBtn)
            {
                messageFormobj.MessageText = "Chats";
              
            }

            else if (obj == CallsBtn)
            {
                messageFormobj.MessageText = "Calls";
            
            }
            else if(obj == StatusBtn)
            {
                messageFormobj.MessageText = "Status";
               
            }
            messageFormobj.Location = PointToScreen(new Point(obj.Location.X + (obj.Width / 2) - (messageFormobj.Width / 2), obj.Location.Y - messageFormobj.Height-10));
            timer.Start();

        }
        public void messageFormobjShow(object sender, EventArgs e)
        {
            messageFormobj.Show();
            timer.Stop();
        }
        private void HoverMessageLeave(object sender, EventArgs e)
        {
            messageFormobj.Hide();
        }

        private void MenuControl_Load(object sender, EventArgs e)
        {

        }
       
    }
}
