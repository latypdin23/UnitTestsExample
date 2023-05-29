namespace TaskManager
{
    partial class TaskForm
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
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCardTask = new System.Windows.Forms.Label();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbInitiator = new System.Windows.Forms.ComboBox();
            this.employerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbIspolnitel = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.lvlDateStart = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblInitiator = new System.Windows.Forms.Label();
            this.lblIspolnitel = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu.Controls.Add(this.btnSave);
            this.menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menu.Location = new System.Drawing.Point(0, 385);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(454, 55);
            this.menu.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 14);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCardTask
            // 
            this.lblCardTask.AutoSize = true;
            this.lblCardTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCardTask.Location = new System.Drawing.Point(124, 18);
            this.lblCardTask.Name = "lblCardTask";
            this.lblCardTask.Size = new System.Drawing.Size(135, 16);
            this.lblCardTask.TabIndex = 5;
            this.lblCardTask.Text = "Карточка задачи";
            // 
            // cmbProjects
            // 
            this.cmbProjects.DataSource = this.projectBindingSource;
            this.cmbProjects.DisplayMember = "Name";
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(163, 51);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(279, 24);
            this.cmbProjects.TabIndex = 6;
            this.cmbProjects.ValueMember = "Id";
            this.cmbProjects.SelectedIndexChanged += new System.EventHandler(this.cmbProjects_SelectedIndexChanged);
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(TaskManager.Model.Project);
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(163, 97);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(279, 22);
            this.dateStart.TabIndex = 7;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(163, 144);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(279, 22);
            this.dateEnd.TabIndex = 8;
            // 
            // cmbInitiator
            // 
            this.cmbInitiator.DataSource = this.employerBindingSource;
            this.cmbInitiator.DisplayMember = "GetFullName";
            this.cmbInitiator.FormattingEnabled = true;
            this.cmbInitiator.Location = new System.Drawing.Point(163, 187);
            this.cmbInitiator.Name = "cmbInitiator";
            this.cmbInitiator.Size = new System.Drawing.Size(279, 24);
            this.cmbInitiator.TabIndex = 9;
            this.cmbInitiator.ValueMember = "TabNum";
            // 
            // employerBindingSource
            // 
            this.employerBindingSource.DataSource = typeof(TaskManager.Employer);
            // 
            // cmbIspolnitel
            // 
            this.cmbIspolnitel.DataSource = this.employerBindingSource;
            this.cmbIspolnitel.DisplayMember = "GetFullName";
            this.cmbIspolnitel.FormattingEnabled = true;
            this.cmbIspolnitel.Location = new System.Drawing.Point(163, 236);
            this.cmbIspolnitel.Name = "cmbIspolnitel";
            this.cmbIspolnitel.Size = new System.Drawing.Size(279, 24);
            this.cmbIspolnitel.TabIndex = 10;
            this.cmbIspolnitel.ValueMember = "TabNum";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(163, 285);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(279, 77);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Text = "";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(12, 54);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(55, 16);
            this.lblProject.TabIndex = 12;
            this.lblProject.Text = "Проект";
            // 
            // lvlDateStart
            // 
            this.lvlDateStart.AutoSize = true;
            this.lvlDateStart.Location = new System.Drawing.Point(12, 102);
            this.lvlDateStart.Name = "lvlDateStart";
            this.lvlDateStart.Size = new System.Drawing.Size(90, 16);
            this.lvlDateStart.TabIndex = 13;
            this.lvlDateStart.Text = "Дата начала";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(9, 149);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(122, 16);
            this.lblDateEnd.TabIndex = 14;
            this.lblDateEnd.Text = "Дата завершения";
            // 
            // lblInitiator
            // 
            this.lblInitiator.AutoSize = true;
            this.lblInitiator.Location = new System.Drawing.Point(12, 195);
            this.lblInitiator.Name = "lblInitiator";
            this.lblInitiator.Size = new System.Drawing.Size(80, 16);
            this.lblInitiator.TabIndex = 15;
            this.lblInitiator.Text = "Инициатор";
            // 
            // lblIspolnitel
            // 
            this.lblIspolnitel.AutoSize = true;
            this.lblIspolnitel.Location = new System.Drawing.Point(12, 244);
            this.lblIspolnitel.Name = "lblIspolnitel";
            this.lblIspolnitel.Size = new System.Drawing.Size(94, 16);
            this.lblIspolnitel.TabIndex = 16;
            this.lblIspolnitel.Text = "Исполнитель";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 303);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 16);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Описание";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 440);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblIspolnitel);
            this.Controls.Add(this.lblInitiator);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.lvlDateStart);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbIspolnitel);
            this.Controls.Add(this.cmbInitiator);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.lblCardTask);
            this.Controls.Add(this.menu);
            this.Name = "TaskForm";
            this.Text = "Карточка задачи";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCardTask;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.ComboBox cmbInitiator;
        private System.Windows.Forms.ComboBox cmbIspolnitel;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lvlDateStart;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Label lblInitiator;
        private System.Windows.Forms.Label lblIspolnitel;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource employerBindingSource;
    }
}