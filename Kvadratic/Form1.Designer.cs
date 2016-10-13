namespace Kvadratic
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
            this.components = new System.ComponentModel.Container();
            this.x2 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            this.cBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aBox = new System.Windows.Forms.TextBox();
            this.ErrorBox = new System.Windows.Forms.Label();
            this.errorKvadr1 = new Kvadratic.ErrorKvadr(this.components);
            this.SuspendLayout();
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Location = new System.Drawing.Point(151, 143);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(0, 13);
            this.x2.TabIndex = 19;
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Location = new System.Drawing.Point(151, 122);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(0, 13);
            this.x1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "x2 = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "x1 = ";
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(113, 179);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(194, 55);
            this.ResultButton.TabIndex = 15;
            this.ResultButton.Text = "Ответ";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(302, 56);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(80, 20);
            this.cBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "*X+";
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(174, 56);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(92, 20);
            this.bBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "X²+";
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(38, 57);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(101, 20);
            this.aBox.TabIndex = 10;
            // 
            // ErrorBox
            // 
            this.ErrorBox.AutoEllipsis = true;
            this.ErrorBox.AutoSize = true;
            this.ErrorBox.CausesValidation = false;
            this.ErrorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorBox.Location = new System.Drawing.Point(49, 90);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(0, 16);
            this.ErrorBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 262);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x2;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.Label ErrorBox;
        private ErrorKvadr errorKvadr1;
    }
}

