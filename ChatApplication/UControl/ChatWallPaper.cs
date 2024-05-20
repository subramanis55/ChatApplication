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
    public partial class ChatWallPaper : UserControl
    {
        public event EventHandler<Color> OnHoverChatPageColorGet;
        public event EventHandler OnLeaveChatPageColorChange;
        public event EventHandler<Color> OnClickChatPageColorGetSelect;
        private ChatPageColor SelectedChatPageColor;
        private ChatPageColor PrevChatPageColor;
        public ChatWallPaper()
        {
            InitializeComponent();

            for(int i=0;i< colorsP.Controls.Count;i++){
                ((ChatPageColor)(colorsP.Controls[i])).PageBackGroundColorMouseEntered += ChatWallPaperPageBackGroundColorMouseEntered;
                ((ChatPageColor)(colorsP.Controls[i])).PageBackGroundColorMouseLeaved += ChatWallPaperPageBackGroundColorMouseLeaved;
                if(((ChatPageColor)(colorsP.Controls[i])).PageBackGroundColor==SettingManager.ChatPageBackGroundColor){
                    PrevChatPageColor = ((ChatPageColor)(colorsP.Controls[i]));
                    ((ChatPageColor)(colorsP.Controls[i])).IsSelected1 = true;
                }
            }
        }
        private void ChatWallPaperPageBackGroundColorMouseLeaved(object sender, EventArgs e)
        {
            OnLeaveChatPageColorChange?.Invoke(this, EventArgs.Empty);
        }

        private void ChatWallPaperPageBackGroundColorMouseEntered(object sender, EventArgs e)
        {
            OnHoverChatPageColorGet?.Invoke(this,((ChatPageColor)(sender)).PageBackGroundColor);
        }

        private void ChatWallPaperClicked(object sender,EventArgs e)
        {
            if (PrevChatPageColor != null)
            {
                PrevChatPageColor.IsSelected1 = false;
            }
            SelectedChatPageColor = (ChatPageColor)sender;
            SelectedChatPageColor.IsSelected1 = true;
            PrevChatPageColor = SelectedChatPageColor;
            OnClickChatPageColorGetSelect?.Invoke(this, SelectedChatPageColor.PageBackGroundColor);
        }

        private void chatPageColorMouseEnter(object sender, EventArgs e)
        {

        }
    }
}
