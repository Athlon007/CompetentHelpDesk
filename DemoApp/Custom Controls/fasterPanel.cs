using System.Windows.Forms;

namespace DemoApp.Custom_Controls
{
    public class fasterPanel : Panel
    {
        public fasterPanel()
        {
            this.DoubleBuffered = true;
        }
    }
}
