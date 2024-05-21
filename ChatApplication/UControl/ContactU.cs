using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using ChatApplication.Manager;

namespace ChatApplication
{
    public partial class ContactU : UserControl
    {
        public event EventHandler<object> OnclickGetContact;
        public event EventHandler OnclickDppicture;
        private Message lastMessage;
        private int newMessageCount = 0;
        private bool isArchived = false;
        private Contact contact;
        private bool isOnline;
        private Group group;
        private DateTime lastMessageTime;
        private Color newMessageColor = SettingManager.PrimaryThemeColor;
        private Color hoverColor = ColorTranslator.FromHtml("#FAF9F9");
        private Color OnlineColor = ColorTranslator.FromHtml("#1FB141");
        private bool isSelected = false;
        public string ContactName
        {
            set
            {
                contactNameLB.Text = value;
            }
            get
            {
                return contactNameLB.Text;
            }
        }
        public Contact Contact
        {
            get
            {
                return contact;
            }
            set
            {
                if (value != null)
                {
                    contact = value;
                    IsOnline = contact.IsOnline;
                    ContactName = contact.FirstName;
                    newMessageCount = contact.NewMessageCount;
                    timeP.Invalidate();
                    DpImagePath = contact.DpPicture;
                }

            }
        }
        public Group Group
        {
            get
            {
                return group;
            }
            set
            {
                if (value != null)
                {
                    group = value;
                    ContactName = group.GroupName;
                    newMessageCount = group.NewMessageCount;
                    timeP.Invalidate();
                    DpImagePath = group.DpPicture;
                    IsGroup = true;
                }
            }
        }
        public bool IsOnline{
        set {
                isOnline = value;
                int a = 0;
                
                profilePictureBox.Invalidate();
        }
        get{
                return isOnline;
        }
        }
        public bool IsArchived
        {
            get
            {
                if (IsGroup)
                    return group.IsArchived;
                else
                    return contact.IsArchived;
            }
            set{

                isArchived = value;
                if (IsGroup)
                {
                    GroupsManager.ChangeIsArchived(group.GroupID, isArchived);
                    group.IsArchived = isArchived;
                }
                else
                {
                    ContactsManager.ChangeIsArchived(contact.HostName, isArchived);
                    contact.IsArchived = isArchived;
                }
            }
        }
        public int NewMessageCount
        {
            set
            {
                newMessageCount = value;
                if (IsGroup)
                {
                    GroupsManager.ChangeNewMessageCount(group.GroupID, newMessageCount);
                    group.NewMessageCount = newMessageCount;
                }
                else
                {
                    ContactsManager.ChangeNewMessageCount(contact.HostName, newMessageCount);
                    contact.NewMessageCount = newMessageCount;
                }
                timeP.Invalidate();
            }
            get
            {
                return newMessageCount;
            }
        }
        public string DpImagePath
        {
            set
            {
                try
                {
                    if (value != "File Not Found" && value != "")
                        profilePictureBox.Image = Image.FromFile(value);
                    else
                        profilePictureBox.Image = Properties.Resources.profile_user;
                }
                catch
                {
                    profilePictureBox.Image = Properties.Resources.profile_user;
                }
            }

        }
        public bool IsGroup
        {
            set;
            get;
        }
      
        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                isSelected = value;
                if (isSelected == true)
                {
                    BackColor = ColorTranslator.FromHtml("#EAEAEA");
                    NewMessageCount = 0;
                }
                else
                {
                    BackColor = Color.Transparent;
                }
            }
        }

        public DateTime LastMessageTime
        {
            set
            {
                lastMessageTime = value;
                if (lastMessageTime != null)
                    timeLB.Text = GetLastMessageDate(value);
            }
            get
            {
                return lastMessageTime;
            }
        }

        public Message LastMessage
        {
            set
            {
                if (value != null)
                {
                    if (lastMessage == null || (lastMessage != null && lastMessage.DateAndTime < value.DateAndTime))
                    {
                        lastMessage = value;
                        if (LastMessage.FromHostName == NetworkManager.PcHostName)
                            lastMessageLB.Text = "You :" + LastMessage.MessageText;
                        else
                        {
                            var g = CreateGraphics();
                            lastMessageLB.Width = (int)g.MeasureString(lastMessageLB.Text, lastMessageLB.Font).Width;
                            if (LastMessage.GroupId == 0)
                                lastMessageLB.Text = LastMessage.MessageText;
                            else
                                lastMessageLB.Text = ContactsManager.GetContactFirstname(LastMessage.FromHostName) + " :" + LastMessage.MessageText;
                        }
                        LastMessageTime = LastMessage.DateAndTime;
                    }

                }
                else
                {
                    lastMessageLB.Text = "";
                    timeLB.Text = "";
                }
            }
            get
            {
                return lastMessage;
            }
        }

        public ContactU()
        {
            InitializeComponent();

        }
        public ContactU(Contact _contact)
        {
            InitializeComponent();
            newMessageColor = SettingManager.PrimaryThemeColor;
            SettingManager.ThemeSetUpInvoke += ThemeSetUp;
            // values Assign
            Contact = _contact;
            Disposed += ContactUDisposed;
            timeP.Paint += TimePPaint;
            Resize += ContactUResize;
            timeLB.Resize += ContactUResize;

        }

        private void ContactUDisposed(object sender, EventArgs e)
        {
            if (profilePictureBox.Image != null)
                profilePictureBox.Image.Dispose();
        }

        private void ThemeSetUp(object sender, EventArgs e)
        {
            newMessageColor = SettingManager.PrimaryThemeColor;
            timeP.Invalidate();
        }

        public ContactU(Group _group)
        {
            InitializeComponent();
            newMessageColor = SettingManager.PrimaryThemeColor;
            SettingManager.ThemeSetUpInvoke += ThemeSetUp;
            // values Assign
            Group = _group;
            Disposed += ContactUDisposed;
            timeP.Paint += TimePPaint;
            Resize += ContactUResize;
            timeLB.Resize += ContactUResize;
     
        }

        private void DpPictureBoxClick(object sender, EventArgs e)
        {
            OnclickDppicture?.Invoke(this, EventArgs.Empty);
        }

        private void ContactUResize(object sender, EventArgs e)
        {

            timeLB.Location = new Point(timeP.Width / 2 - timeLB.Width / 2, 0);
        }

        private string GetLastMessageDate(DateTime dateTime)
        {
            if (dateTime.Day == DateTime.Now.Day && dateTime.Month == DateTime.Now.Month && dateTime.Year == DateTime.Now.Year)
            {
                return dateTime.ToString("hh:mm tt");
            }
            else if (dateTime.Day == DateTime.Now.AddDays(-1).Day && dateTime.Month == DateTime.Now.AddDays(-1).Month && dateTime.Year == DateTime.Now.AddDays(-1).Year)
            {
                return "Yesterday";
            }
            else
            {
                return dateTime.ToString("dd-MM-yyyy");
            }
        }
        private void TimePPaint(object sender, PaintEventArgs e)
        {
            if (NewMessageCount != 0)
            {

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush p = new SolidBrush(newMessageColor))

                {
                    SizeF newMessageCountSize;
                    if (newMessageCount > 999)
                        newMessageCountSize = e.Graphics.MeasureString(100000 + "", new Font("Segoe UI", 10, FontStyle.Bold));
                    else
                        newMessageCountSize = e.Graphics.MeasureString(newMessageCount + "100", new Font("Segoe UI", 10, FontStyle.Bold));

                    RectangleF rectangleF;
                    if (newMessageCount > 999)
                    {
                        rectangleF = new RectangleF(timeP.Width - newMessageCountSize.Width - 10, timeP.Height - newMessageCountSize.Height - 10, newMessageCountSize.Width - 5, newMessageCountSize.Height - 2);
                        e.Graphics.FillPath(p, GetFigurePath(rectangleF, newMessageCountSize.Height - 1));
                        e.Graphics.DrawString("999+", new Font("Segoe UI", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(rectangleF.X + 11, rectangleF.Y + 1));
                    }

                    else if (newMessageCount > 99)
                    {
                        rectangleF = new RectangleF(timeP.Width - newMessageCountSize.Width - 9, timeP.Height - newMessageCountSize.Height - 10, newMessageCountSize.Width - 5, newMessageCountSize.Height - 2);
                        e.Graphics.FillPath(p, GetFigurePath(rectangleF, newMessageCountSize.Height - 1));
                        e.Graphics.DrawString(newMessageCount + "", new Font("Segoe UI", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(rectangleF.X + 12, rectangleF.Y + 1));
                    }
                    else if (newMessageCount > 9)
                    {
                        rectangleF = new RectangleF(timeP.Width - newMessageCountSize.Width - 10, timeP.Height - newMessageCountSize.Height - 10, newMessageCountSize.Width - 4, newMessageCountSize.Height - 2);
                        e.Graphics.FillPath(p, GetFigurePath(rectangleF, newMessageCountSize.Height - 1));
                        e.Graphics.DrawString(newMessageCount + "", new Font("Segoe UI", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(rectangleF.X + 8, rectangleF.Y + 1));
                    }
                    else
                    {
                        rectangleF = new RectangleF(timeP.Width - newMessageCountSize.Width - 14, timeP.Height - newMessageCountSize.Height - 10, newMessageCountSize.Width + 3, newMessageCountSize.Height);
                        e.Graphics.FillPath(p, GetFigurePath(rectangleF, newMessageCountSize.Height - 1));
                        e.Graphics.DrawString(newMessageCount + "", new Font("Segoe UI", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(rectangleF.X + 9, rectangleF.Y + 1));
                    }
                    timeLB.ForeColor = newMessageColor;
                }
            }
            else
            {
                timeLB.ForeColor = Color.FromArgb(102, 102, 102);
            }

        }
        public GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 90, 180);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 180);
            path.CloseFigure();
            return path;
        }

        private void ContactUClick(object sender, EventArgs e)
        {
            if (!IsGroup)
            {
                OnclickGetContact?.Invoke(this, Contact);
            }
            else
            {
                OnclickGetContact?.Invoke(this, Group);
            }
            NewMessageCount = 0;
        }
        private void ContactUMouseEnter(object sender, EventArgs e)
        {
            if (!isSelected)
            {
                BackColor = hoverColor;
            }
        }
        private void ContactUMouseLeave(object sender, EventArgs e)
        {
            if (!isSelected)
            {
                BackColor = Color.Transparent;
            }
        }

        private void DpImagePictureBoxPaint(object sender, PaintEventArgs e)
        {
             if(IsOnline){
                using (SolidBrush brush = new SolidBrush(OnlineColor)){
                    e.Graphics.FillEllipse(brush, new Rectangle(profilePictureBox.Width - 17, profilePictureBox.Height-17, 12, 12));
                }
             } 
        }
    }
}
