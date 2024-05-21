using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication.UControl
{
    public class ChatUPanel : Panel
    {

        public event EventHandler SelectedChatUPanelInvoke;
        public event EventHandler UnSelectedChatUPanelInvoke;
        public event EventHandler<int> ChatPanelResizeInvoke;
        public event MouseEventHandler OnclickChatUPanel;
        private bool isSelected;
        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                isSelected = value;
                if (isSelected)
                {
                    BackColor = MessageSelectedColor;
                }
                else
                    BackColor = Color.Transparent;
            }
        }
        public ChatU ChatU;
        public Color MessageSelectedColor = Color.FromArgb(207, 227, 251);
        public ChatUPanel(ChatU chatU)
        {
            ChatU = chatU;
            if (chatU.IsReceivedMessage)
            {
                chatU.Dock = DockStyle.Left;
            }
            else
            {
                chatU.Dock = DockStyle.Right;
            }
            ChatPanelResizeInvoke += chatU.ChatPanelResize;
            Resize += ChatUPanelResize;
            chatU.ChatUMouseClick += ChatUPanelClick;
            MouseClick += ChatUPanelClick;
            Height = chatU.Height + 10;
            Padding = new Padding(10, 5, 15, 5);
            chatU.ChatUResizedInvoke += ChatUResize;
            chatU.ChatUMouseEnterInvoke += ChatUPanelMouseEnter;
            chatU.ChatUMouseLeaveInvoke += ChatUPanelMouseLeave;
            MouseEnter += ChatUPanelMouseEnter;
            MouseLeave += ChatUPanelMouseLeave;
            Controls.Add(chatU);
            Dock = DockStyle.Top;
        }

        private void ChatUPanelResize(object sender, EventArgs e)
        {
            if (Math.Abs(ChatU.Width - (Width / 5) * 3) > 5)
            {
                ChatPanelResizeInvoke?.Invoke(this, (Width / 5) * 3);
            }
        }

        private void ChatUPanelMouseLeave(object sender, EventArgs e)
        {
            if (MainForm.IsMessageSelectionOn && !IsSelected)
            {
                BackColor = Color.Transparent;
            }

        }
        private void ChatUPanelMouseEnter(object sender, EventArgs e)
        {
            if (MainForm.IsMessageSelectionOn && !IsSelected)
            {
                BackColor = Color.FromArgb(240, 240, 240);
            }

        }

        private void ChatUResize(object sender, int height)
        {
            Height = height + 10;
        }

        private void ChatUPanelClick(object sender, MouseEventArgs e)
        {
            if (MainForm.IsMessageSelectionOn && e.Button == MouseButtons.Left)
            {
                if (IsSelected)
                    UnSelectedChatUPanelInvoke?.Invoke(this, EventArgs.Empty);
                IsSelected = !IsSelected;
                if (IsSelected)
                    SelectedChatUPanelInvoke?.Invoke(this, EventArgs.Empty);
            }
            if (MainForm.IsMessageSelectionOn)
                OnclickChatUPanel.Invoke(this, e);
        }
    }
}
