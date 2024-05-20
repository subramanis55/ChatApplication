using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ChatApplication.Manager;


namespace ChatApplication
{
    public partial class NotificationForm : Form
    {
        Dictionary<NotificationType, Image> IconList = new Dictionary<NotificationType, Image>();
        static private int borderRadius = 1;
        private NotificationType notifyType=NotificationType.None;
        Timer timer = new Timer();
        public event EventHandler OnEnd;
        public event EventHandler<Message> OnClickFileNotification;
        public event EventHandler OnClickNotification;

        private Message message;
        public Color IncreasePanelColor
        {
            get
            {
                return IncreaseingP.BackColor;
            }
            set
            {
                IncreaseingP.BackColor = value;
                nameLB.ForeColor = value;
            }
        }
        public Color NotificationFormTopPanelColor
        {
            get
            {
                return NotificationFormTopP.BackColor;
            }
            set
            {
                NotificationFormTopP.BackColor = value;
            }
        }
        public string MessageText
        {
            set
            {

                messageLB.Text = value;
            }
            get
            {
                return messageLB.Text;
            }
        }
        public string NotificationTypeText
        {
            set
            {
                NotificationTypeLB.Text = value;
                MessageLBTextAlign();
            }
            get
            {
                return NotificationTypeLB.Text;
            }
        }
       static public int BorderRadius
        {
            set
            {
                if (value < 1)
                {
                    borderRadius = 1;
                }
                else
                {
                    borderRadius = value;
                }              
            }
            get
            {
                return borderRadius;
            }
        }
        public NotificationType NotifyType
        {
            get
            {
                return notifyType;
            }

            set
            {
                notifyType = value;

            }
        }

