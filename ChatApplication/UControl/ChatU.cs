using ChatApplication.Manager;

using ChatApplication.UForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ChatApplication
{

    public partial class ChatU : UserControl
    {
        public event EventHandler<Message> OnClickMessageGet;
        public event EventHandler<int> ChatUResizedInvoke;
        public event MouseEventHandler ChatUMouseClick;
        public event EventHandler ChatUMouseEnterInvoke;
        public event EventHandler ChatUMouseLeaveInvoke;
        private int borderRadius = 7;
        private int ScaleOfIncreaseHeight = 714;
        private bool isReceivedMessage = false;
        private bool isSent = false;
        private int chatArcWidth = 10;
        private bool isNormal;
        private bool isViewed;
        private bool isFile;
        private Message message;
        private int chatUMaximumWidth = 400;
        private float totalHeight;
        public Message Message
        {
            set
            {
                if (value != null)
                {
                    message = value;
                    timingLB.Text = value.DateAndTime.ToString("hh:mm tt");
                    IsFile = message.IsFile;
                    IsSent = value.IsSent;
                    if (Message.GroupId > 0 && Message.FromHostName != NetworkManager.PcHostName)
                    {
                        nameLB.Text = ContactsManager.getName(message.FromHostName);
                        nameLB.ForeColor = FeaturesMethods.GetNamePColor(nameLB.Text);
                        nameLBP.Visible = true;
                    }
                    if (Message.FromHostName == NetworkManager.PcHostName)
                    {
                        IsReceivedMessage = false;
                    }
                    else
                    {
                        IsReceivedMessage = true;
                    }
                }
            }
            get
            {
                return message;
            }
        }
        public bool IsFile
        {
            get
            {
                return isFile;
            }
            set
            {
                isFile = value;
                if (isFile)
                {
                    BackColor = ColorTranslator.FromHtml("#FFD767");
                    messageLB.ForeColor = Color.Black;
                    nameLB.ForeColor = Color.Black;
                    timingLB.ForeColor = Color.Black;
                    nameLBP.Visible = true;
                    nameLB.Text = "File";
                }
            }
        }
        public bool isShowMoreVisible
        {
            set
            {
                showMorePanel.Visible = value;
                if (showMorePanel.Visible)
                {
                    bottomDetailsPanel.Height = showMorePanel.Height + timeAndStatusPanel.Height;
                    //bottomDetailsPanel.MinimumSize = new Size(0, showMorePanel.Height + timeAndStatusPanel.Height);
                }
                else
                {
                    bottomDetailsPanel.Height = timeAndStatusPanel.Height;
                    //bottomDetailsPanel.MinimumSize = new Size(0, timeAndStatusPanel.Height);
                }
            }
            get
            {
                return showMorePanel.Visible;
            }
        }
        public bool IsViewed
        {
            get
            {
                return isViewed;
            }
            set
            {
                isViewed = value;
                if (value == true)
                {
                    MessageSendIconPB.Image = Properties.Resources.double_check__1_;
                }
            }
        }

        public bool IsNormal
        {
            get
            {
                return isNormal;
            }
            set
            {
                isNormal = value;
                Invalidate();
            }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }
        public int ChatUMaximumWidth
        {
            get
            {
                return chatUMaximumWidth;
            }
            set
            {
                chatUMaximumWidth = value;
                ChatCreate();
            }
        }

        public bool IsReceivedMessage
        {
            get
            {
                return isReceivedMessage;
            }
            set
            {
                isReceivedMessage = value;
                if (value == true)
                {
                    if (!isFile)
                    {
                        BackColor = Color.White;
                        messageLB.ForeColor = Color.Black;
                        timingLB.ForeColor = Color.Black;
                    }
                    MessageSendIconPB.Visible = false;
                }

                Invalidate();
            }
        }
        public bool IsSent
        {
            get
            {
                return isSent;
            }
            set
            {
                isSent = value;
                if (value == true && MessageSendIconPB.Visible == true)
                {
                    if ((SettingManager.FontThemeColor == Color.Black || SettingManager.FontThemeColor == ColorTranslator.FromHtml("#5A5A5E")) || isFile)
                        MessageSendIconPB.Image = Properties.Resources.read;
                    else
                        MessageSendIconPB.Image = Properties.Resources.WhiteDoubleTick;
                }
                else
                {
                    if ((SettingManager.FontThemeColor == Color.Black || SettingManager.FontThemeColor == ColorTranslator.FromHtml("#5A5A5E")) || isFile)
                        MessageSendIconPB.Image = Properties.Resources.icons8_done_14__1_;
                    else
                        MessageSendIconPB.Image = Properties.Resources.WhiteSingleTick;

                }
                Invalidate();
            }
        }
        public int ChatArcWidth
        {
            get
            {
                return chatArcWidth;
            }
            set
            {
                chatArcWidth = value;
                Invalidate();
            }
        }

        public ChatU()
        {
            InitializeComponent();

        }

        public ChatU(Message message)
        {
            InitializeComponent();
            BackColor = SettingManager.SecontroyThemeColor;
            messageLB.ForeColor = SettingManager.FontThemeColor;
            timingLB.ForeColor = SettingManager.FontThemeColor;
            SettingManager.ThemeSetUpInvoke += ThemeSetUp;
            Disposed += ChatUDisposed;
            Message = message;
        }

        private void ChatUDisposed(object sender, EventArgs e)
        {
            MessageSendIconPB.Image.Dispose();
            messageLB.Dispose();
        }

        public GraphicsPath GetPath(Rectangle rec)
        {
            GraphicsPath g = new GraphicsPath();
            g.StartFigure();
            if (isNormal)
            {
                chatArcWidth = 0;
            }
            else
            {

            }
            if (isReceivedMessage)
            {

                if (!isNormal)
                {
                    g.AddPolygon(new Point[] { new Point(chatArcWidth + 3, 0), new Point(0, 0), new Point(chatArcWidth + 4, chatArcWidth) });
                }
                g.AddArc(new Rectangle(chatArcWidth, rec.Y, borderRadius, borderRadius), 180, 90);

                g.AddArc(rec.Width - borderRadius, rec.Y, borderRadius, borderRadius, 270, 90);
                g.AddArc(rec.Width - borderRadius, rec.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                g.AddArc(rec.X + chatArcWidth, rec.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            }
            else
            {
                g.AddArc(rec.X, rec.Y, borderRadius, borderRadius, 180, 90);
                g.AddArc(new Rectangle(rec.Width - borderRadius - chatArcWidth, rec.Y, borderRadius, borderRadius), 270, 90);
                g.AddArc(rec.Width - borderRadius - chatArcWidth, rec.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                g.AddArc(rec.X, rec.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                if (!isNormal)
                    g.AddPolygon(new Point[] { new Point(rec.Width - chatArcWidth - 3, 0), new Point(rec.Width, 0), new Point(rec.Width - chatArcWidth, chatArcWidth) });
            }
            g.CloseFigure();
            return g;
        }
        float maximumWidthinString = 0;
        public void StringFormatChange(string str, int width, Font font)
        {
            string formatedstring = "";
            this.Width = width;
            Graphics g = CreateGraphics();
            string singleLineContent = "";
            string[] s = str.Split(new string[] { "\n" }, StringSplitOptions.None);
            float normalStringLineHeight = (float)((g.MeasureString(s[0], font).Height));
            foreach (string Iter in s)
            {
                float stringSingleLineWidth = g.MeasureString(Iter + "", font).Width;
                if (maximumWidthinString < stringSingleLineWidth)
                {
                    maximumWidthinString = stringSingleLineWidth;
                }
                if (g.MeasureString(Iter + "", font).Width <= width)
                {
                    totalHeight += (int)normalStringLineHeight;
                }
                else
                {
                    double i = Math.Ceiling(g.MeasureString(Iter + "", font).Width / width);
                    totalHeight += (float)(normalStringLineHeight * Math.Ceiling(g.MeasureString(Iter + "", font).Width / width));
                }
            }
            totalHeight = totalHeight - (((float)(1.0 / 30.0)) * totalHeight);

        }
        public void ChatCreate()
        {
            string str = "";
            var g = CreateGraphics();
            if (Message.MessageText != "")
            {
                StringFormatChange(Message.MessageText, chatUMaximumWidth, messageLB.Font);
            }
            messageLB.Text = message.MessageText;
            if (Width > maximumWidthinString)
            {
                if (maximumWidthinString < chatUMaximumWidth)
                    Width = (int)maximumWidthinString + 14;
                else
                    Width = chatUMaximumWidth + 14;
            }
            if (ScaleOfIncreaseHeight >= totalHeight)
            {
                messageLBPanel.Height = (int)totalHeight;
                isShowMoreVisible = false;
                Height = messageLBPanel.Height + (nameLBP.Visible ? nameLBP.Height : 0) + bottomDetailsPanel.Height;
            }
            else
            {
                messageLBPanel.Height = ScaleOfIncreaseHeight;
                isShowMoreVisible = true;
                Height = messageLBPanel.Height + (nameLBP.Visible ? nameLBP.Height : 0) + bottomDetailsPanel.Height;

            }
            nameLB.Width = (int)g.MeasureString(nameLB.Text, nameLB.Font).Width;
            if (nameLBP.Visible == true)
            {
                if (nameLB.Width > Width)
                    Width = nameLB.Width;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var path = GetPath(ClientRectangle);
            this.Region = new Region(path);
        }

        private void ChatU_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && !MainForm.IsMessageSelectionOn)
            {
                OnClickMessageGet?.Invoke(this, Message);
            }
            if (MainForm.IsMessageSelectionOn)
                ChatUMouseClick?.Invoke(this, e);
        }
        private void ThemeSetUp(object sender, EventArgs e)
        {
            if (!isReceivedMessage && !isFile)
            {

                BackColor = SettingManager.SecontroyThemeColor;
                messageLB.ForeColor = SettingManager.FontThemeColor;
                timingLB.ForeColor = SettingManager.FontThemeColor;
                IsSent = IsSent;
            }
        }

        private void showMoreLabelClick(object sender, EventArgs e)
        {
            if ((messageLBPanel.Height + ScaleOfIncreaseHeight) < totalHeight)
            {
                messageLBPanel.Height += ScaleOfIncreaseHeight;
                ScaleOfIncreaseHeight = ScaleOfIncreaseHeight + 714;
                isShowMoreVisible = true;
            }
            else
            {
                messageLBPanel.Height = (int)totalHeight;
                isShowMoreVisible = false;
            }
            int chatHeight;
            if (isReceivedMessage)
            {
                chatHeight = messageLBPanel.Height + 35 + 15;
            }
            else
                chatHeight = messageLBPanel.Height + 35;
            ChatUResizedInvoke?.Invoke(this, chatHeight);
            Height = chatHeight;

            Invalidate();

        }
        public void ChatPanelResize(object sender, int width)
        {
            ChatUMaximumWidth = width;
            bool isfullread = false;
            if (messageLBPanel.Height == totalHeight)
            {
                isfullread = true;
            }
            else
            {
                isfullread = false;
            }

            totalHeight = 0;

            maximumWidthinString = 0;
            ChatCreate();
            if (isfullread)
                messageLBPanel.Height = (int)totalHeight;
            int chatHeight;
            if (isReceivedMessage)
            {
                chatHeight = messageLBPanel.Height + (nameLBP.Visible ? nameLBP.Height : 0) + bottomDetailsPanel.Height + 3;
            }
            else
                chatHeight = messageLBPanel.Height + (nameLBP.Visible ? nameLBP.Height : 0) + bottomDetailsPanel.Height + 2;
            ChatUResizedInvoke?.Invoke(this, chatHeight);
            Height = chatHeight;
            Invalidate();
        }
        private void ChatUMouseEnter(object sender, EventArgs e)
        {
            ChatUMouseEnterInvoke?.Invoke(this, EventArgs.Empty);
        }

        private void ChatUMouseLeave(object sender, EventArgs e)
        {
            ChatUMouseLeaveInvoke?.Invoke(this, EventArgs.Empty);
        }
    }
}
