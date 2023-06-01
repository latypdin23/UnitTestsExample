namespace TaskManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panleUser = new System.Windows.Forms.Panel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabTasks = new System.Windows.Forms.TabPage();
            this.gridTasks = new System.Windows.Forms.DataGridView();
            this.menuTasks = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabEmployers = new System.Windows.Forms.TabPage();
            this.gridEmployers = new System.Windows.Forms.DataGridView();
            this.menuEmployers = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.делегироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Initiator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispolnitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabs.SuspendLayout();
            this.tabTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
            this.menuTasks.SuspendLayout();
            this.tabEmployers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployers)).BeginInit();
            this.menuEmployers.SuspendLayout();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panleUser
            // 
            this.panleUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panleUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panleUser.Location = new System.Drawing.Point(0, 0);
            this.panleUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panleUser.Name = "panleUser";
            this.panleUser.Size = new System.Drawing.Size(800, 46);
            this.panleUser.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabTasks);
            this.tabs.Controls.Add(this.tabEmployers);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 46);
            this.tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(800, 404);
            this.tabs.TabIndex = 1;
            // 
            // tabTasks
            // 
            this.tabTasks.Controls.Add(this.gridTasks);
            this.tabTasks.Controls.Add(this.menuTasks);
            this.tabTasks.Location = new System.Drawing.Point(4, 25);
            this.tabTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTasks.Size = new System.Drawing.Size(792, 375);
            this.tabTasks.TabIndex = 1;
            this.tabTasks.Text = "Задачи";
            this.tabTasks.UseVisualStyleBackColor = true;
            // 
            // gridTasks
            // 
            this.gridTasks.AutoGenerateColumns = false;
            this.gridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.project,
            this.Description,
            this.DateStart,
            this.DateEnd,
            this.Initiator,
            this.Ispolnitel,
            this.Status});
            this.gridTasks.ContextMenuStrip = this.contextMenu;
            this.gridTasks.DataSource = this.taskBindingSource;
            this.gridTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTasks.Location = new System.Drawing.Point(3, 30);
            this.gridTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridTasks.Name = "gridTasks";
            this.gridTasks.RowHeadersWidth = 51;
            this.gridTasks.RowTemplate.Height = 24;
            this.gridTasks.Size = new System.Drawing.Size(786, 343);
            this.gridTasks.TabIndex = 1;
            // 
            // menuTasks
            // 
            this.menuTasks.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.menuTasks.Location = new System.Drawing.Point(3, 2);
            this.menuTasks.Name = "menuTasks";
            this.menuTasks.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuTasks.Size = new System.Drawing.Size(786, 28);
            this.menuTasks.TabIndex = 0;
            this.menuTasks.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // tabEmployers
            // 
            this.tabEmployers.Controls.Add(this.gridEmployers);
            this.tabEmployers.Controls.Add(this.menuEmployers);
            this.tabEmployers.Location = new System.Drawing.Point(4, 25);
            this.tabEmployers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmployers.Name = "tabEmployers";
            this.tabEmployers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmployers.Size = new System.Drawing.Size(792, 375);
            this.tabEmployers.TabIndex = 0;
            this.tabEmployers.Text = "Сотрудники";
            this.tabEmployers.UseVisualStyleBackColor = true;
            // 
            // gridEmployers
            // 
            this.gridEmployers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmployers.Location = new System.Drawing.Point(3, 30);
            this.gridEmployers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridEmployers.Name = "gridEmployers";
            this.gridEmployers.RowHeadersWidth = 51;
            this.gridEmployers.RowTemplate.Height = 24;
            this.gridEmployers.Size = new System.Drawing.Size(786, 343);
            this.gridEmployers.TabIndex = 2;
            // 
            // menuEmployers
            // 
            this.menuEmployers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuEmployers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.просмотрToolStripMenuItem1});
            this.menuEmployers.Location = new System.Drawing.Point(3, 2);
            this.menuEmployers.Name = "menuEmployers";
            this.menuEmployers.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuEmployers.Size = new System.Drawing.Size(786, 28);
            this.menuEmployers.TabIndex = 0;
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(90, 24);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // просмотрToolStripMenuItem1
            // 
            this.просмотрToolStripMenuItem1.Name = "просмотрToolStripMenuItem1";
            this.просмотрToolStripMenuItem1.Size = new System.Drawing.Size(94, 24);
            this.просмотрToolStripMenuItem1.Text = "Просмотр";
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.делегироватьToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(176, 28);
            // 
            // делегироватьToolStripMenuItem
            // 
            this.делегироватьToolStripMenuItem.Name = "делегироватьToolStripMenuItem";
            this.делегироватьToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.делегироватьToolStripMenuItem.Text = "Делегировать";
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(TaskManager.Task);
            // 
            // project
            // 
            this.project.DataPropertyName = "project";
            this.project.HeaderText = "project";
            this.project.MinimumWidth = 6;
            this.project.Name = "project";
            this.project.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // DateStart
            // 
            this.DateStart.DataPropertyName = "DateStart";
            this.DateStart.HeaderText = "DateStart";
            this.DateStart.MinimumWidth = 6;
            this.DateStart.Name = "DateStart";
            this.DateStart.Width = 125;
            // 
            // DateEnd
            // 
            this.DateEnd.DataPropertyName = "DateEnd";
            this.DateEnd.HeaderText = "DateEnd";
            this.DateEnd.MinimumWidth = 6;
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Width = 125;
            // 
            // Initiator
            // 
            this.Initiator.DataPropertyName = "Initiator";
            this.Initiator.HeaderText = "Initiator";
            this.Initiator.MinimumWidth = 6;
            this.Initiator.Name = "Initiator";
            this.Initiator.Width = 125;
            // 
            // Ispolnitel
            // 
            this.Ispolnitel.DataPropertyName = "Ispolnitel";
            this.Ispolnitel.HeaderText = "Ispolnitel";
            this.Ispolnitel.MinimumWidth = 6;
            this.Ispolnitel.Name = "Ispolnitel";
            this.Ispolnitel.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.panleUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Менеджер задач";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabs.ResumeLayout(false);
            this.tabTasks.ResumeLayout(false);
            this.tabTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
            this.menuTasks.ResumeLayout(false);
            this.menuTasks.PerformLayout();
            this.tabEmployers.ResumeLayout(false);
            this.tabEmployers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployers)).EndInit();
            this.menuEmployers.ResumeLayout(false);
            this.menuEmployers.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panleUser;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabTasks;
        private System.Windows.Forms.DataGridView gridTasks;
        private System.Windows.Forms.MenuStrip menuTasks;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.TabPage tabEmployers;
        private System.Windows.Forms.MenuStrip menuEmployers;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem1;
        private System.Windows.Forms.DataGridView gridEmployers;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem делегироватьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Initiator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ispolnitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.BindingSource taskBindingSource;
    }
}

