using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DemoApp.Custom_Controls
{
    public class TextBoxWithPrompt : TextBox
    {
        private string promptText;
        private Label promptLabel;

        public string PromptText
        {
            get => promptText;
            set { promptText = value; this.Invalidate(); UpdatePrompt(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (string.IsNullOrEmpty(this.Text))
            {
                promptLabel.Text = promptText;
                promptLabel.Show();
            }
            else
            {
                promptLabel.Hide();
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdatePrompt();
        }

        private void UpdatePrompt()
        {
            if (this.IsHandleCreated && promptText != null)
            {
                SendMessage(this.Handle, 0x1501, (IntPtr)1, promptText);
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, string lp);
    }
}
