using System.Windows.Forms;

namespace DemoApp.Custom_Controls
{
    public class fasterPanel : Panel
    {
        public fasterPanel()
        {
            // Enable double buffering for the control.
            this.DoubleBuffered = true;
        }
    }
}
