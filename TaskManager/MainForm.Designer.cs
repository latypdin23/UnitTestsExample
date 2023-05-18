﻿namespace TaskManager
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
            this.panleUser = new System.Windows.Forms.Panel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabTasks = new System.Windows.Forms.TabPage();
            this.tabEmployers = new System.Windows.Forms.TabPage();
            this.menuTasks = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridTasks = new System.Windows.Forms.DataGridView();
            this.menuEmployers = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridEmployers = new System.Windows.Forms.DataGridView();
            this.tabs.SuspendLayout();
            this.tabTasks.SuspendLayout();
            this.tabEmployers.SuspendLayout();
            this.menuTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
            this.menuEmployers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployers)).BeginInit();
            this.SuspendLayout();
            // 
            // panleUser
            // 
            this.panleUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panleUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panleUser.Location = new System.Drawing.Point(0, 0);
            this.panleUser.Name = "panleUser";
            this.panleUser.Size = new System.Drawing.Size(800, 51);
            this.panleUser.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabTasks);
            this.tabs.Controls.Add(this.tabEmployers);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 51);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(800, 399);
            this.tabs.TabIndex = 1;
            // 
            // tabTasks
            // 
            this.tabTasks.Controls.Add(this.gridTasks);
            this.tabTasks.Controls.Add(this.menuTasks);
            this.tabTasks.Location = new System.Drawing.Point(4, 25);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabTasks.Size = new System.Drawing.Size(792, 370);
            this.tabTasks.TabIndex = 1;
            this.tabTasks.Text = "Задачи";
            this.tabTasks.UseVisualStyleBackColor = true;
            // 
            // tabEmployers
            // 
            this.tabEmployers.Controls.Add(this.gridEmployers);
            this.tabEmployers.Controls.Add(this.menuEmployers);
            this.tabEmployers.Location = new System.Drawing.Point(4, 25);
            this.tabEmployers.Name = "tabEmployers";
            this.tabEmployers.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployers.Size = new System.Drawing.Size(792, 370);
            this.tabEmployers.TabIndex = 0;
            this.tabEmployers.Text = "Сотрудники";
            this.tabEmployers.UseVisualStyleBackColor = true;
            // 
            // menuTasks
            // 
            this.menuTasks.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.menuTasks.Location = new System.Drawing.Point(3, 3);
            this.menuTasks.Name = "menuTasks";
            this.menuTasks.Size = new System.Drawing.Size(786, 28);
            this.menuTasks.TabIndex = 0;
            this.menuTasks.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // gridTasks
            // 
            this.gridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTasks.Location = new System.Drawing.Point(3, 31);
            this.gridTasks.Name = "gridTasks";
            this.gridTasks.RowHeadersWidth = 51;
            this.gridTasks.RowTemplate.Height = 24;
            this.gridTasks.Size = new System.Drawing.Size(786, 336);
            this.gridTasks.TabIndex = 1;
            // 
            // menuEmployers
            // 
            this.menuEmployers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuEmployers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.просмотрToolStripMenuItem1});
            this.menuEmployers.Location = new System.Drawing.Point(3, 3);
            this.menuEmployers.Name = "menuEmployers";
            this.menuEmployers.Size = new System.Drawing.Size(786, 30);
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
            // gridEmployers
            // 
            this.gridEmployers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmployers.Location = new System.Drawing.Point(3, 33);
            this.gridEmployers.Name = "gridEmployers";
            this.gridEmployers.RowHeadersWidth = 51;
            this.gridEmployers.RowTemplate.Height = 24;
            this.gridEmployers.Size = new System.Drawing.Size(786, 334);
            this.gridEmployers.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.panleUser);
            this.Name = "MainForm";
            this.Text = "Менеджер задач";
            this.tabs.ResumeLayout(false);
            this.tabTasks.ResumeLayout(false);
            this.tabTasks.PerformLayout();
            this.tabEmployers.ResumeLayout(false);
            this.tabEmployers.PerformLayout();
            this.menuTasks.ResumeLayout(false);
            this.menuTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
            this.menuEmployers.ResumeLayout(false);
            this.menuEmployers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployers)).EndInit();
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
        private System.Windows.Forms.DataGridView gridEmployers;
        private System.Windows.Forms.MenuStrip menuEmployers;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem1;
    }
}
