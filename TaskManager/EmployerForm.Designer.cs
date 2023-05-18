namespace TaskManager
{
    partial class EmployerForm
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
            this.menu = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTabNum = new System.Windows.Forms.Label();
            this.lblCardEmployer = new System.Windows.Forms.Label();
            this.txtTabNum = new System.Windows.Forms.MaskedTextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.cmbDepaertment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu.Controls.Add(this.btnSave);
            this.menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menu.Location = new System.Drawing.Point(0, 296);
            this.menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(313, 45);
            this.menu.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 24);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(7, 93);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(56, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Фамилия";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 132);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Имя";
            // 
            // lblTabNum
            // 
            this.lblTabNum.AutoSize = true;
            this.lblTabNum.Location = new System.Drawing.Point(7, 49);
            this.lblTabNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTabNum.Name = "lblTabNum";
            this.lblTabNum.Size = new System.Drawing.Size(99, 13);
            this.lblTabNum.TabIndex = 3;
            this.lblTabNum.Text = "Табельный номер";
            // 
            // lblCardEmployer
            // 
            this.lblCardEmployer.AutoSize = true;
            this.lblCardEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCardEmployer.Location = new System.Drawing.Point(88, 15);
            this.lblCardEmployer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardEmployer.Name = "lblCardEmployer";
            this.lblCardEmployer.Size = new System.Drawing.Size(134, 13);
            this.lblCardEmployer.TabIndex = 4;
            this.lblCardEmployer.Text = "Карточка сотрудника";
            // 
            // txtTabNum
            // 
            this.txtTabNum.Location = new System.Drawing.Point(122, 46);
            this.txtTabNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTabNum.Name = "txtTabNum";
            this.txtTabNum.Size = new System.Drawing.Size(182, 20);
            this.txtTabNum.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(122, 88);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(182, 20);
            this.txtSurname.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 167);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(7, 171);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(86, 13);
            this.lblDateOfBirth.TabIndex = 9;
            this.lblDateOfBirth.Text = "Дата рождения";
            // 
            // cmbDepaertment
            // 
            this.cmbDepaertment.FormattingEnabled = true;
            this.cmbDepaertment.Location = new System.Drawing.Point(124, 205);
            this.cmbDepaertment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDepaertment.Name = "cmbDepaertment";
            this.cmbDepaertment.Size = new System.Drawing.Size(181, 21);
            this.cmbDepaertment.TabIndex = 10;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(7, 211);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(41, 13);
            this.lblDepartment.TabIndex = 11;
            this.lblDepartment.Text = "Отдел ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 125);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 12;
            // 
            // EmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 341);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.cmbDepaertment);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtTabNum);
            this.Controls.Add(this.lblCardEmployer);
            this.Controls.Add(this.lblTabNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.menu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployerForm";
            this.Text = "Сотрудник";
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTabNum;
        private System.Windows.Forms.Label lblCardEmployer;
        private System.Windows.Forms.MaskedTextBox txtTabNum;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.ComboBox cmbDepaertment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtName;
    }
}