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
        private int borderRadius = 10;
        private bool isArrivedMessage = false;
        private bool isSent = false;
        private int chatArcWidth = 15;
        private bool isNormal;
        private bool IsNormal
        {
            get
            {
                return isNormal;
            }
            set
            {
                isNormal = value;
            }
            
        }
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; }
        }

      
        public bool IsArrivedMessage {
            get
            {
                return isArrivedMessage;
            }
            set
            {
                isArrivedMessage = value;
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
                Invalidate();

            }
        }
        public int ChatArcWidth {
            get
            {
                return chatArcWidth;
            }
            set
            {
                chatArcWidth = value;
            } 
        }

        public ChatU()
        {
            InitializeComponent();
            DoubleBuffered= true;
        }
        public GraphicsPath GetPath(Rectangle rec)
        {
            GraphicsPath g = new GraphicsPath();
            g.StartFigure();
            if (isNormal)
            {
                chatArcWidth = 0;
            }
          if (isArrivedMessage)
            {

                g.AddArc(new Rectangle(chatArcWidth, rec.Y, borderRadius, borderRadius),180,90);
                g.AddArc(rec.Width - borderRadius, rec.Y, borderRadius, borderRadius, 270, 90);
                g.AddArc(rec.Width - borderRadius , rec.Height - borderRadius , borderRadius, borderRadius, 0, 90);
                g.AddArc(rec.X+ chatArcWidth, rec.Height - borderRadius, borderRadius, borderRadius, 90, 90);      
                g.AddPolygon(new Point[] { new Point(chatArcWidth, 0), new Point(0, 0), new Point(chatArcWidth, chatArcWidth) });
            }
            else
            {
                g.AddArc(rec.X, rec.Y, borderRadius, borderRadius, 180, 90);
                g.AddArc(new Rectangle(rec.Width - borderRadius - chatArcWidth, rec.Y,  borderRadius, borderRadius),270,90);    
                g.AddArc(rec.Width - borderRadius- chatArcWidth, rec.Height - borderRadius , borderRadius, borderRadius, 0, 90);
                g.AddArc(rec.X, rec.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                g.AddPolygon(new Point[] { new Point(rec.Width - chatArcWidth, 0), new Point(rec.Width, 0), new Point(rec.Width - chatArcWidth, chatArcWidth) });
            }
                     
            g.CloseFigure();
            return g;
        }
        public string StringFormatChange(string str, int width, Font font)
        {
            int lineCharCount;
            string space="";
           
            Graphics g = CreateGraphics();
            string temp = "";
            string formatedstring = "";
            for (lineCharCount = 0; lineCharCount < str.Length;)
            {
                var w = g.MeasureString(temp, font);
                if (w.Width < width)
                {
                    temp = temp + str[lineCharCount];
                    lineCharCount++;
                }
                else
                    break;
            }

            for (int i = 0; i < lineCharCount; i++)
            {
                space = space + " ";
            }
            str = str.Replace("\n", " \n ");
           str = str.Replace("\r", " \r ");
            string[] s = str.Split(' ');
            bool issplitting = false;

            temp = "";
            int bracket = 0;
            for (int i = 0; i < s.Length;)
            {
                if (i!=0&&s[i-1] == "\n" && s[i] != "\n")
                {
                    formatedstring = formatedstring + "\n" + temp;
                    temp = "";
                }
               
                if (i == 1)
                {
                    bracket = 1;
                }
               
                if ((temp.Length + s[i].Length + bracket) <= lineCharCount)                    //+1 for bracket
                {
                    temp = temp + " " + s[i];
                    i++;
                }
                else
                {
                    if (s[i].Length >= lineCharCount)
                    {
                        int k = temp.Length;
                        temp = temp + " " + s[i].Substring(0, lineCharCount - temp.Length - bracket);
                        s[i] = s[i].Substring(lineCharCount - k);
                        formatedstring = formatedstring + "\n" + temp;
                        temp = "";

                        while (s[i].Length >= lineCharCount)
                        {
                            k = temp.Length;
                            temp = temp + s[i].Substring(0, lineCharCount - temp.Length);
                            s[i] = s[i].Substring(lineCharCount - k);
                            formatedstring = formatedstring + "\n" + temp;
                            temp = "";
                        }
                        if (s[i].Length == 0)
                            i++;
                    }
                    else
                    {
                        formatedstring = formatedstring + "\n" + temp;
                        temp = "";
                    }
                    //-1 for bracket
                }
            }
            if (temp != "" )
            {
                formatedstring = formatedstring + "\n" + temp;
            }
           
            return formatedstring;

        }
        public void ChatCraete(string message)
        {
            string str = "";
            if (message != "")
            {
                str = StringFormatChange(message, 400, messageLB.Font);
                str = str.Substring(1);
            }
             messageLB.Text= str;
             var g = CreateGraphics();
            SizeF a = g.MeasureString(str, messageLB.Font);

            messageLB.Size = new Size((int)(a.Width+5) , (int)a.Height+20);
            this.Width=messageLB.Width+this.Padding.Left+Padding.Right+ chatArcWidth + 5;
            this.Height=messageLB.Height+this.Padding.Top+Padding.Bottom+ChatUBottomP.Height;
            DateTime time = DateTime.Now;
            if (time.Hour < 10)
            {
                timingLB.Text = "0" + time.Hour + ":";
            }
            else
            {
                timingLB.Text =  time.Hour + ":";
            }
            if (time.Minute < 10)
            {
                timingLB.Text = timingLB.Text+"0"+ time.Minute ;
            }
            else
            {
                timingLB.Text = timingLB.Text +  time.Minute;
            }
           
            Invalidate();
        }
        
        protected override void OnPaint(PaintEventArgs e) {
            var path = GetPath(ClientRectangle);
            this.Region = new Region(path);
        }
    }
}
