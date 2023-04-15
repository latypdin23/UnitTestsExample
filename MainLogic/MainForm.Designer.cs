
namespace MainLogic
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
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(66, 12);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 0;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(66, 48);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 1;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(9, 15);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(46, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Ширина";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(9, 51);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "Длина";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(20, 91);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(60, 13);
            this.lblS.TabIndex = 4;
            this.lblS.Text = "Площадь: ";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(151, 91);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(64, 13);
            this.lblP.TabIndex = 5;
            this.lblP.Text = "Периметр: ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(208, 15);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(76, 91);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(13, 13);
            this.S.TabIndex = 7;
            this.S.Text = "0";
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Location = new System.Drawing.Point(221, 91);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(13, 13);
            this.P.TabIndex = 8;
            this.P.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 142);
            this.Controls.Add(this.P);
            this.Controls.Add(this.S);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label P;
    }
}

