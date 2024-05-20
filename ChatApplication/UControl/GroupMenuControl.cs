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

namespace ChatApplication.UControl
{
    public partial class GroupMenuControl : UserControl
    {
        List<HoverButton> buttonArray;
        private HoverButton currentObject;
        private Color HoverColor = Color.FromArgb(234, 234, 234);
        public event EventHandler OnClickOverviewBtn;
        public event EventHandler OnClickMemberBtn;
      
  
        public GroupMenuControl()
        {
            InitializeComponent();
            SettingManager.ThemeSetUpInvoke += ThemeSetUp;
            buttonArray = new List<HoverButton> { overviewBtn, memberBtn};
            currentObject = overviewBtn;
            for (int i = 0; i < buttonArray.Count; i++)
            {
                buttonArray[i].Click += ButtonClick;
                buttonArray[i].ButtonSideHoverlineColor = SettingManager.PrimaryThemeColor;
            }
            overviewBtn.Click += OverviewBtnClick;
            memberBtn.Click += MemberBtnClick;
        }
      
       
        private void MemberBtnClick(object sender, EventArgs e)
        {
            OnClickMemberBtn?.Invoke(this, EventArgs.Empty);
        }

        private void OverviewBtnClick(object sender, EventArgs e)
        {
            OnClickOverviewBtn?.Invoke(this, EventArgs.Empty);
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
        public void ThemeSetUp(object sender, EventArgs e)
        {
            for (int i = 0; i < buttonArray.Count; i++)
            {

                buttonArray[i].ButtonSideHoverlineColor = SettingManager.PrimaryThemeColor;
            }
        }
    }
}
