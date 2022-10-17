using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;
using System.Drawing;

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
        /// <param name="parent">Control to resume drawing.</param>
        public static void ResumeDrawing(this Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }

        /// <summary>
        /// For enums, it adds spaces in front of the capital letters, to make them nicer.
        /// </summary>
        /// <param name="text">Text to nicefy</param>
        /// <returns></returns>
        public static string Prettify(this string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (i > 0 && char.IsUpper(text[i]) && text[i - 1] != ' ')
                {
                    sb.Append(' ');
                }
                sb.Append(text[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Inverts the image.
        /// </summary>
        /// <param name="image">Input image.</param>
        /// <returns>Inverted version of the same image.</returns>
        public static Image InvertImage(this Image image)
        {
            if (image == null)
            {
                return null;
            }

            for (int x = 0; x < image.Width - 1; x++)
            {
                for (int y = 0; y < image.Height - 1; y++)
                {
                    Color inv = ((Bitmap)image).GetPixel(x, y);
                    if (inv.A > 0)
                    {
                        inv = Color.FromArgb(inv.A, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    }
                    ((Bitmap)image).SetPixel(x, y, inv);
                }
            }

            return image;
        }
    }
}
