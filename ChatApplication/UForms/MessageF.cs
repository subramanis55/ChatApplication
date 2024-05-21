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

namespace ChatApplication.UForms
{
    public partial class MessageF : Form
    {
        public MessageF(string message)
        {
            InitializeComponent();
            //Theme Setup
            messageBoxTopP.BackColor = SettingManager.PrimaryThemeColor;
            messageLB.Text = message;
            closeBtn.Click += BtnClick;
            okBtn.Click += BtnClick;
            messageBoxTopP.MouseUp += MessageBoxTopPMouseUp;
            messageBoxTopP.MouseDown += MessageBoxTopPMouseDown;
            messageBoxTopP.MouseMove += MessageBoxTopPMouseMove;
        }
        private bool isUp = false;
        private Point prevPoint;
        private void MessageBoxTopPMouseMove(object sender, MouseEventArgs e)
        {
            if (isUp)
            {
                this.Location = new Point(Location.X + (Cursor.Position.X - prevPoint.X), Location.Y + (Cursor.Position.Y - prevPoint.Y));
                prevPoint = Cursor.Position;
            }

        }
        private void MessageBoxTopPMouseDown(object sender, MouseEventArgs e)
        {
            isUp = true;
            prevPoint = Cursor.Position;
        }
        private void MessageBoxTopPMouseUp(object sender, MouseEventArgs e)
        {
            isUp = false;
        }
        private void BtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
