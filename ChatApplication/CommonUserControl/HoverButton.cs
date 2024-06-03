
using ChatApplication.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ChatApplication
{
    public class HoverButton : EllipseButton
    {
        private Color buttonSideHoverlineColor = SettingManager.PrimaryThemeColor;
        private bool isFormUp;
        private bool isSelected;
        private int startPoint = -3;
        private int endPoint = -3;
        private int unreadMessageContactCount = 0;
        System.Windows.Forms.Timer timer;

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
                    startPoint = Height / 4 - 1;
                    endPoint = (Height / 4) * 3 - 1;
                }

                Invalidate();
            }
        }
        public int UnreadMessageContactCount
        {
            get
            {
                return unreadMessageContactCount;

            }
            set
            {
                unreadMessageContactCount = value;
                Invalidate();
            }
        }

        public int EndPoint { get => endPoint; set => endPoint = value; }
        public bool IsFormUp { get => isFormUp; set => isFormUp = value; }
        public Color ButtonSideHoverlineColor
        {
            get => buttonSideHoverlineColor;

            set
            {
                buttonSideHoverlineColor = value;
                Invalidate();
            }
        }

        public HoverButton()
        {

            MouseClick += SideLineEffectMouseClick;
            Resize += ButtonResize;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5;

        }

        private void ButtonResize(object sender, EventArgs e)
        {
            if (isSelected)
            {
                startPoint = Height / 4 - 1;
                endPoint = (Height / 4) * 3 - 1;
                Invalidate();
            }

        }
        public void CallToLeaveSideLineEffect()
        {
            // SideLineEffectMouseClick(this, new MouseEventArgs(MouseButtons.None, 1, 0, 0, 0));
            if (isSelected == true)
            {
                isSelected = false;
                startPoint = Height / 4 - 1;
                endPoint = (Height / 4) * 3 - 1;
                timer.Tick += SideLineEffectGo;
                timer.Start();
            }

        }
        public void SideLineEffectMouseClick(object sender, MouseEventArgs e)
        {
            timer.Interval = 1;
            if (!isSelected)
            {
                isSelected = true;
                timer.Tick += SideLineEffectCome;
                if (IsFormUp)
                {
                    startPoint = 0;
                    endPoint = 0;
                }
                else
                {
                    startPoint = Height;
                    endPoint = Height;
                }
                timer.Start();
            }

        }

        private void SideLineEffectCome(object sender, EventArgs e)
        {
            if (IsFormUp)
            {
                if (endPoint < (((Height / 4)) * 3) - 1)
                {
                    endPoint = endPoint + Height / 4;
                    Invalidate();
                }
                else
                {
                    timer.Stop();
                    timer.Tick -= SideLineEffectCome;
                    startPoint = Height / 4 - 1;
                    endPoint = (Height / 4) * 3 - 1;
                    Invalidate();
                }
            }
            else
            {
                if (startPoint > (Height / 4 - 1))
                {
                    startPoint = startPoint - Height / 4;
                    Invalidate();
                }
                else
                {
                    timer.Stop();
                    timer.Tick -= SideLineEffectCome;
                    startPoint = Height / 4 - 1;
                    endPoint = (Height / 4) * 3 - 1;
                    Invalidate();
                }
            }
        }

        private void SideLineEffectGo(object sender, EventArgs e)
        {
            if (isFormUp)
            {
                if (startPoint > -3)
                {
                    startPoint = startPoint - Height / 4;
                    Invalidate();
                }
                else
                {
                    timer.Stop();
                    // isSelected = false;
                    timer.Tick -= SideLineEffectGo;
                    endPoint = -3;
                    Invalidate();
                }

            }
            else
            {
                if (endPoint < Height)
                {
                    endPoint = endPoint + Height / 4;
                    Invalidate();
                }
                else
                {
                    timer.Stop();
                    timer.Tick -= SideLineEffectGo;
                    //  isSelected = false;
                    startPoint = Height;
                    Invalidate();
                }

            }
        }


        private GraphicsPath GetFigurePath()
        {
            int arcWidth = 4;
            int arcHeight = 4;
            Rectangle topArc = new Rectangle(0, startPoint, arcWidth, arcHeight);
            Rectangle bottomArc = new Rectangle(0, endPoint, arcWidth, arcHeight);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(topArc, 180, 180);
            path.AddArc(bottomArc, 0, 180);
            path.CloseFigure();
            return path;
        }
        public GraphicsPath GetNewMessagedContactCountFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 90, 180);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 180);
            path.CloseFigure();
            return path;
        }
        public void DirectionSet(Object Sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs args)
        {
            base.OnPaint(args);
            var e = args.Graphics;
            GraphicsPath path1 = GetFigurePath();
            RectangleF rectangleF;


            if (unreadMessageContactCount != 0)
            {
                SizeF newMessageCountSize = e.MeasureString(unreadMessageContactCount + "100", new Font("Segoe UI", 8, FontStyle.Bold));
                e.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush p = new SolidBrush(SettingManager.PrimaryThemeColor))
                {

                    if (unreadMessageContactCount > 99)
                    {
                        newMessageCountSize = e.MeasureString("99+", new Font("Segoe UI", 8, FontStyle.Bold));
                        rectangleF = new RectangleF(Width - newMessageCountSize.Width - 9, 4, newMessageCountSize.Width - 5, newMessageCountSize.Height - 2);
                        e.FillPath(p, GetFigurePath(rectangleF, newMessageCountSize.Height - 1));
                        e.DrawString(99 + "+", new Font("Segoe UI", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(rectangleF.X + 12, rectangleF.Y + 1));
                    }
                    else if (unreadMessageContactCount > 9)
                    {
                        rectangleF = new RectangleF(Width - newMessageCountSize.Width - 9, 4, newMessageCountSize.Width - 5, newMessageCountSize.Height - 2);
                        e.FillPath(p, GetNewMessagedContactCountFigurePath(rectangleF, newMessageCountSize.Height - 1));
                        e.DrawString(unreadMessageContactCount + "", new Font("Segoe UI", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(rectangleF.X + 8, rectangleF.Y + 1));
                    }
                    else
                    {
                        rectangleF = new RectangleF(Width - newMessageCountSize.Width - 9, 4, newMessageCountSize.Width - 5, newMessageCountSize.Height - 2);
                        e.FillPath(p, GetFigurePath(rectangleF, newMessageCountSize.Height - 1));
                        e.DrawString(unreadMessageContactCount + "", new Font("Segoe UI", 9, FontStyle.Bold), new SolidBrush(Color.White), new PointF(rectangleF.X + 9, rectangleF.Y + 1));
                    }

                }
            }
            using (SolidBrush brush = new SolidBrush(ButtonSideHoverlineColor))
            {
                e.FillPath(brush, path1);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // HoverButton
            // 
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroudColor = System.Drawing.Color.CornflowerBlue;
            this.FlatAppearance.BorderSize = 0;
            this.ResumeLayout(false);

        }
    }
}




