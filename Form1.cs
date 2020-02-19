using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpyDotNet
{
    public partial class MainForm : Form
    {
        private const int CursorTarget = 0;
        private const int CursorNormal = 1;

        private const int PictureTarget = 0;
        private const int PictureStop = 1;

        private void SetCursor(int cursorType)
        {
            if (cursorType == CursorTarget)
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
            if (pictureType == PictureTarget)
            {
                targetPicture.Image = Properties.Resources.target1;
            }
            else
            {
                targetPicture.Image = Properties.Resources.Stop.ToBitmap();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Spy.WindowInfo currentWindowInfo = Spy.GetCurrentWindowInfo();
            Spy.WindowInfo parentWindowInfo = Spy.GetParentWindowInfo();

            currentWindowHandle.Text = currentWindowInfo.Handle;
            currentWindowText.Text = currentWindowInfo.Text;
            currentWindowClass.Text = currentWindowInfo.Class;

            parentWindowHandle.Text = parentWindowInfo.Handle;
            parentWindowText.Text = parentWindowInfo.Text;
            parentWindowClass.Text = parentWindowInfo.Class;
        }

        private void targetPicture_MouseDown(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled)
            {
                SetCursor(CursorTarget);
                targetPicture.Image = null;
            }
        }

        private void targetPicture_MouseUp(object sender, MouseEventArgs e)
        {
            SetCursor(CursorNormal);
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                SetPicture(PictureStop);
            }
            else
            {
                timer1.Enabled = true;
                SetPicture(PictureTarget);
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
