using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DemoApp.Custom_Controls
{
    public class CircularProgressBar : UserControl
    {
        // Fields
        private float valueSize = 10;
        private float valueMax = 100;
        private int borderSize = 25;
        private Color middleCircleColor = ColorTranslator.FromHtml("#EAEAEA");
        private Color outerCircleColor = ColorTranslator.FromHtml("#FF8000");
        private Color fontColor = ColorTranslator.FromHtml("#525152");
        private Color fontSecondaryColor = ColorTranslator.FromHtml("#969696");

        // Constructor
        public CircularProgressBar()
        {
            BackColor = ColorTranslator.FromHtml("#EAEAEA");
            this.DoubleBuffered = true;
        }

        // Properties
        public float ValueSize
        {
            get { return valueSize; }
            set { valueSize = (value > 100) ? 100 : value; Invalidate(); }
        }

        public float ValueMax
        {
            get { return valueMax; }
            set { valueMax = value; Invalidate(); }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = (value > 25) ? 25 : value; Invalidate(); }
        }

        public Color MiddleCircleColor
        {
            get { return middleCircleColor; }
            set { middleCircleColor = value; Invalidate(); }
        }

        public Color OuterCircleColor
        {
            get { return outerCircleColor; }
            set { outerCircleColor = value; Invalidate(); }
        }

        public Color FontColor
        {
            get { return fontColor; }
            set { fontColor = value; Invalidate(); }
        }

        public Color FontSecondaryColor
        {
            get { return fontSecondaryColor; }
            set { fontSecondaryColor = value; Invalidate(); }
        }

        // Override
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            // Pens for drawing
            Pen backPen = new Pen(Color.White, BorderSize - 1);
            Pen pen = new Pen(outerCircleColor, BorderSize) { StartCap = LineCap.Flat, EndCap = LineCap.Flat };

            // Set settings for smoother quality
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            // Create graphics
            graphics.FillPie(new SolidBrush(middleCircleColor), new Rectangle(10, 10, Width - 25, Height - 25), 0, 360);
            graphics.DrawArc(backPen, new Rectangle(12, 12, Width - 25, Height - 25), 90, 360);
            graphics.DrawArc(pen, new Rectangle(12, 12, Width - 25, Height - 25), -90, (ValueSize / ValueMax) * 360);

            // Display amount
            StringFormat sf = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
            Rectangle offsetRectangle = new Rectangle(ClientRectangle.X, ClientRectangle.Y + ClientRectangle.Height / 6, ClientRectangle.Width, ClientRectangle.Height);

            if (valueSize > 0 && valueMax > 0) // If actual values were given...
            {
                graphics.DrawString($"{ValueSize / ValueMax * 100:0.0}%", Font, new SolidBrush(fontColor), ClientRectangle, sf);
                graphics.DrawString($"{ValueSize} / {ValueMax}", new Font(Font.FontFamily, 13, Font.Style), new SolidBrush(fontSecondaryColor), offsetRectangle, sf);
            }
            else
            {
                graphics.DrawString($"N/A", Font, new SolidBrush(fontColor), ClientRectangle, sf);
            }

            // Paint graphics
            base.OnPaint(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            Height = Width;
            base.OnSizeChanged(e);
        }
    }
}
