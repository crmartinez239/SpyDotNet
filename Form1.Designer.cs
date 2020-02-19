namespace SpyDotNet
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.copyCurrentClass = new System.Windows.Forms.Button();
            this.copyCurrentText = new System.Windows.Forms.Button();
            this.copyCurrentHandle = new System.Windows.Forms.Button();
            this.currentWindowClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentWindowText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copyParentClass = new System.Windows.Forms.Button();
            this.copyParentText = new System.Windows.Forms.Button();
            this.copyParentHandle = new System.Windows.Forms.Button();
            this.parentWindowClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.parentWindowText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.parentWindowHandle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.targetPicture = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.currentWindowHandle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Handle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentWindowHandle);
            this.groupBox1.Controls.Add(this.copyCurrentClass);
            this.groupBox1.Controls.Add(this.copyCurrentText);
            this.groupBox1.Controls.Add(this.copyCurrentHandle);
            this.groupBox1.Controls.Add(this.currentWindowClass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.currentWindowText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Window";
            // 
            // copyCurrentClass
            // 
            this.copyCurrentClass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyCurrentClass.BackgroundImage")));
            this.copyCurrentClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyCurrentClass.FlatAppearance.BorderSize = 0;
            this.copyCurrentClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyCurrentClass.Location = new System.Drawing.Point(242, 80);
            this.copyCurrentClass.Name = "copyCurrentClass";
            this.copyCurrentClass.Size = new System.Drawing.Size(16, 16);
            this.copyCurrentClass.TabIndex = 7;
            this.copyCurrentClass.UseVisualStyleBackColor = true;
            this.copyCurrentClass.Click += new System.EventHandler(this.copyCurrentClass_Click);
            // 
            // copyCurrentText
            // 
            this.copyCurrentText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyCurrentText.BackgroundImage")));
            this.copyCurrentText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyCurrentText.FlatAppearance.BorderSize = 0;
            this.copyCurrentText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyCurrentText.Location = new System.Drawing.Point(242, 56);
            this.copyCurrentText.Name = "copyCurrentText";
            this.copyCurrentText.Size = new System.Drawing.Size(16, 16);
            this.copyCurrentText.TabIndex = 6;
            this.copyCurrentText.UseVisualStyleBackColor = true;
            this.copyCurrentText.Click += new System.EventHandler(this.copyCurrentText_Click);
            // 
            // copyCurrentHandle
            // 
            this.copyCurrentHandle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyCurrentHandle.BackgroundImage")));
            this.copyCurrentHandle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyCurrentHandle.FlatAppearance.BorderSize = 0;
            this.copyCurrentHandle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyCurrentHandle.Location = new System.Drawing.Point(242, 31);
            this.copyCurrentHandle.Name = "copyCurrentHandle";
            this.copyCurrentHandle.Size = new System.Drawing.Size(16, 16);
            this.copyCurrentHandle.TabIndex = 3;
            this.copyCurrentHandle.UseVisualStyleBackColor = true;
            this.copyCurrentHandle.Click += new System.EventHandler(this.copyCurrentHandle_Click);
            // 
            // currentWindowClass
            // 
            this.currentWindowClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentWindowClass.Location = new System.Drawing.Point(67, 78);
            this.currentWindowClass.Name = "currentWindowClass";
            this.currentWindowClass.ReadOnly = true;
            this.currentWindowClass.Size = new System.Drawing.Size(169, 18);
            this.currentWindowClass.TabIndex = 5;
            this.currentWindowClass.Text = "1232139087";
            this.currentWindowClass.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class";
            // 
            // currentWindowText
            // 
            this.currentWindowText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentWindowText.Location = new System.Drawing.Point(67, 54);
            this.currentWindowText.Name = "currentWindowText";
            this.currentWindowText.ReadOnly = true;
            this.currentWindowText.Size = new System.Drawing.Size(169, 18);
            this.currentWindowText.TabIndex = 3;
            this.currentWindowText.Text = "1232139087";
            this.currentWindowText.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.copyParentClass);
            this.groupBox2.Controls.Add(this.copyParentText);
            this.groupBox2.Controls.Add(this.copyParentHandle);
            this.groupBox2.Controls.Add(this.parentWindowClass);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.parentWindowText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.parentWindowHandle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(11, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 112);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parent Window";
            // 
            // copyParentClass
            // 
            this.copyParentClass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyParentClass.BackgroundImage")));
            this.copyParentClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyParentClass.FlatAppearance.BorderSize = 0;
            this.copyParentClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyParentClass.Location = new System.Drawing.Point(242, 80);
            this.copyParentClass.Name = "copyParentClass";
            this.copyParentClass.Size = new System.Drawing.Size(16, 16);
            this.copyParentClass.TabIndex = 7;
            this.copyParentClass.UseVisualStyleBackColor = true;
            this.copyParentClass.Click += new System.EventHandler(this.copyParentClass_Click);
            // 
            // copyParentText
            // 
            this.copyParentText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyParentText.BackgroundImage")));
            this.copyParentText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyParentText.FlatAppearance.BorderSize = 0;
            this.copyParentText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyParentText.Location = new System.Drawing.Point(242, 56);
            this.copyParentText.Name = "copyParentText";
            this.copyParentText.Size = new System.Drawing.Size(16, 16);
            this.copyParentText.TabIndex = 6;
            this.copyParentText.UseVisualStyleBackColor = true;
            this.copyParentText.Click += new System.EventHandler(this.copyParentText_Click);
            // 
            // copyParentHandle
            // 
            this.copyParentHandle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyParentHandle.BackgroundImage")));
            this.copyParentHandle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyParentHandle.FlatAppearance.BorderSize = 0;
            this.copyParentHandle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyParentHandle.Location = new System.Drawing.Point(242, 31);
            this.copyParentHandle.Name = "copyParentHandle";
            this.copyParentHandle.Size = new System.Drawing.Size(16, 16);
            this.copyParentHandle.TabIndex = 3;
            this.copyParentHandle.UseVisualStyleBackColor = true;
            this.copyParentHandle.Click += new System.EventHandler(this.copyParentHandle_Click);
            // 
            // parentWindowClass
            // 
            this.parentWindowClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parentWindowClass.Location = new System.Drawing.Point(67, 78);
            this.parentWindowClass.Name = "parentWindowClass";
            this.parentWindowClass.ReadOnly = true;
            this.parentWindowClass.Size = new System.Drawing.Size(169, 18);
            this.parentWindowClass.TabIndex = 5;
            this.parentWindowClass.Text = "1232139087";
            this.parentWindowClass.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Class";
            // 
            // parentWindowText
            // 
            this.parentWindowText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parentWindowText.Location = new System.Drawing.Point(67, 54);
            this.parentWindowText.Name = "parentWindowText";
            this.parentWindowText.ReadOnly = true;
            this.parentWindowText.Size = new System.Drawing.Size(169, 18);
            this.parentWindowText.TabIndex = 3;
            this.parentWindowText.Text = "1232139087";
            this.parentWindowText.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Text";
            // 
            // parentWindowHandle
            // 
            this.parentWindowHandle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parentWindowHandle.Location = new System.Drawing.Point(67, 30);
            this.parentWindowHandle.Name = "parentWindowHandle";
            this.parentWindowHandle.ReadOnly = true;
            this.parentWindowHandle.Size = new System.Drawing.Size(169, 18);
            this.parentWindowHandle.TabIndex = 1;
            this.parentWindowHandle.Text = "1232139087";
            this.parentWindowHandle.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Handle";
            // 
            // targetPicture
            // 
            this.targetPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.targetPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.targetPicture.Image = global::SpyDotNet.Properties.Resources.target1;
            this.targetPicture.Location = new System.Drawing.Point(281, 117);
            this.targetPicture.Name = "targetPicture";
            this.targetPicture.Size = new System.Drawing.Size(32, 32);
            this.targetPicture.TabIndex = 4;
            this.targetPicture.TabStop = false;
            this.targetPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.targetPicture_MouseDown);
            this.targetPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.targetPicture_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // currentWindowHandle
            // 
            this.currentWindowHandle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentWindowHandle.Location = new System.Drawing.Point(67, 29);
            this.currentWindowHandle.Name = "currentWindowHandle";
            this.currentWindowHandle.ReadOnly = true;
            this.currentWindowHandle.Size = new System.Drawing.Size(169, 18);
            this.currentWindowHandle.TabIndex = 8;
            this.currentWindowHandle.Text = "1232139087";
            this.currentWindowHandle.WordWrap = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 253);
            this.Controls.Add(this.targetPicture);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpyDotNet";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox currentWindowClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentWindowText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copyCurrentHandle;
        private System.Windows.Forms.Button copyCurrentClass;
        private System.Windows.Forms.Button copyCurrentText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button copyParentClass;
        private System.Windows.Forms.Button copyParentText;
        private System.Windows.Forms.Button copyParentHandle;
        private System.Windows.Forms.TextBox parentWindowClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox parentWindowText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox parentWindowHandle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox targetPicture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox currentWindowHandle;
    }
}

