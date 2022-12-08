namespace IS_Dynamic_Image_Processing
{
    partial class ImageProcessor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadedImage = new System.Windows.Forms.PictureBox();
            this.processedImage = new System.Windows.Forms.PictureBox();
            this.basicCopy = new System.Windows.Forms.Button();
            this.greyScale = new System.Windows.Forms.Button();
            this.colorInversion = new System.Windows.Forms.Button();
            this.sepia = new System.Windows.Forms.Button();
            this.histogram = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // loadedImage
            // 
            this.loadedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadedImage.Location = new System.Drawing.Point(35, 79);
            this.loadedImage.Name = "loadedImage";
            this.loadedImage.Size = new System.Drawing.Size(299, 284);
            this.loadedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadedImage.TabIndex = 1;
            this.loadedImage.TabStop = false;
            // 
            // processedImage
            // 
            this.processedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedImage.Location = new System.Drawing.Point(361, 79);
            this.processedImage.Name = "processedImage";
            this.processedImage.Size = new System.Drawing.Size(299, 284);
            this.processedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processedImage.TabIndex = 1;
            this.processedImage.TabStop = false;
            // 
            // basicCopy
            // 
            this.basicCopy.Enabled = false;
            this.basicCopy.Location = new System.Drawing.Point(685, 120);
            this.basicCopy.Name = "basicCopy";
            this.basicCopy.Size = new System.Drawing.Size(119, 23);
            this.basicCopy.TabIndex = 3;
            this.basicCopy.Text = "Basic Copy";
            this.basicCopy.UseVisualStyleBackColor = true;
            this.basicCopy.Click += new System.EventHandler(this.basicCopy_Click);
            // 
            // greyScale
            // 
            this.greyScale.Enabled = false;
            this.greyScale.Location = new System.Drawing.Point(685, 149);
            this.greyScale.Name = "greyScale";
            this.greyScale.Size = new System.Drawing.Size(119, 24);
            this.greyScale.TabIndex = 4;
            this.greyScale.Text = "Greyscale";
            this.greyScale.UseVisualStyleBackColor = true;
            this.greyScale.Click += new System.EventHandler(this.greyScale_Click);
            // 
            // colorInversion
            // 
            this.colorInversion.Enabled = false;
            this.colorInversion.Location = new System.Drawing.Point(685, 179);
            this.colorInversion.Name = "colorInversion";
            this.colorInversion.Size = new System.Drawing.Size(119, 24);
            this.colorInversion.TabIndex = 5;
            this.colorInversion.Text = "Color Inversion";
            this.colorInversion.UseVisualStyleBackColor = true;
            this.colorInversion.Click += new System.EventHandler(this.colorInversion_Click);
            // 
            // sepia
            // 
            this.sepia.Enabled = false;
            this.sepia.Location = new System.Drawing.Point(685, 209);
            this.sepia.Name = "sepia";
            this.sepia.Size = new System.Drawing.Size(119, 24);
            this.sepia.TabIndex = 6;
            this.sepia.Text = "Sepia";
            this.sepia.UseVisualStyleBackColor = true;
            this.sepia.Click += new System.EventHandler(this.sepia_Click);
            // 
            // histogram
            // 
            this.histogram.Enabled = false;
            this.histogram.Location = new System.Drawing.Point(685, 239);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(119, 24);
            this.histogram.TabIndex = 7;
            this.histogram.Text = "Histogram";
            this.histogram.UseVisualStyleBackColor = true;
            this.histogram.Click += new System.EventHandler(this.histogram_Click);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(685, 296);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(119, 23);
            this.subtraction.TabIndex = 8;
            this.subtraction.Text = "Subtraction";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(685, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Processes";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(107, 379);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Loaded Image";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(448, 379);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Processed Image";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // ImageProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.histogram);
            this.Controls.Add(this.sepia);
            this.Controls.Add(this.colorInversion);
            this.Controls.Add(this.greyScale);
            this.Controls.Add(this.basicCopy);
            this.Controls.Add(this.processedImage);
            this.Controls.Add(this.loadedImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ImageProcessor";
            this.Text = "Dynamic Image Processor";
            this.Load += new System.EventHandler(this.ImageProcessor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox loadedImage;
        private System.Windows.Forms.PictureBox processedImage;
        private System.Windows.Forms.Button basicCopy;
        private System.Windows.Forms.Button greyScale;
        private System.Windows.Forms.Button colorInversion;
        private System.Windows.Forms.Button sepia;
        private System.Windows.Forms.Button histogram;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

    }
}

