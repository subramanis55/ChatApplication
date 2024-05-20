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
    public partial class MessageDateU : UserControl
    {
        private string message = "Message";
        private DateTime dateAndTime = DateTime.MinValue;
        public DateTime DateAndTime{
           set{
           if(value!= DateTime.MinValue){
                    dateAndTime = value;
                    DateAndTimeSet();
                }                
           }
           get{
                return dateAndTime;
           }
        }

        private void DateAndTimeSet()
        {
            DateTime tempDateTimeToCheckYesterDay = DateTime.Now.AddDays(-1);
            if (DateAndTime.Day == tempDateTimeToCheckYesterDay.Day && DateAndTime.Month == tempDateTimeToCheckYesterDay.Month && DateAndTime.Year == tempDateTimeToCheckYesterDay.Year)
            {
                MessageText = "Yesterday";
            }
            else if (DateTime.Now.Day == DateAndTime.Day && DateTime.Now.Month == DateAndTime.Month && DateTime.Now.Year == DateAndTime.Year)
            {
                MessageText = "Today";
            }
            else{
                MessageText = dateAndTime.ToString("dd-MM-yyyy");
            }
        }

        public string MessageText
        {
            get => message;
            set
            {
                message = value;
                messageLB.Text = message;
                // this.Size = new Size(messageLB.Width + 6, messageLB.Height + 10);
                // Padding = new Padding(3, 3, 3, 3);
                HoverMessageUResize(this, EventArgs.Empty);
            }
        }
        public MessageDateU()
        {
            InitializeComponent();
            Resize += HoverMessageUResize;
        }
        public MessageDateU(DateTime dateTime)
        {
            InitializeComponent();
            Resize += HoverMessageUResize;
            DateAndTime = dateTime;
        }

        private void HoverMessageUResize(object sender, EventArgs e)
        {
            messageLB.Location = new Point(Width / 2 - messageLB.Width / 2, Height / 2 - messageLB.Height / 2);
        }

        private void HoverMessageU_Load(object sender, EventArgs e)
        {

        }
    }
}
