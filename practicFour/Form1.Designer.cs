namespace practicFour
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.highPrice = new System.Windows.Forms.TextBox();
            this.stablePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lowPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.corn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bob = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CornStable = new System.Windows.Forms.TextBox();
            this.cornHigh = new System.Windows.Forms.TextBox();
            this.CornLow = new System.Windows.Forms.TextBox();
            this.BobLow = new System.Windows.Forms.TextBox();
            this.BobHigh = new System.Windows.Forms.TextBox();
            this.BobStable = new System.Windows.Forms.TextBox();
            this.c2 = new System.Windows.Forms.TextBox();
            this.a2 = new System.Windows.Forms.TextBox();
            this.b2 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.TextBox();
            this.a1 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startBtn);
            this.groupBox1.Controls.Add(this.lowPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stablePrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.highPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шанс повышения цены:";
            // 
            // highPrice
            // 
            this.highPrice.Location = new System.Drawing.Point(10, 42);
            this.highPrice.Name = "highPrice";
            this.highPrice.Size = new System.Drawing.Size(175, 22);
            this.highPrice.TabIndex = 1;
            // 
            // stablePrice
            // 
            this.stablePrice.Location = new System.Drawing.Point(10, 87);
            this.stablePrice.Name = "stablePrice";
            this.stablePrice.Size = new System.Drawing.Size(175, 22);
            this.stablePrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Шанс неизменности цены:";
            // 
            // lowPrice
            // 
            this.lowPrice.Location = new System.Drawing.Point(10, 132);
            this.lowPrice.Name = "lowPrice";
            this.lowPrice.Size = new System.Drawing.Size(175, 22);
            this.lowPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Шанс понижения цены:";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(644, 258);
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(166, 22);
            this.answer.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Решение:";
            // 
            // corn
            // 
            this.corn.Location = new System.Drawing.Point(494, 183);
            this.corn.Name = "corn";
            this.corn.ReadOnly = true;
            this.corn.Size = new System.Drawing.Size(100, 22);
            this.corn.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Кукуруза:";
            // 
            // bob
            // 
            this.bob.Location = new System.Drawing.Point(816, 174);
            this.bob.Name = "bob";
            this.bob.ReadOnly = true;
            this.bob.Size = new System.Drawing.Size(100, 22);
            this.bob.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(848, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Бобы:";
            // 
            // CornStable
            // 
            this.CornStable.BackColor = System.Drawing.Color.Olive;
            this.CornStable.Location = new System.Drawing.Point(494, 29);
            this.CornStable.Name = "CornStable";
            this.CornStable.Size = new System.Drawing.Size(100, 22);
            this.CornStable.TabIndex = 8;
            // 
            // cornHigh
            // 
            this.cornHigh.BackColor = System.Drawing.Color.Green;
            this.cornHigh.Location = new System.Drawing.Point(388, 29);
            this.cornHigh.Name = "cornHigh";
            this.cornHigh.Size = new System.Drawing.Size(100, 22);
            this.cornHigh.TabIndex = 9;
            // 
            // CornLow
            // 
            this.CornLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CornLow.Location = new System.Drawing.Point(600, 29);
            this.CornLow.Name = "CornLow";
            this.CornLow.Size = new System.Drawing.Size(100, 22);
            this.CornLow.TabIndex = 10;
            // 
            // BobLow
            // 
            this.BobLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BobLow.Location = new System.Drawing.Point(922, 29);
            this.BobLow.Name = "BobLow";
            this.BobLow.Size = new System.Drawing.Size(100, 22);
            this.BobLow.TabIndex = 13;
            // 
            // BobHigh
            // 
            this.BobHigh.BackColor = System.Drawing.Color.Green;
            this.BobHigh.Location = new System.Drawing.Point(710, 29);
            this.BobHigh.Name = "BobHigh";
            this.BobHigh.Size = new System.Drawing.Size(100, 22);
            this.BobHigh.TabIndex = 12;
            // 
            // BobStable
            // 
            this.BobStable.BackColor = System.Drawing.Color.Olive;
            this.BobStable.Location = new System.Drawing.Point(816, 29);
            this.BobStable.Name = "BobStable";
            this.BobStable.Size = new System.Drawing.Size(100, 22);
            this.BobStable.TabIndex = 11;
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.c2.Location = new System.Drawing.Point(922, 100);
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            this.c2.Size = new System.Drawing.Size(100, 22);
            this.c2.TabIndex = 19;
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.Color.Green;
            this.a2.Location = new System.Drawing.Point(710, 100);
            this.a2.Name = "a2";
            this.a2.ReadOnly = true;
            this.a2.Size = new System.Drawing.Size(100, 22);
            this.a2.TabIndex = 18;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Olive;
            this.b2.Location = new System.Drawing.Point(816, 100);
            this.b2.Name = "b2";
            this.b2.ReadOnly = true;
            this.b2.Size = new System.Drawing.Size(100, 22);
            this.b2.TabIndex = 17;
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.c1.Location = new System.Drawing.Point(600, 100);
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Size = new System.Drawing.Size(100, 22);
            this.c1.TabIndex = 16;
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.Color.Green;
            this.a1.Location = new System.Drawing.Point(388, 100);
            this.a1.Name = "a1";
            this.a1.ReadOnly = true;
            this.a1.Size = new System.Drawing.Size(100, 22);
            this.a1.TabIndex = 15;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Olive;
            this.b1.Location = new System.Drawing.Point(494, 100);
            this.b1.Name = "b1";
            this.b1.ReadOnly = true;
            this.b1.Size = new System.Drawing.Size(100, 22);
            this.b1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Заполните поля:";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(10, 161);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(175, 72);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 378);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.BobLow);
            this.Controls.Add(this.BobHigh);
            this.Controls.Add(this.BobStable);
            this.Controls.Add(this.CornLow);
            this.Controls.Add(this.cornHigh);
            this.Controls.Add(this.CornStable);
            this.Controls.Add(this.bob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.corn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lowPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stablePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox highPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox corn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CornStable;
        private System.Windows.Forms.TextBox cornHigh;
        private System.Windows.Forms.TextBox CornLow;
        private System.Windows.Forms.TextBox BobLow;
        private System.Windows.Forms.TextBox BobHigh;
        private System.Windows.Forms.TextBox BobStable;
        private System.Windows.Forms.TextBox c2;
        private System.Windows.Forms.TextBox a2;
        private System.Windows.Forms.TextBox b2;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.TextBox a1;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button startBtn;
    }
}

