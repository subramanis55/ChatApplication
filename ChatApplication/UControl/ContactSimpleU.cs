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
    public partial class ContactSimpleU : UserControl
    {
        public event EventHandler<Contact> OnClickContactSimpleU;
        private Color OnlineColor = ColorTranslator.FromHtml("#1FB141");
        private Color HoverColor = ColorTranslator.FromHtml("#ECEAE9");

        private bool isOnline;
        private Contact contact;
        public bool IsOnline
        {
            set
            {
                isOnline = value;
                dpPictureBox.Invalidate();
            }
            get
            {
                return isOnline;
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
                    nameLB.Text = value.FirstName;
                    DpImage = value.DpPicture;
                }
            }
        }

        public string DpImage
        {
            set
            {
                try
                {
                    if (value != "File Not Found" && value != "")
                        dpPictureBox.Image = Image.FromFile(value);
                }
                catch
                {

                }
            }
        }
        public bool IsCheckBoxVisible
        {
            get
            {
                return checkBox.Visible;
            }
            set
            {
                checkBox.Visible = value;
                if (value == false)
                {
                    IsSelected = false;
                }
            }
        }
        public bool IsGroupAdmin
        {
            set
            {
                groupAdminLB.Visible = value;
            }
            get
            {
                return groupAdminLB.Visible;
            }
        }
        public bool IsSelected
        {
            get
            {
                return checkBox.Checked;
            }
            set
            {
                checkBox.Checked = value;
            }

        }
        public ContactSimpleU()
        {
            InitializeComponent();
            Resize += ContactSimpleUResize;

        }
        public ContactSimpleU(Contact _contact)
        {
            InitializeComponent();
            Disposed += ContactSimpleUDisposed;
            //Initialize Data
            this.Contact = _contact;

            Resize += ContactSimpleUResize;
            labelP.MouseEnter += ContactSimpleUMouseEnter;
            labelP.MouseLeave += ContactSimpleUMouseLeave;
            nameLB.MouseEnter += ContactSimpleUMouseEnter;
            nameLB.MouseLeave += ContactSimpleUMouseLeave;
        }

        private void DpPictureBoxPaint(object sender, PaintEventArgs e)
        {
            if (IsOnline)
            {
                using (SolidBrush brush = new SolidBrush(OnlineColor))
                {
                    e.Graphics.FillEllipse(brush, new Rectangle(dpPictureBox.Width - 14, dpPictureBox.Height - 12, 8, 8));
                }
            }
        }

        private void ContactSimpleUDisposed(object sender, EventArgs e)
        {
            if (dpPictureBox.Image != null)
                dpPictureBox.Image.Dispose();
        }

        private void ContactSimpleUMouseEnter(object sender, EventArgs e)
        {

            BackColor = HoverColor;
        }

        private void ContactSimpleUMouseLeave(object sender, EventArgs e)
        {

            BackColor = Color.Transparent;
        }

        private void ContactSimpleUResize(object sender, EventArgs e)
        {
            nameLB.Location = new Point(mainP.Width / 2 - nameLB.Width / 2, mainP.Height / 2 - nameLB.Height / 2);
            groupAdminLB.Location = new Point(mainP.Width - groupAdminLB.Width - 2, mainP.Height - groupAdminLB.Height - 2);

        }

        private void ContactSimpleUClick(object sender, EventArgs e)
        {

            if (IsCheckBoxVisible)
                checkBox.Checked = !checkBox.Checked;
            if (!IsCheckBoxVisible)
                OnClickContactSimpleU?.Invoke(this, this.Contact);
        }
    }
}
