using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DemoApp.Common
{
    internal static class Extensions
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        /// <summary>
        /// Suspends drawing of the control
        /// </summary>
        /// <param name="parent">Contorl to stop drawing.</param>
        public static void SuspendDrawing(this Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        /// <summary>
        /// Resumes drawing of the control.
        /// </summary>
        /// <param name="parent">Cotntrol to resume drawing.</param>
        public static void ResumeDrawing(this Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }
    }
}
