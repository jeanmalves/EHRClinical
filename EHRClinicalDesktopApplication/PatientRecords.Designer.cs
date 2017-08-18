namespace EHRClinicalDesktopApplication
{
    partial class PatientRecords
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridPatientRecord = new System.Windows.Forms.DataGridView();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consulta_procedimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatientRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de consultas/procedimentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente:";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(81, 121);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(338, 20);
            this.textSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(429, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridPatientRecord
            // 
            this.dataGridPatientRecord.AllowUserToAddRows = false;
            this.dataGridPatientRecord.AllowUserToDeleteRows = false;
            this.dataGridPatientRecord.AllowUserToOrderColumns = true;
            this.dataGridPatientRecord.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridPatientRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPatientRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Data,
            this.Paciente,
            this.Consulta_procedimento});
            this.dataGridPatientRecord.Location = new System.Drawing.Point(27, 177);
            this.dataGridPatientRecord.MultiSelect = false;
            this.dataGridPatientRecord.Name = "dataGridPatientRecord";
            this.dataGridPatientRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPatientRecord.Size = new System.Drawing.Size(673, 150);
            this.dataGridPatientRecord.TabIndex = 22;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(624, 350);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 23;
            this.btnVisualizar.Text = "visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "CreatedAt";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Paciente
            // 
            this.Paciente.DataPropertyName = "Patient";
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.Width = 180;
            // 
            // Consulta_procedimento
            // 
            this.Consulta_procedimento.DataPropertyName = "OptName";
            this.Consulta_procedimento.HeaderText = "Consulta/procedimento";
            this.Consulta_procedimento.Name = "Consulta_procedimento";
            this.Consulta_procedimento.Width = 350;
            // 
            // PatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 403);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.dataGridPatientRecord);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PatientRecords";
            this.Text = "PatientRecords";
            this.Load += new System.EventHandler(this.PatientRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatientRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridPatientRecord;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consulta_procedimento;
    }
}