namespace EHRClinicalDesktopApplication
{
    partial class FormDoctor
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBirth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.textCRM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(221, 420);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(129, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Gravar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(129, 352);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(151, 20);
            this.textPassword.TabIndex = 53;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Senha:";
            // 
            // textEmail
            // 
            this.textEmail.Enabled = false;
            this.textEmail.Location = new System.Drawing.Point(129, 318);
            this.textEmail.Name = "textEmail";
            this.textEmail.ReadOnly = true;
            this.textEmail.Size = new System.Drawing.Size(282, 20);
            this.textEmail.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Email:";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(129, 107);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(282, 20);
            this.textFirstName.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Dados do Usuário";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(129, 142);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(282, 20);
            this.textLastName.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Sobrenome:";
            // 
            // textBirth
            // 
            this.textBirth.Location = new System.Drawing.Point(130, 176);
            this.textBirth.Name = "textBirth";
            this.textBirth.Size = new System.Drawing.Size(151, 20);
            this.textBirth.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Data de nasc.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Sexo:";
            // 
            // SexComboBox
            // 
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Location = new System.Drawing.Point(130, 210);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(151, 21);
            this.SexComboBox.TabIndex = 66;
            // 
            // textCRM
            // 
            this.textCRM.Location = new System.Drawing.Point(131, 245);
            this.textCRM.Name = "textCRM";
            this.textCRM.PasswordChar = '*';
            this.textCRM.Size = new System.Drawing.Size(151, 20);
            this.textCRM.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "CRM nº.:";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(129, 282);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(282, 20);
            this.textUserName.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Username:";
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 463);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textCRM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SexComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBirth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "FormDoctor";
            this.Text = "Dados do usuário";
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBirth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.TextBox textCRM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label label9;
    }
}