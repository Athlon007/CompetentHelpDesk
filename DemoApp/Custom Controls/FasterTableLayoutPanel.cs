using System.Windows.Forms;

namespace DemoApp.Custom_Controls
{
    public class FasterTableLayoutPanel : TableLayoutPanel
    {
        public FasterTableLayoutPanel()
        {
            this.DoubleBuffered = true;
        }
    }
}
