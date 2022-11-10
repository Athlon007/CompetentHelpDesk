using System.Windows.Forms;

namespace DemoApp.Custom_Controls
{
    public class FasterTableLayoutPanel : TableLayoutPanel
    {
        public FasterTableLayoutPanel()
        {
            // Enable double buffering for the control. 
            this.DoubleBuffered = true;
        }
    }
}
