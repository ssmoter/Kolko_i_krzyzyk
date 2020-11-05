using static kółko_i_krzyżyk.Program;

namespace kółko_i_krzyżyk
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ustaw = new System.Windows.Forms.Button();
            this.TEST = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.G9 = new System.Windows.Forms.Button();
            this.G8 = new System.Windows.Forms.Button();
            this.G7 = new System.Windows.Forms.Button();
            this.G6 = new System.Windows.Forms.Button();
            this.G5 = new System.Windows.Forms.Button();
            this.G4 = new System.Windows.Forms.Button();
            this.G3 = new System.Windows.Forms.Button();
            this.G2 = new System.Windows.Forms.Button();
            this.G1 = new System.Windows.Forms.Button();
            this.PKT = new System.Windows.Forms.Label();
            this.BOT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa pierwszego gracza:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa drugiego gracza:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ustaw
            // 
            this.ustaw.Location = new System.Drawing.Point(15, 167);
            this.ustaw.Name = "ustaw";
            this.ustaw.Size = new System.Drawing.Size(100, 28);
            this.ustaw.TabIndex = 4;
            this.ustaw.Text = "Ustaw";
            this.ustaw.UseVisualStyleBackColor = true;
            this.ustaw.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // TEST
            // 
            this.TEST.AutoSize = true;
            this.TEST.Location = new System.Drawing.Point(15, 199);
            this.TEST.Name = "TEST";
            this.TEST.Size = new System.Drawing.Size(52, 13);
            this.TEST.TabIndex = 6;
            this.TEST.Text = "Grzacze: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Symbol :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "O";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(164, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "O";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Symbol :";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(139, 168);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 28);
            this.Start.TabIndex = 13;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Visible = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(93, 135);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 23;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // G9
            // 
            this.G9.Location = new System.Drawing.Point(174, 98);
            this.G9.Name = "G9";
            this.G9.Size = new System.Drawing.Size(75, 23);
            this.G9.TabIndex = 22;
            this.G9.UseVisualStyleBackColor = true;
            this.G9.Visible = false;
            this.G9.Click += new System.EventHandler(this.button9_Click);
            // 
            // G8
            // 
            this.G8.Location = new System.Drawing.Point(174, 69);
            this.G8.Name = "G8";
            this.G8.Size = new System.Drawing.Size(75, 23);
            this.G8.TabIndex = 21;
            this.G8.UseVisualStyleBackColor = true;
            this.G8.Visible = false;
            this.G8.Click += new System.EventHandler(this.G8_Click);
            // 
            // G7
            // 
            this.G7.Location = new System.Drawing.Point(174, 40);
            this.G7.Name = "G7";
            this.G7.Size = new System.Drawing.Size(75, 23);
            this.G7.TabIndex = 20;
            this.G7.UseVisualStyleBackColor = true;
            this.G7.Visible = false;
            this.G7.Click += new System.EventHandler(this.G7_Click);
            // 
            // G6
            // 
            this.G6.Location = new System.Drawing.Point(93, 98);
            this.G6.Name = "G6";
            this.G6.Size = new System.Drawing.Size(75, 23);
            this.G6.TabIndex = 19;
            this.G6.UseVisualStyleBackColor = true;
            this.G6.Visible = false;
            this.G6.Click += new System.EventHandler(this.G6_Click);
            // 
            // G5
            // 
            this.G5.Location = new System.Drawing.Point(93, 69);
            this.G5.Name = "G5";
            this.G5.Size = new System.Drawing.Size(75, 23);
            this.G5.TabIndex = 18;
            this.G5.UseVisualStyleBackColor = true;
            this.G5.Visible = false;
            this.G5.Click += new System.EventHandler(this.G5_Click);
            // 
            // G4
            // 
            this.G4.Location = new System.Drawing.Point(93, 40);
            this.G4.Name = "G4";
            this.G4.Size = new System.Drawing.Size(75, 23);
            this.G4.TabIndex = 17;
            this.G4.UseVisualStyleBackColor = true;
            this.G4.Visible = false;
            this.G4.Click += new System.EventHandler(this.G4_Click);
            // 
            // G3
            // 
            this.G3.Location = new System.Drawing.Point(12, 98);
            this.G3.Name = "G3";
            this.G3.Size = new System.Drawing.Size(75, 23);
            this.G3.TabIndex = 16;
            this.G3.UseVisualStyleBackColor = true;
            this.G3.Visible = false;
            this.G3.Click += new System.EventHandler(this.G3_Click);
            // 
            // G2
            // 
            this.G2.Location = new System.Drawing.Point(12, 69);
            this.G2.Name = "G2";
            this.G2.Size = new System.Drawing.Size(75, 23);
            this.G2.TabIndex = 15;
            this.G2.UseVisualStyleBackColor = true;
            this.G2.Visible = false;
            this.G2.Click += new System.EventHandler(this.G2_Click);
            // 
            // G1
            // 
            this.G1.Location = new System.Drawing.Point(12, 40);
            this.G1.Name = "G1";
            this.G1.Size = new System.Drawing.Size(75, 23);
            this.G1.TabIndex = 14;
            this.G1.UseVisualStyleBackColor = true;
            this.G1.Visible = false;
            this.G1.Click += new System.EventHandler(this.G1_Click);
            // 
            // PKT
            // 
            this.PKT.AutoSize = true;
            this.PKT.Location = new System.Drawing.Point(18, 167);
            this.PKT.Name = "PKT";
            this.PKT.Size = new System.Drawing.Size(28, 13);
            this.PKT.TabIndex = 24;
            this.PKT.Text = "PKT";
            this.PKT.Visible = false;
            this.PKT.Click += new System.EventHandler(this.PKT_Click);
            // 
            // BOT
            // 
            this.BOT.Location = new System.Drawing.Point(267, 37);
            this.BOT.Name = "BOT";
            this.BOT.Size = new System.Drawing.Size(46, 23);
            this.BOT.TabIndex = 25;
            this.BOT.Text = "BOT";
            this.BOT.UseVisualStyleBackColor = true;
            this.BOT.Click += new System.EventHandler(this.BOT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 260);
            this.Controls.Add(this.BOT);
            this.Controls.Add(this.PKT);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.G9);
            this.Controls.Add(this.G8);
            this.Controls.Add(this.G7);
            this.Controls.Add(this.G6);
            this.Controls.Add(this.G5);
            this.Controls.Add(this.G4);
            this.Controls.Add(this.G3);
            this.Controls.Add(this.G2);
            this.Controls.Add(this.G1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TEST);
            this.Controls.Add(this.ustaw);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "kółko i krzyżyk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ustaw;
        private System.Windows.Forms.Label TEST;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button G9;
        private System.Windows.Forms.Button G8;
        private System.Windows.Forms.Button G7;
        private System.Windows.Forms.Button G6;
        private System.Windows.Forms.Button G5;
        private System.Windows.Forms.Button G4;
        private System.Windows.Forms.Button G3;
        private System.Windows.Forms.Button G2;
        private System.Windows.Forms.Button G1;
        private System.Windows.Forms.Label PKT;
        private System.Windows.Forms.Button BOT;
    }
}

