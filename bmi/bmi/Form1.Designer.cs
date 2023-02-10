namespace bmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.x = new System.Windows.Forms.Label();
            this.рост = new System.Windows.Forms.TextBox();
            this.вес = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.stepen = new System.Windows.Forms.Label();
            this.ind = new System.Windows.Forms.Label();
            this.l44 = new System.Windows.Forms.Label();
            this.l33 = new System.Windows.Forms.Label();
            this.l22 = new System.Windows.Forms.Label();
            this.l11 = new System.Windows.Forms.Label();
            this.ld = new System.Windows.Forms.Label();
            this.lc = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.PictureBox();
            this.instr2 = new System.Windows.Forms.Label();
            this.instr1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x.ForeColor = System.Drawing.SystemColors.Desktop;
            this.x.Location = new System.Drawing.Point(811, 383);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(123, 43);
            this.x.TabIndex = 0;
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // рост
            // 
            this.рост.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.рост.Location = new System.Drawing.Point(192, 343);
            this.рост.Multiline = true;
            this.рост.Name = "рост";
            this.рост.Size = new System.Drawing.Size(119, 40);
            this.рост.TabIndex = 1;
            // 
            // вес
            // 
            this.вес.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.вес.Location = new System.Drawing.Point(192, 393);
            this.вес.Multiline = true;
            this.вес.Name = "вес";
            this.вес.Size = new System.Drawing.Size(119, 40);
            this.вес.TabIndex = 2;
            this.вес.TextChanged += new System.EventHandler(this.вес_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Рост:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(102, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вес:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(397, 422);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(561, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // stepen
            // 
            this.stepen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stepen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.stepen.Location = new System.Drawing.Point(416, 481);
            this.stepen.Name = "stepen";
            this.stepen.Size = new System.Drawing.Size(533, 43);
            this.stepen.TabIndex = 8;
            this.stepen.Text = "степень ожирения";
            this.stepen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stepen.Click += new System.EventHandler(this.stepen_Click);
            // 
            // ind
            // 
            this.ind.AutoSize = true;
            this.ind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ind.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ind.Location = new System.Drawing.Point(432, 383);
            this.ind.Name = "ind";
            this.ind.Size = new System.Drawing.Size(359, 32);
            this.ind.TabIndex = 10;
            this.ind.Text = "Ваш индекс массы тела = ";
            // 
            // l44
            // 
            this.l44.AutoSize = true;
            this.l44.Font = new System.Drawing.Font("Verdana", 10.15F);
            this.l44.Location = new System.Drawing.Point(792, 277);
            this.l44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l44.Name = "l44";
            this.l44.Size = new System.Drawing.Size(100, 20);
            this.l44.TabIndex = 55;
            this.l44.Text = "Ожирение";
            // 
            // l33
            // 
            this.l33.AutoSize = true;
            this.l33.Font = new System.Drawing.Font("Verdana", 10.15F);
            this.l33.Location = new System.Drawing.Point(792, 246);
            this.l33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l33.Name = "l33";
            this.l33.Size = new System.Drawing.Size(118, 20);
            this.l33.TabIndex = 54;
            this.l33.Text = "Избыточный";
            // 
            // l22
            // 
            this.l22.AutoSize = true;
            this.l22.Font = new System.Drawing.Font("Verdana", 10.15F);
            this.l22.Location = new System.Drawing.Point(792, 213);
            this.l22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l22.Name = "l22";
            this.l22.Size = new System.Drawing.Size(96, 20);
            this.l22.TabIndex = 53;
            this.l22.Text = "Здоровый";
            // 
            // l11
            // 
            this.l11.AutoSize = true;
            this.l11.Font = new System.Drawing.Font("Verdana", 10.15F);
            this.l11.Location = new System.Drawing.Point(792, 183);
            this.l11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(144, 20);
            this.l11.TabIndex = 52;
            this.l11.Text = "Недостаточный";
            // 
            // ld
            // 
            this.ld.BackColor = System.Drawing.Color.Red;
            this.ld.Location = new System.Drawing.Point(747, 462);
            this.ld.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ld.Name = "ld";
            this.ld.Size = new System.Drawing.Size(202, 16);
            this.ld.TabIndex = 51;
            // 
            // lc
            // 
            this.lc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lc.Location = new System.Drawing.Point(681, 462);
            this.lc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lc.Name = "lc";
            this.lc.Size = new System.Drawing.Size(146, 16);
            this.lc.TabIndex = 50;
            // 
            // lb
            // 
            this.lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lb.Location = new System.Drawing.Point(612, 462);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(79, 16);
            this.lb.TabIndex = 49;
            // 
            // la
            // 
            this.la.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.la.Location = new System.Drawing.Point(413, 462);
            this.la.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(202, 16);
            this.la.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fem
            // 
            this.fem.Image = ((System.Drawing.Image)(resources.GetObject("fem.Image")));
            this.fem.Location = new System.Drawing.Point(258, 75);
            this.fem.Name = "fem";
            this.fem.Size = new System.Drawing.Size(133, 252);
            this.fem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fem.TabIndex = 57;
            this.fem.TabStop = false;
            this.fem.Click += new System.EventHandler(this.fem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 46);
            this.label1.TabIndex = 58;
            this.label1.Text = "Калькулятор BMI";
            // 
            // l1
            // 
            this.l1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.l1.Location = new System.Drawing.Point(750, 183);
            this.l1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(40, 20);
            this.l1.TabIndex = 59;
            // 
            // l2
            // 
            this.l2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.l2.Location = new System.Drawing.Point(750, 213);
            this.l2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(40, 20);
            this.l2.TabIndex = 60;
            // 
            // l3
            // 
            this.l3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.l3.Location = new System.Drawing.Point(750, 246);
            this.l3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(40, 20);
            this.l3.TabIndex = 61;
            // 
            // l4
            // 
            this.l4.BackColor = System.Drawing.Color.Red;
            this.l4.Location = new System.Drawing.Point(750, 277);
            this.l4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(40, 20);
            this.l4.TabIndex = 62;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(571, 90);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(158, 278);
            this.weight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weight.TabIndex = 63;
            this.weight.TabStop = false;
            // 
            // instr2
            // 
            this.instr2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instr2.Location = new System.Drawing.Point(434, 130);
            this.instr2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instr2.Name = "instr2";
            this.instr2.Size = new System.Drawing.Size(426, 197);
            this.instr2.TabIndex = 64;
            this.instr2.Text = "    1)Выберите пол;\r\n    2)Введите рост;\r\n    3)Введите вес;\r\n    4)Нажмите на кн" +
    "опку \"Рассчитать\";\r\n    5)Наслаждайтесь (или не наслаждайтесь) результатом и иди" +
    "те есть булочки \r\n(или в спортзал).\r\n";
            // 
            // instr1
            // 
            this.instr1.AutoSize = true;
            this.instr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instr1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.instr1.Location = new System.Drawing.Point(432, 75);
            this.instr1.Name = "instr1";
            this.instr1.Size = new System.Drawing.Size(176, 32);
            this.instr1.TabIndex = 65;
            this.instr1.Text = "Инструкция:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 545);
            this.Controls.Add(this.instr1);
            this.Controls.Add(this.instr2);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.l44);
            this.Controls.Add(this.l33);
            this.Controls.Add(this.l22);
            this.Controls.Add(this.l11);
            this.Controls.Add(this.ld);
            this.Controls.Add(this.lc);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.la);
            this.Controls.Add(this.ind);
            this.Controls.Add(this.stepen);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.вес);
            this.Controls.Add(this.рост);
            this.Controls.Add(this.x);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x;
        private System.Windows.Forms.TextBox рост;
        private System.Windows.Forms.TextBox вес;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label stepen;
        private System.Windows.Forms.Label ind;
        private System.Windows.Forms.Label l44;
        private System.Windows.Forms.Label l33;
        private System.Windows.Forms.Label l22;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.Label ld;
        private System.Windows.Forms.Label lc;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox fem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.PictureBox weight;
        private System.Windows.Forms.Label instr2;
        private System.Windows.Forms.Label instr1;
    }
}

