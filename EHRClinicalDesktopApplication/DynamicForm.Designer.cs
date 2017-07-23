namespace EHRClinicalDesktopApplication
{
    partial class DynamicForm
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
            this.lblPatient = new System.Windows.Forms.Label();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(39, 70);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(52, 13);
            this.lblPatient.TabIndex = 0;
            this.lblPatient.Text = "Paciente:";
            this.lblPatient.UseWaitCursor = true;
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.DisplayMember = "Id";
            this.comboBoxPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(149, 70);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(336, 21);
            this.comboBoxPatient.TabIndex = 1;
            this.comboBoxPatient.UseWaitCursor = true;
            this.comboBoxPatient.ValueMember = "Id";
            // 
            // DynamicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(687, 293);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.lblPatient);
            this.Name = "DynamicForm";
            this.Text = "DynamicForm";
            this.Load += new System.EventHandler(this.DynamicForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox comboBoxPatient;
    }
}