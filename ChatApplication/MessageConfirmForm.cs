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

namespace ChatApplication
{
    public partial class MessageConfirmForm : Form
    {

        private Timer VisbleAndInVisibleTimer = new Timer();
        private int VisbleAndInvisbleCount = 0;
        public MessageConfirmForm()
        {
            InitializeComponent();
        }
       
        public MessageConfirmForm(string message)
        {
            InitializeComponent();
            //Theme Setup
            yesBtn.BackColor = SettingManager.PrimaryThemeColor;
            messageBoxTopP.BackColor = SettingManager.PrimaryThemeColor; 

            messageLB.Text = message;
            this.Load += MessageConfirmFormLoad;
            closeBtn.Click += (sender, e) => { this.Dispose(); };
            messageLB.Resize += MessageLBResize;
            VisbleAndInVisibleTimer.Interval = 10;
            VisbleAndInVisibleTimer.Tick += VisbleAndInVisibleTimerTick;
        }
              
        private void VisbleAndInVisibleTimerTick(object sender, EventArgs e)
        {
           if(VisbleAndInvisbleCount>10){
                VisbleAndInVisibleTimer.Stop();
                VisbleAndInvisbleCount = 0;
           }
           else{
                Hide();
                Show();
           }
        }

        private void MessageLBResize(object sender, EventArgs e)
        {
            messageLB.Location = new Point(this.Width / 2 - messageLB.Width / 2, messageLB.Location.Y);
        }

        private void MessageConfirmFormLoad(object sender, EventArgs e)
        {
            yesBtn.Click+= BtnClick;
            noBtn.Click += BtnClick;
            messageBoxTopP.MouseUp += MessageBoxTopPMouseUp;
            messageBoxTopP.MouseDown += MessageBoxTopPMouseDown;
            messageBoxTopP.MouseMove += MessageBoxTopPMouseMove;
            MessageLBResize(this, EventArgs.Empty);    
    }

      
        private void MessageConfirmFormLostFocus(object sender, EventArgs e)
        {
            //VisbleAndInVisibleTimer.Start();
        }
        private bool isUp = false;
        private Point prevPoint;
        private void MessageBoxTopPMouseMove(object sender, MouseEventArgs e)
        {
        if(isUp)
            {
                this.Location = new Point(Location.X+(Cursor.Position.X - prevPoint.X), Location.Y + (Cursor.Position.Y - prevPoint.Y));
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
        if(sender== yesBtn)
           this.DialogResult = DialogResult.Yes;
        else{
                this.DialogResult = DialogResult.No;
            }
            this.Dispose();
        }

    }
}
