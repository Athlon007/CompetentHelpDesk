using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DemoApp.Custom_Controls
{
    public class RoundedPanel : Panel
    {
        // Fields
        private int borderRadius = 40;
        private float borderAngle = 90F;
        private Color surfaceColor;

        // Constructor
        public RoundedPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(450, 300);
            this.DoubleBuffered = true;
        }

        // Properties
        public int BorderRadius { 
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }

        public float BorderAngle { 
            get => borderAngle;
            set { borderAngle = value; this.Invalidate(); } 
        }

        public Color SurfaceColor {
            get => surfaceColor;
            set { surfaceColor = value; this.Invalidate(); }
        }

        /// <summary>
        /// Creates a path with the given Rectangle object and radius.
        /// </summary>
        private GraphicsPath GetPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        /// <summary>
        /// Overrides the OnPaint event and creates a new panel with rounded borders.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Graphics anti-alias
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush brush = new SolidBrush(surfaceColor);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, ClientRectangle);

            // Border Radius
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);

            
            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetPath(rectangleF, borderRadius))
                {
                    using (Pen pen = new Pen(surfaceColor, 2))
                    {
                        this.Region = new Region(graphicsPath);
                        e.Graphics.DrawPath(pen, graphicsPath);
                    }
                }
            }
            else
            {
                this.Region = new Region(rectangleF);
            }
        }
    }
}
