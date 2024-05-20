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

namespace ChatApplication.UControl
{
    public partial class SettingMenuControl : UserControl
    {
        List<HoverButton> buttonArray;
        private HoverButton currentObject;
        private Color HoverColor = Color.FromArgb(234, 234, 234);
        public event EventHandler OnClickPersonalizationBtn;
        public event EventHandler OnClickAccountBtn;
        public event EventHandler OnClickAboutBtn;
        public event EventHandler OnClickProfileBtn;
        public event EventHandler OnClickThemeBtn;
        public bool IsProfileBtnSelected{
        set{
              if(value==true){
                    profileBtn.IsSelected = true;
                    ButtonClick(profileBtn, EventArgs.Empty);
                    ProfileBtnClick(this, EventArgs.Empty);
              }
        }
        }
        public SettingMenuControl()
        {
            InitializeComponent();
            SettingManager.ThemeSetUpInvoke += ThemeSetUp;
            buttonArray = new List<HoverButton> { personalizationBtn, accountBtn, profileBtn, themeChangeBtn,aboutBtn, };         
            currentObject = personalizationBtn;
            for (int i = 0; i < buttonArray.Count; i++)
            {             
                buttonArray[i].Click += ButtonClick;
                buttonArray[i].ButtonSideHoverlineColor = SettingManager.PrimaryThemeColor;
            }
            personalizationBtn.Click += PersonalizationBtnClick;
            accountBtn.Click += AccountBtnClick;   
            aboutBtn.Click += AboutBtnClick;
            profileBtn.Click += ProfileBtnClick;
            themeChangeBtn.Click += ThemeChangeBtnClick;
        }

        private void ThemeChangeBtnClick(object sender, EventArgs e)
        {
            OnClickThemeBtn?.Invoke(this, EventArgs.Empty);
        }
        private void ProfileBtnClick(object sender, EventArgs e)
        {
            OnClickProfileBtn?.Invoke(this, EventArgs.Empty);
        }

        private void AboutBtnClick(object sender, EventArgs e)
        {
            OnClickAboutBtn?.Invoke(this, EventArgs.Empty);
        }

        private void AccountBtnClick(object sender, EventArgs e)
        {
            OnClickAccountBtn?.Invoke(this, EventArgs.Empty);
        }

        private void PersonalizationBtnClick(object sender, EventArgs e)
        {
            OnClickPersonalizationBtn?.Invoke(this,EventArgs.Empty);
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

        private void SettingMenuControl_Load(object sender, EventArgs e)
        {

        }
        public void ThemeSetUp(object sender, EventArgs e)
        {
            for (int i = 0; i < buttonArray.Count; i++)
            {

                buttonArray[i].ButtonSideHoverlineColor = SettingManager.PrimaryThemeColor;
            }
        }
    }
}
