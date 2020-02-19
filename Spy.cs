using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SpyDotNet
{
   public static class Spy
    {
        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point p);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        private static extern IntPtr GetParent(IntPtr hWnd);

        public struct WindowInfo
        {
            public string Class { get; }
            public string Handle { get; }
            public string Text { get; }
            
            public WindowInfo(string className, string handle, string text)
            {
                Class = className;
                Handle = handle;
                Text = text;
            }
        }

        public static WindowInfo GetCurrentWindowInfo()
        {
            IntPtr currentWindow = WindowFromPoint(Cursor.Position);
            string handle = currentWindow.ToString();
            string text = GetText(currentWindow);
            string className = GetClass(currentWindow);

            return new WindowInfo(className, handle, text);
        }

        public static WindowInfo GetParentWindowInfo()
        {
            IntPtr currentWindow = WindowFromPoint(Cursor.Position);
            IntPtr parentWindow = GetParent(currentWindow);
            
            string className = String.Empty;
            string handle = String.Empty;
            string text = String.Empty;

            if (parentWindow != IntPtr.Zero)
            {
                handle = parentWindow.ToString();
                text = GetText(parentWindow);
                className = GetClass(parentWindow);
            }

            return new WindowInfo(className, handle, text);
        }

        private static string GetText(IntPtr hWnd)
        {
            int windowLength = GetWindowTextLength(hWnd);
            StringBuilder windowText = new StringBuilder(windowLength + 1);
            GetWindowText(hWnd, windowText, windowText.Capacity);
            return windowText.ToString();
        }

        private static string GetClass(IntPtr hWnd)
        {
            StringBuilder className = new StringBuilder(256);
            GetClassName(hWnd, className, className.Capacity);
            return className.ToString();
        }
    }
}
