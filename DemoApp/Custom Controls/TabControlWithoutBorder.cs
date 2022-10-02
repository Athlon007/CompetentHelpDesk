using System;
using System.Windows.Forms;

namespace DemoApp.Custom_Controls
{
    public class TabControlWithoutBorder : TabControl
    {
        public TabControlWithoutBorder()
        {
            // During runtime...
            if (!this.DesignMode)
            {
                // Allow multiple rows of tabs
                this.Multiline = true;
            }

            this.DoubleBuffered = true;
        }

        protected override void WndProc(ref Message m)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !this.DesignMode)
            {
                m.Result = new IntPtr(1);
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
