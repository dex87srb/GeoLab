using System;

namespace GeoLab
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.searchTXT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.searchFolder = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTXT
            // 
            this.searchTXT.Location = new System.Drawing.Point(227, 98);
            this.searchTXT.Name = "searchTXT";
            this.searchTXT.Size = new System.Drawing.Size(99, 22);
            this.searchTXT.TabIndex = 0;
            this.searchTXT.Text = "Open .txt file";
            this.searchTXT.UseVisualStyleBackColor = true;
            this.searchTXT.Click += new System.EventHandler(this.SearchTXT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Forward_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Backward_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 142);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(642, 167);
            this.webBrowser1.TabIndex = 5;
            // 
            // searchFolder
            // 
            this.searchFolder.Location = new System.Drawing.Point(122, 98);
            this.searchFolder.Name = "searchFolder";
            this.searchFolder.Size = new System.Drawing.Size(99, 22);
            this.searchFolder.TabIndex = 6;
            this.searchFolder.Text = "Open folder";
            this.searchFolder.UseVisualStyleBackColor = true;
            this.searchFolder.Click += new System.EventHandler(this.SearchFolder_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(122, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(309, 80);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 22);
            this.button3.TabIndex = 7;
            this.button3.Text = "Convert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Convert_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(523, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 53);
            this.button4.TabIndex = 8;
            this.button4.Text = "Get Coordinates and Height";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Coordinates);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(159, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 80);
            this.label1.TabIndex = 9;
            this.label1.Text = "Use open folder button to access textual files which selected\r\nfolder may contain" +
    ". \r\nUse convert button for file conversion of x,y coordinates and height\r\nfrom t" +
    "extual to .xls file format\r\n ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchFolder);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTXT);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Converter";
            this.Text = "GeoLab";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Button searchTXT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button searchFolder;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

