﻿namespace EHRClinicalDesktopApplication
{
    partial class MainForm
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
            this.menuLoged = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // menuLoged
            // 
            this.menuLoged.Location = new System.Drawing.Point(0, 0);
            this.menuLoged.Name = "menuLoged";
            this.menuLoged.Size = new System.Drawing.Size(873, 24);
            this.menuLoged.TabIndex = 1;
            this.menuLoged.Text = "menuStrip1";
            this.menuLoged.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 488);
            this.Controls.Add(this.menuLoged);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuLoged;
            this.Name = "MainForm";
            this.Text = "EHRClinical";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuLoged;
    }
}