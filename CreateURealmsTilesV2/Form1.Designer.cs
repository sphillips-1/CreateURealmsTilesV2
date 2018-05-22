﻿using System;
namespace CreateURealmsTilesV2
{
    partial class Form1
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
            this.textBox_gimpLocation = new System.Windows.Forms.TextBox();
            this.label_gimpLocation = new System.Windows.Forms.Label();
            this.textBox_imageLocation = new System.Windows.Forms.TextBox();
            this.button_getImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_gimpLocation
            // 
            this.textBox_gimpLocation.Location = new System.Drawing.Point(109, 60);
            this.textBox_gimpLocation.Name = "textBox_gimpLocation";
            this.textBox_gimpLocation.ReadOnly = true;
            this.textBox_gimpLocation.Size = new System.Drawing.Size(268, 20);
            this.textBox_gimpLocation.TabIndex = 0;
            // 
            // label_gimpLocation
            // 
            this.label_gimpLocation.AutoSize = true;
            this.label_gimpLocation.Location = new System.Drawing.Point(25, 63);
            this.label_gimpLocation.Name = "label_gimpLocation";
            this.label_gimpLocation.Size = new System.Drawing.Size(78, 13);
            this.label_gimpLocation.TabIndex = 1;
            this.label_gimpLocation.Text = "GIMP Location";
            // 
            // textBox_imageLocation
            // 
            this.textBox_imageLocation.Location = new System.Drawing.Point(109, 98);
            this.textBox_imageLocation.Name = "textBox_imageLocation";
            this.textBox_imageLocation.ReadOnly = true;
            this.textBox_imageLocation.Size = new System.Drawing.Size(268, 20);
            this.textBox_imageLocation.TabIndex = 2;
            // 
            // button_getImage
            // 
            this.button_getImage.Location = new System.Drawing.Point(28, 96);
            this.button_getImage.Name = "button_getImage";
            this.button_getImage.Size = new System.Drawing.Size(75, 23);
            this.button_getImage.TabIndex = 4;
            this.button_getImage.Text = "Get Image";
            this.button_getImage.UseVisualStyleBackColor = true;
            this.button_getImage.Click += new EventHandler(button_getImage_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_getImage);
            this.Controls.Add(this.textBox_imageLocation);
            this.Controls.Add(this.label_gimpLocation);
            this.Controls.Add(this.textBox_gimpLocation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void button_getImage_Click(object sender, EventArgs e)
        {
            string[] results = GetImagesLocation.ImagesLocation();
            textBox_imageLocation.Text = String.Join(", ", results);
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_gimpLocation;
        private System.Windows.Forms.Label label_gimpLocation;
        private System.Windows.Forms.TextBox textBox_imageLocation;
        private System.Windows.Forms.Button button_getImage;
    }
}