        public Message Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
               MessageText = message.MessageText;
              
            }
        }

        public NotificationForm()
        {
            InitializeComponent();
           
            CancelBtn.Click += CancelBtnOnClick;
        }
        public NotificationForm(string message, NotificationType type)
        {
            InitializeComponent();
            //Theme Setup
            NotificationFormTopP.BackColor = SettingManager.PrimaryThemeColor;
            IncreaseingP.BackColor = SettingManager.PrimaryThemeColor;
            nameLB.ForeColor = SettingManager.PrimaryThemeColor;
            CancelBtn.Click += CancelBtnOnClick;
            MessageText = message;
            NotifyType = type;
            FeaturesMethods.AltTabFormShowStop(this.Handle);
            //  MessageLBTextAlign();

        }
        public NotificationForm(Message message,string name, NotificationType type)
        {
            InitializeComponent();
            //Theme Setup
            NotificationFormTopP.BackColor = SettingManager.PrimaryThemeColor;
            IncreaseingP.BackColor = SettingManager.PrimaryThemeColor;
            nameLB.ForeColor= SettingManager.PrimaryThemeColor;
            nameLB.Text = name;
            CancelBtn.Click += CancelBtnOnClick;
            Message = message;
            NotifyType = type;
            FeaturesMethods.AltTabFormShowStop(this.Handle);
        }
      
        private void MessageLBTextAlign()
        {       
            var g = CreateGraphics();
            string str = StringFormatChange(MessageText, messageP.Width, messageLB.Font);
            messageLB.Text = str;
            SizeF a = g.MeasureString(messageLB.Text, messageLB.Font);
            messageLB.Size = new Size((int)a.Width + 3,(int) a.Height + 3);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            IconList.Add(NotificationType.Success, Properties.Resources.SuccessIcon);
            IconList.Add(NotificationType.Information, Properties.Resources.InformationIcon);
            IconList.Add(NotificationType.Error, Properties.Resources.ErrorIcon);
            IconList.Add(NotificationType.Warning, Properties.Resources.WarningIcon);
            IconList.Add(NotificationType.File, Properties.Resources.FileIcon);
            NotificationTypeSet();
            if (notifyType != NotificationType.File)
                timer.Interval = 20;
           else{
                timer.Interval = 120;
            }
            timer.Tick += IncreatePanelAnimation;
            timer.Start();
        }

        private void IncreatePanelAnimation(object sender, EventArgs args)
        {
            if (IncreaseingP.Width > Width)
            {
                if (this.Opacity > 0.01)
                    this.Opacity -= 0.02;
                else
                {
                    timer.Stop();
                    OnEnd?.Invoke(this, args);
                }
            }
            else
            {     if(notifyType!=NotificationType.File)
                IncreaseingP.Width = IncreaseingP.Width + 2;
                else{
                    IncreaseingP.Width = IncreaseingP.Width + 1;
                }    
            }
        } 
        public void NotificationTypeSet()
        {
            switch (notifyType)
            {
                case NotificationType.Success:
                    NotificationFormTopPanelColor = Color.FromArgb(105, 195, 59);
                    NotificationTypeText = "Success";
                    IncreaseingP.BackColor = Color.FromArgb(105, 195, 59);
                    IconPB.Image = IconList[NotificationType.Success];
                    break;
                case NotificationType.Error:
                    NotificationFormTopPanelColor = Color.FromArgb(255, 87, 57);
                    NotificationTypeText = "Error";
                    IncreasePanelColor = Color.FromArgb(255, 87, 57);
                    IconPB.Image = IconList[NotificationType.Error];
                    break;
                case NotificationType.Information:
                    NotificationFormTopPanelColor = Color.FromArgb(75, 155, 255);
                    NotificationTypeText = "Information";
                    IncreasePanelColor = Color.FromArgb(75, 155, 255);
                    IconPB.Image = IconList[NotificationType.Information];
                    break;
                case NotificationType.Warning:
                    NotificationFormTopPanelColor = Color.FromArgb(255, 204, 0);
                    NotificationTypeText = "Warning";
                    IncreasePanelColor = Color.FromArgb(255, 204, 0);
                    IconPB.Image = IconList[NotificationType.Warning];
                    break;
                case NotificationType.Message:
                    NotificationTypeText = "Message";
                    messageContactnameP.Visible = true;
                    IconP.Visible = false;
                    break;
                case NotificationType.File:
                    NotificationTypeText = "File";
                    NotificationFormTopPanelColor = Color.FromArgb(214, 146, 0);
                    messageContactnameP.Visible = true;
                    IconPB.Image = IconList[NotificationType.File];
                    IncreasePanelColor = Color.FromArgb(214, 146, 0);
                    break;
                default:
                    NotificationTypeText = "Status";
                    IconP.Visible = false;
                    break;
            }
        }
        public string StringFormatChange(string str, int width, Font font)
        {
            string formatedstring = "";
            Graphics g = CreateGraphics();
            string singleLineContent = "";
            string[] wordArray = str.Split(' ');
            foreach (string Iter in wordArray)
            {
                if (g.MeasureString(Iter, font).Width >= width)
                {
                    if (singleLineContent != "")
                    {
                        formatedstring += singleLineContent + "\n";
                    }
                    float y = g.MeasureString(Iter, font).Width;
                    int x = (int)(Iter.Length / (y / width));
                    formatedstring += Iter.Substring(0, x) + "\n";
                    singleLineContent = Iter.Substring(x) + " ";
                }
                else if (g.MeasureString(singleLineContent + Iter + " ", font).Width >= width)
                {
                    formatedstring += singleLineContent + "\n";
                    singleLineContent = Iter + " ";
                }
                else
                {
                    singleLineContent += Iter + " ";
                }
            }
            if (singleLineContent != "")
                formatedstring += singleLineContent;
            if (str.Length > 0)
                return  formatedstring;
            else
            {
                return formatedstring;
            }
        }
        private void CancelBtnOnClick(object sender, EventArgs args)
        {
            Control control = (Control)sender;
            OnEnd?.Invoke(this, args);
        }
        private void NotificationFormClick(object sender, EventArgs e)
        {
            if (message != null)
            {
                if (message.IsFile)
                    OnClickFileNotification?.Invoke(this, Message);
                else
                    OnClickNotification?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
