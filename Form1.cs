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
        private const int CURSOR_TARGET = 0;
        private const int CURSOR_NORMAL = 1;

        private const int PICTURE_TARGET = 0;
        private const int PICTURE_STOP = 1;

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
            var currentWindowInfo = Spy.GetCurrentWindowInfo();
            var parentWindowInfo = Spy.GetParentWindowInfo();

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
