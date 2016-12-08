namespace LabkaOOP
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.randomise = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.TextBox();
            this.a2 = new System.Windows.Forms.TextBox();
            this.b2 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.TextBox();
            this.c2 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.v2 = new System.Windows.Forms.TextBox();
            this.v1 = new System.Windows.Forms.TextBox();
            this.s2 = new System.Windows.Forms.TextBox();
            this.s1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.TextBox();
            this.errorKvadr1 = new Kvadratic.ErrorKvadr(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.c2);
            this.groupBox1.Controls.Add(this.c1);
            this.groupBox1.Controls.Add(this.b2);
            this.groupBox1.Controls.Add(this.b1);
            this.groupBox1.Controls.Add(this.a2);
            this.groupBox1.Controls.Add(this.a1);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.randomise);
            this.groupBox1.Location = new System.Drawing.Point(32, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель ввода";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.v2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.v1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.s2);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.s1);
            this.groupBox2.Controls.Add(this.p2);
            this.groupBox2.Controls.Add(this.p1);
            this.groupBox2.Location = new System.Drawing.Point(319, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты вычислений";
            // 
            // randomise
            // 
            this.randomise.Location = new System.Drawing.Point(6, 173);
            this.randomise.Name = "randomise";
            this.randomise.Size = new System.Drawing.Size(111, 34);
            this.randomise.TabIndex = 0;
            this.randomise.Text = "Рандомизировать";
            this.randomise.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(123, 173);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 34);
            this.add.TabIndex = 1;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(22, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(203, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Сравнение двух фигур";
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(39, 49);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(59, 20);
            this.a1.TabIndex = 2;
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(149, 49);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(59, 20);
            this.a2.TabIndex = 3;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(149, 78);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(59, 20);
            this.b2.TabIndex = 5;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(39, 78);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(59, 20);
            this.b1.TabIndex = 4;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(149, 104);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(59, 20);
            this.c2.TabIndex = 7;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(39, 104);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(59, 20);
            this.c1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "b";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Фигура 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Фигура 2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(4, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "c";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Фигура 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Фигура 1";
            // 
            // v2
            // 
            this.v2.Location = new System.Drawing.Point(166, 100);
            this.v2.Name = "v2";
            this.v2.ReadOnly = true;
            this.v2.Size = new System.Drawing.Size(59, 20);
            this.v2.TabIndex = 19;
            // 
            // v1
            // 
            this.v1.Location = new System.Drawing.Point(56, 100);
            this.v1.Name = "v1";
            this.v1.ReadOnly = true;
            this.v1.Size = new System.Drawing.Size(59, 20);
            this.v1.TabIndex = 18;
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(166, 74);
            this.s2.Name = "s2";
            this.s2.ReadOnly = true;
            this.s2.Size = new System.Drawing.Size(59, 20);
            this.s2.TabIndex = 17;
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(56, 74);
            this.s1.Name = "s1";
            this.s1.ReadOnly = true;
            this.s1.Size = new System.Drawing.Size(59, 20);
            this.s1.TabIndex = 16;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(166, 45);
            this.p2.Name = "p2";
            this.p2.ReadOnly = true;
            this.p2.Size = new System.Drawing.Size(59, 20);
            this.p2.TabIndex = 15;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(56, 45);
            this.p1.Name = "p1";
            this.p1.ReadOnly = true;
            this.p1.Size = new System.Drawing.Size(59, 20);
            this.p1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox c2;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.TextBox b2;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.TextBox a2;
        private System.Windows.Forms.TextBox a1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button randomise;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox v2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox v1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox s2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.TextBox p1;
        private Kvadratic.ErrorKvadr errorKvadr1;
    }
}

