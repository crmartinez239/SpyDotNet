using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
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

        private const int CURSOR_TARGET = 0;
        private const int CURSOR_NORMAL = 1;

        private const int PICTURE_TARGET = 0;
        private const int PICTURE_STOP = 1;

        private string GetText(IntPtr hWnd)
        {
            int windowLength = GetWindowTextLength(hWnd);
            StringBuilder windowText = new StringBuilder(windowLength + 1);
            GetWindowText(hWnd, windowText, windowText.Capacity);
            return windowText.ToString();
        }

        private string GetClass(IntPtr hWnd)
        {
            StringBuilder className = new StringBuilder(256);
            GetClassName(hWnd, className, className.Capacity);
            return className.ToString();
        }

        private void SetCursor(int cursorType)
        {
            if (cursorType == CURSOR_TARGET)
            {
                using (MemoryStream memoryStream = new MemoryStream(Properties.Resources.Target))
                {
                    this.Cursor = new Cursor(memoryStream);
                }
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void SetPicture(int pictureType)
        {
            if (pictureType == PICTURE_TARGET)
            {
                targetPicture.Image = Properties.Resources.target1;
            }
            else
            {
                targetPicture.Image = Properties.Resources.Stop.ToBitmap();
            }
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

        private void targetPicture_MouseDown(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled)
            {
                SetCursor(CURSOR_TARGET);
                targetPicture.Image = null;
            }
        }

        private void targetPicture_MouseUp(object sender, MouseEventArgs e)
        {
            SetCursor(CURSOR_NORMAL);
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                SetPicture(PICTURE_STOP);
            }
            else
            {
                timer1.Enabled = true;
                SetPicture(PICTURE_TARGET);
            }
        }

        private void copyCurrentHandle_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(currentWindowHandle.Text);
        }

        private void copyCurrentText_Click(object sender, EventArgs e)
        {
            if (currentWindowText.Text != String.Empty)
            {
                Clipboard.SetText(currentWindowText.Text);
            }
        }

        private void copyCurrentClass_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(currentWindowClass.Text);
        }

        private void copyParentHandle_Click(object sender, EventArgs e)
        {
            if (parentWindowHandle.Text != String.Empty)
            {
                Clipboard.SetText(parentWindowHandle.Text);
            }
        }

        private void copyParentText_Click(object sender, EventArgs e)
        {
            if (parentWindowText.Text != String.Empty)
            {
                Clipboard.SetText(parentWindowText.Text);
            }
        }

        private void copyParentClass_Click(object sender, EventArgs e)
        {
            if (parentWindowClass.Text != String.Empty)
            {
                Clipboard.SetText(parentWindowClass.Text);
            }
        }

        private void textBox_MouseHover(object sender, EventArgs e)
        {
            Control textBox = (Control)sender;
            toolTip.SetToolTip(textBox, textBox.Text);
        }

    }       
}
