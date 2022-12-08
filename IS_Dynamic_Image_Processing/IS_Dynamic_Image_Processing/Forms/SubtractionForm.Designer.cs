namespace ImageProcessor
{
    partial class SubtractionForm
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
            this.loadPicture = new System.Windows.Forms.PictureBox();
            this.loadBg = new System.Windows.Forms.PictureBox();
            this.processedPicture = new System.Windows.Forms.PictureBox();
            this.LoadImage = new System.Windows.Forms.Button();
            this.LoadBackground = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenBackgroundDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.loadPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadPicture
            // 
            this.loadPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadPicture.Location = new System.Drawing.Point(29, 48);
            this.loadPicture.Name = "loadPicture";
            this.loadPicture.Size = new System.Drawing.Size(299, 284);
            this.loadPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadPicture.TabIndex = 2;
            this.loadPicture.TabStop = false;
            // 
            // loadBg
            // 
            this.loadBg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadBg.Location = new System.Drawing.Point(394, 48);
            this.loadBg.Name = "loadBg";
            this.loadBg.Size = new System.Drawing.Size(299, 284);
            this.loadBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadBg.TabIndex = 3;
            this.loadBg.TabStop = false;
            // 
            // processedPicture
            // 
            this.processedPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedPicture.Location = new System.Drawing.Point(760, 48);
            this.processedPicture.Name = "processedPicture";
            this.processedPicture.Size = new System.Drawing.Size(299, 284);
            this.processedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processedPicture.TabIndex = 4;
            this.processedPicture.TabStop = false;
            // 
            // LoadImage
            // 
            this.LoadImage.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoadImage.Location = new System.Drawing.Point(119, 357);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(102, 32);
            this.LoadImage.TabIndex = 16;
            this.LoadImage.Text = "Load Image";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // LoadBackground
            // 
            this.LoadBackground.Enabled = false;
            this.LoadBackground.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBackground.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoadBackground.Location = new System.Drawing.Point(466, 357);
            this.LoadBackground.Name = "LoadBackground";
            this.LoadBackground.Size = new System.Drawing.Size(145, 32);
            this.LoadBackground.TabIndex = 17;
            this.LoadBackground.Text = "Load Background";
            this.LoadBackground.UseVisualStyleBackColor = true;
            this.LoadBackground.Click += new System.EventHandler(this.LoadBackground_Click);
            // 
            // Subtract
            // 
            this.Subtract.Enabled = false;
            this.Subtract.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Subtract.Location = new System.Drawing.Point(860, 357);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(102, 32);
            this.Subtract.TabIndex = 18;
            this.Subtract.Text = "Subtract";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // OpenImageDialog
            // 
            this.OpenImageDialog.FileName = "openFileDialog1";
            this.OpenImageDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenImageDialog_FileOk);
            // 
            // OpenBackgroundDialog
            // 
            this.OpenBackgroundDialog.FileName = "openFileDialog1";
            this.OpenBackgroundDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenBackgroundDialog_FileOk);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // SubtractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 411);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.LoadBackground);
            this.Controls.Add(this.LoadImage);
            this.Controls.Add(this.processedPicture);
            this.Controls.Add(this.loadBg);
            this.Controls.Add(this.loadPicture);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SubtractionForm";
            this.Text = "SubtractionForm";
            ((System.ComponentModel.ISupportInitialize)(this.loadPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loadPicture;
        private System.Windows.Forms.PictureBox loadBg;
        private System.Windows.Forms.PictureBox processedPicture;
        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.Button LoadBackground;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenImageDialog;
        private System.Windows.Forms.OpenFileDialog OpenBackgroundDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}