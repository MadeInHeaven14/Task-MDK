﻿namespace Task4
{
    partial class Form1
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
            this.btn_Sum = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.tb_Sum = new System.Windows.Forms.TextBox();
            this.tb_Product = new System.Windows.Forms.TextBox();
            this.tb_Max = new System.Windows.Forms.TextBox();
            this.tb_Min = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Sum
            // 
            this.btn_Sum.Location = new System.Drawing.Point(76, 48);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(154, 71);
            this.btn_Sum.TabIndex = 0;
            this.btn_Sum.Text = "Сумма";
            this.btn_Sum.UseVisualStyleBackColor = true;
            this.btn_Sum.Click += new System.EventHandler(this.btn_Sum_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.Location = new System.Drawing.Point(76, 147);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(154, 71);
            this.btn_Product.TabIndex = 1;
            this.btn_Product.Text = "Произведение";
            this.btn_Product.UseVisualStyleBackColor = true;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.Location = new System.Drawing.Point(76, 244);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(154, 71);
            this.btn_Max.TabIndex = 2;
            this.btn_Max.Text = "Максимум";
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.Location = new System.Drawing.Point(76, 345);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(154, 71);
            this.btn_Min.TabIndex = 3;
            this.btn_Min.Text = "Минимум";
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // tb_Sum
            // 
            this.tb_Sum.Location = new System.Drawing.Point(311, 72);
            this.tb_Sum.Name = "tb_Sum";
            this.tb_Sum.ReadOnly = true;
            this.tb_Sum.Size = new System.Drawing.Size(154, 22);
            this.tb_Sum.TabIndex = 4;
            // 
            // tb_Product
            // 
            this.tb_Product.Location = new System.Drawing.Point(311, 171);
            this.tb_Product.Name = "tb_Product";
            this.tb_Product.ReadOnly = true;
            this.tb_Product.Size = new System.Drawing.Size(154, 22);
            this.tb_Product.TabIndex = 5;
            // 
            // tb_Max
            // 
            this.tb_Max.Location = new System.Drawing.Point(311, 268);
            this.tb_Max.Name = "tb_Max";
            this.tb_Max.ReadOnly = true;
            this.tb_Max.Size = new System.Drawing.Size(154, 22);
            this.tb_Max.TabIndex = 6;
            // 
            // tb_Min
            // 
            this.tb_Min.Location = new System.Drawing.Point(311, 369);
            this.tb_Min.Name = "tb_Min";
            this.tb_Min.ReadOnly = true;
            this.tb_Min.Size = new System.Drawing.Size(154, 22);
            this.tb_Min.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.tb_Min);
            this.Controls.Add(this.tb_Max);
            this.Controls.Add(this.tb_Product);
            this.Controls.Add(this.tb_Sum);
            this.Controls.Add(this.btn_Min);
            this.Controls.Add(this.btn_Max);
            this.Controls.Add(this.btn_Product);
            this.Controls.Add(this.btn_Sum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.TextBox tb_Sum;
        private System.Windows.Forms.TextBox tb_Product;
        private System.Windows.Forms.TextBox tb_Max;
        private System.Windows.Forms.TextBox tb_Min;
    }
}

