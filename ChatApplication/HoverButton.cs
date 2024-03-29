﻿using System;
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
        private Color buttonSideHoverlineColor = ColorTranslator.FromHtml("#1B8755");
        private bool isFormUp;
        private  bool isSelected;
        private int startPoint=-3;
        private int endPoint=-3;
        System.Windows.Forms.Timer timer;
        
        public bool IsSelected
        {
            get
            {
                return isSelected;

            }
            set 
            { isSelected = value;
                if (isSelected)
                {
                    startPoint = Height / 4 + 2;
                    endPoint = (Height / 4 - 2) * 3;
                }
              
                Invalidate();
            }
        }

        public int EndPoint { get => endPoint; set => endPoint = value; }
        public bool IsFormUp { get => isFormUp; set => isFormUp = value; }
        public Color ButtonSideHoverlineColor { get => buttonSideHoverlineColor; set => buttonSideHoverlineColor = value; }

        public HoverButton()
        {
            
            MouseClick += SideLineEffectMouseClick;
            Resize += ButtonResize;
            timer=new System.Windows.Forms.Timer();
            timer.Interval = 5;

        }

        private void ButtonResize(object sender, EventArgs e)
        {
            if (isSelected)
            {
                startPoint = Height / 4 + 2;
                endPoint = (Height / 4 - 2) * 3;
                Invalidate();
            }
            
        }
         public void CallToLeaveSideLineEffect()
        {
            // SideLineEffectMouseClick(this, new MouseEventArgs(MouseButtons.None, 1, 0, 0, 0));
            if (isSelected == true)
            {
                isSelected = false;
                startPoint = Height / 4 + 2;
                endPoint = (Height / 4 - 2) * 3;
                timer.Tick += SideLineEffectGo;
                timer.Start();
            }
            
        }
        private void SideLineEffectMouseClick(object sender, MouseEventArgs e)
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
                if (endPoint < (((Height / 4) - 2)*3))
                {
                    endPoint = endPoint + 2;
                    Invalidate();
                }
                else
                {
                    timer.Stop();
                    timer.Tick -= SideLineEffectCome;
                    startPoint = Height / 4+2;
                    Invalidate();
                }
            }
            else
            {
                if (startPoint > (Height / 4 + 2))
                {
                    startPoint = startPoint - 2;
                    Invalidate();
                }
                else
                {
                    timer.Stop();
                    timer.Tick -= SideLineEffectCome;
                    endPoint = (Height / 4 - 2) * 3;
                    Invalidate();
                }
            }
        }

        private void SideLineEffectGo(object sender, EventArgs e)
        {
            if (isFormUp)
            {
                if ( startPoint>-3)
                {
                    startPoint = startPoint - 2;
                    Invalidate();
                }
                else
                {
                    timer.Stop();
                    // isSelected = false;
                    timer.Tick -= SideLineEffectGo;
                    endPoint = -3;
                    Invalidate( );
                }

            }
            else
            {
                if (endPoint< Height)
                {
                    endPoint = endPoint + 2;
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
            Rectangle bottomArc = new Rectangle(0, endPoint , arcWidth, arcHeight);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(topArc, 180, 180);
            path.AddArc(bottomArc, 0, 180);
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

                GraphicsPath path = GetFigurePath();
                using (SolidBrush brush = new SolidBrush(ButtonSideHoverlineColor))
                {
                    e.FillPath(brush, path);
                }
            
        }

    }
}

