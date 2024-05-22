﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Timers;

namespace ChatApplication.CommonUserControl
{
    internal class ToggleButton : Control
    {

        private Color onColor = Color.ForestGreen;
        private Color offColor = Color.Red;
        private Color toggleColor = Color.White;
        private int toggleSize;
        private int margin = 1;
        private bool value = true;
        private Rectangle toggle;
        public event EventHandler<bool> ToggleOrNot;
        private int endPoint;
        private int startPoint;
        private System.Windows.Forms.Timer transitionTimer;

        [DefaultValue("Custom")]
        public Color OnColor
        {
            set { onColor = value; Invalidate(); }
            get { return onColor; }

        }
        public Color OffColor
        {
            set { offColor = value; Invalidate(); }
            get { return offColor; }
        }
        public Color ToggleColor
        {
            set { toggleColor = value; Invalidate(); }
            get { return toggleColor; }
        }
        public bool Value
        {
            set
            {
                this.value = value;
                if (this.value)
                    toggle.X = endPoint;
                else
                    toggle.X = startPoint;
                Invalidate();
            }
            get { return value; }
        }
        public int BorderMargin
        {
            set
            {
                if (value > 8)
                    this.margin = 8;
                else
                    this.margin = value;
                ToggleButtonResize(this, new EventArgs());
                Invalidate();
            }
            get { return margin; }
        }
        public ToggleButton()
        {

            Click += ToggleMouseClick;
            Resize += ToggleButtonResize;

            toggleSize = Height - (margin * 2);
            endPoint = Width - toggleSize - margin - 2;
            MinimumSize = new Size(55, 22);
            if (!value)
                toggle = new Rectangle(2, margin / 2 - 1, toggleSize, toggleSize);
            else
                toggle = new Rectangle(endPoint, margin / 2 - 1, toggleSize, toggleSize);

        }

        private GraphicsPath GetFigurePath()
        {
            int arcWidth = Height - (margin * 2);
            int arcHeight = Height - (margin * 2);

            Rectangle leftArc = new Rectangle(margin, margin / 2, arcWidth, arcHeight);
            Rectangle rightArc = new Rectangle(endPoint - 4, margin / 2, arcWidth, arcHeight);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }

        private void IncrementMethod(Object Sender, EventArgs e)
        {
            int incrementRatio = (Width - Height - 3) / 15;

            if (value)
            {
                if (toggle.X < endPoint)
                {
                    toggle.X += incrementRatio;
                }
                else
                {
                    toggle.X = endPoint;
                    transitionTimer.Stop();
                }
            }
            else
            {
                if (toggle.X > startPoint)
                {
                    toggle.X -= incrementRatio;
                }
                else
                {
                    toggle.X = startPoint;
                    transitionTimer.Stop();
                }
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs args)
        {
            DoubleBuffered = true;
            toggle.Width = toggleSize;
            toggle.Height = toggleSize;
            Graphics g = args.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(this.Parent.BackColor);
            GraphicsPath path = GetFigurePath();
            g.FillPath(new SolidBrush(value ? onColor : offColor), path);
            Pen borderPen = new Pen(Color.Black, margin);
            g.DrawPath(borderPen, path);
            g.FillEllipse(new SolidBrush(toggleColor), toggle);
        }

        private void ToggleButton_Load_1(object sender, EventArgs e)
        {

        }

        private void ToggleMouseClick(object sender, EventArgs e)
        {
            value = !value;
            transitionTimer = new System.Windows.Forms.Timer();
            transitionTimer.Interval = 1;
            transitionTimer.Tick += IncrementMethod;
            transitionTimer.Start();
            ToggleOrNot?.Invoke(this, value);
        }

        private void ToggleButtonResize(object sender, EventArgs e)
        {
            if (Width < Height + 30)
            {
                Width = Width + 30;
            }
            startPoint = margin + 2;
            toggleSize = Height - (margin * 2) - 5;
            endPoint = Width - toggleSize - margin - 2;
            toggle.Y = margin / 2 + 2;
            Invalidate();
            if (value)
                toggle.X = endPoint;
            else
                toggle.X = startPoint;
        }

        private void ToggleButtonLoad(object sender, EventArgs e)
        {
            ToggleButtonResize(this, e);
            Invalidate();
        }

    }
}