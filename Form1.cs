using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpyDotNet
{
    public partial class mainForm : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(Point p);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetParent(IntPtr hWnd);

        public static string GetText(IntPtr hWnd)
        {
            int windowLength = GetWindowTextLength(hWnd);
            StringBuilder windowText = new StringBuilder(windowLength + 1);
            GetWindowText(hWnd, windowText, windowText.Capacity);
            return windowText.ToString();
        }

        public static string GetClass(IntPtr hWnd)
        {
            StringBuilder className = new StringBuilder(256);
            GetClassName(hWnd, className, className.Capacity);
            return className.ToString();
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IntPtr currentWindow = WindowFromPoint(Cursor.Position);
            currentWindowHandle.Text = currentWindow.ToString();
            currentWindowText.Text = GetText(currentWindow);
            currentWindowClass.Text = GetClass(currentWindow);

            IntPtr parentWindow = GetParent(currentWindow);
            if (parentWindow != IntPtr.Zero)
            {
                parentWindowHandle.Text = parentWindow.ToString();
                parentWindowText.Text = GetText(parentWindow);
                parentWindowClass.Text = GetClass(parentWindow);
            }
            else
            {
                parentWindowHandle.Text = String.Empty;
                parentWindowText.Text = String.Empty;
                parentWindowClass.Text = String.Empty;
            }
        }
    }
}
