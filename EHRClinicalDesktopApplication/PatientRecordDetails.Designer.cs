namespace EHRClinicalDesktopApplication
{
    partial class PatientRecordDetails
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
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.dateValue = new System.Windows.Forms.Label();
            this.patientValue = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.doctorValue = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.templateNameValue = new System.Windows.Forms.Label();
            this.lblTemplateName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(40, 94);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(33, 13);
            this.lblCreatedAt.TabIndex = 1;
            this.lblCreatedAt.Text = "Data:";
            // 
            // dateValue
            // 
            this.dateValue.AutoSize = true;
            this.dateValue.Location = new System.Drawing.Point(79, 94);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(33, 13);
            this.dateValue.TabIndex = 2;
            this.dateValue.Text = "value";
            // 
            // patientValue
            // 
            this.patientValue.AutoSize = true;
            this.patientValue.Location = new System.Drawing.Point(272, 94);
            this.patientValue.Name = "patientValue";
            this.patientValue.Size = new System.Drawing.Size(33, 13);
            this.patientValue.TabIndex = 4;
            this.patientValue.Text = "value";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(215, 94);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(52, 13);
            this.lblPatient.TabIndex = 3;
            this.lblPatient.Text = "Paciente:";
            // 
            // doctorValue
            // 
            this.doctorValue.AutoSize = true;
            this.doctorValue.Location = new System.Drawing.Point(97, 123);
            this.doctorValue.Name = "doctorValue";
            this.doctorValue.Size = new System.Drawing.Size(33, 13);
            this.doctorValue.TabIndex = 6;
            this.doctorValue.Text = "value";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(40, 123);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(45, 13);
            this.lblDoctor.TabIndex = 5;
            this.lblDoctor.Text = "Médico:";
            // 
            // templateNameValue
            // 
            this.templateNameValue.AutoSize = true;
            this.templateNameValue.Location = new System.Drawing.Point(166, 170);
            this.templateNameValue.Name = "templateNameValue";
            this.templateNameValue.Size = new System.Drawing.Size(33, 13);
            this.templateNameValue.TabIndex = 8;
            this.templateNameValue.Text = "value";
            // 
            // lblTemplateName
            // 
            this.lblTemplateName.AutoSize = true;
            this.lblTemplateName.Location = new System.Drawing.Point(40, 170);
            this.lblTemplateName.Name = "lblTemplateName";
            this.lblTemplateName.Size = new System.Drawing.Size(120, 13);
            this.lblTemplateName.TabIndex = 7;
            this.lblTemplateName.Text = "Consulta/procedimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Detalhes de consultas/procedimentos realizados";
            // 
            // PatientRecordDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(564, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.templateNameValue);
            this.Controls.Add(this.lblTemplateName);
            this.Controls.Add(this.doctorValue);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.patientValue);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.lblCreatedAt);
            this.Name = "PatientRecordDetails";
            this.Text = "PatientRecordDetails";
            this.Load += new System.EventHandler(this.PatientRecordDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label dateValue;
        private System.Windows.Forms.Label patientValue;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label doctorValue;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label templateNameValue;
        private System.Windows.Forms.Label lblTemplateName;
        private System.Windows.Forms.Label label1;
    }
}