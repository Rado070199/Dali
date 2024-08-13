namespace SystemERP.WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonA1 = new Button();
            buttonA2 = new Button();
            panelLine = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1a = new TextBox();
            textBox2a = new TextBox();
            textBox3a = new TextBox();
            textBox4a = new TextBox();
            textBox5a = new TextBox();
            textBox5b = new TextBox();
            textBox4b = new TextBox();
            textBox3b = new TextBox();
            textBox2b = new TextBox();
            textBox1b = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBoxOutPut1 = new TextBox();
            label11 = new Label();
            textBoxOutPut2 = new TextBox();
            label12 = new Label();
            buttonD1 = new Button();
            buttonD2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonA1
            // 
            buttonA1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonA1.Location = new Point(3, 3);
            buttonA1.Name = "buttonA1";
            buttonA1.Size = new Size(521, 39);
            buttonA1.TabIndex = 0;
            buttonA1.Text = "Algorytm1";
            buttonA1.UseVisualStyleBackColor = true;
            buttonA1.Click += buttonA1_Click;
            // 
            // buttonA2
            // 
            buttonA2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonA2.Location = new Point(550, 3);
            buttonA2.Name = "buttonA2";
            buttonA2.Size = new Size(521, 39);
            buttonA2.TabIndex = 1;
            buttonA2.Text = "Algorytm2";
            buttonA2.UseVisualStyleBackColor = true;
            buttonA2.Click += buttonA2_Click;
            // 
            // panelLine
            // 
            panelLine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelLine.BackColor = SystemColors.ActiveCaptionText;
            panelLine.ForeColor = SystemColors.ActiveCaption;
            panelLine.Location = new Point(530, 3);
            panelLine.Name = "panelLine";
            panelLine.Size = new Size(14, 40);
            panelLine.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelLine, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonA2, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonA1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1074, 46);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 70);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 4;
            label1.Text = "Podaj rozmiar populacji: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 102);
            label2.Name = "label2";
            label2.Size = new Size(229, 20);
            label2.TabIndex = 5;
            label2.Text = "Podaj współczynnik krzyżowania: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 136);
            label3.Name = "label3";
            label3.Size = new Size(193, 20);
            label3.TabIndex = 6;
            label3.Text = "Podaj współczynnik mutacji:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 169);
            label4.Name = "label4";
            label4.Size = new Size(245, 20);
            label4.TabIndex = 7;
            label4.Text = "Podaj współczynnik selekcji mutacji:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 202);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 8;
            label5.Text = "Podaj liczbę iteracji: ";
            // 
            // textBox1a
            // 
            textBox1a.Location = new Point(267, 66);
            textBox1a.Name = "textBox1a";
            textBox1a.Size = new Size(257, 27);
            textBox1a.TabIndex = 9;
            textBox1a.Text = "30";
            // 
            // textBox2a
            // 
            textBox2a.Location = new Point(267, 99);
            textBox2a.Name = "textBox2a";
            textBox2a.Size = new Size(257, 27);
            textBox2a.TabIndex = 10;
            textBox2a.Text = "0.8";
            // 
            // textBox3a
            // 
            textBox3a.Location = new Point(267, 133);
            textBox3a.Name = "textBox3a";
            textBox3a.Size = new Size(257, 27);
            textBox3a.TabIndex = 11;
            textBox3a.Text = "0.1";
            // 
            // textBox4a
            // 
            textBox4a.Location = new Point(267, 166);
            textBox4a.Name = "textBox4a";
            textBox4a.Size = new Size(257, 27);
            textBox4a.TabIndex = 12;
            textBox4a.Text = "0.5";
            // 
            // textBox5a
            // 
            textBox5a.Location = new Point(267, 199);
            textBox5a.Name = "textBox5a";
            textBox5a.Size = new Size(257, 27);
            textBox5a.TabIndex = 13;
            textBox5a.Text = "2000";
            // 
            // textBox5b
            // 
            textBox5b.Location = new Point(817, 196);
            textBox5b.Name = "textBox5b";
            textBox5b.Size = new Size(257, 27);
            textBox5b.TabIndex = 23;
            textBox5b.Text = "2000";
            // 
            // textBox4b
            // 
            textBox4b.Location = new Point(817, 163);
            textBox4b.Name = "textBox4b";
            textBox4b.Size = new Size(257, 27);
            textBox4b.TabIndex = 22;
            textBox4b.Text = "0.5";
            // 
            // textBox3b
            // 
            textBox3b.Location = new Point(817, 130);
            textBox3b.Name = "textBox3b";
            textBox3b.Size = new Size(257, 27);
            textBox3b.TabIndex = 21;
            textBox3b.Text = "0.2";
            // 
            // textBox2b
            // 
            textBox2b.Location = new Point(817, 96);
            textBox2b.Name = "textBox2b";
            textBox2b.Size = new Size(257, 27);
            textBox2b.TabIndex = 20;
            textBox2b.Text = "0.8";
            // 
            // textBox1b
            // 
            textBox1b.Location = new Point(817, 63);
            textBox1b.Name = "textBox1b";
            textBox1b.Size = new Size(257, 27);
            textBox1b.TabIndex = 19;
            textBox1b.Text = "30";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(669, 199);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 18;
            label6.Text = "Podaj liczbę iteracji: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(570, 166);
            label7.Name = "label7";
            label7.Size = new Size(245, 20);
            label7.TabIndex = 17;
            label7.Text = "Podaj współczynnik selekcji mutacji:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(622, 133);
            label8.Name = "label8";
            label8.Size = new Size(193, 20);
            label8.TabIndex = 16;
            label8.Text = "Podaj współczynnik mutacji:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(586, 99);
            label9.Name = "label9";
            label9.Size = new Size(229, 20);
            label9.TabIndex = 15;
            label9.Text = "Podaj współczynnik krzyżowania: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(641, 67);
            label10.Name = "label10";
            label10.Size = new Size(174, 20);
            label10.TabIndex = 14;
            label10.Text = "Podaj rozmiar populacji: ";
            // 
            // textBoxOutPut1
            // 
            textBoxOutPut1.Location = new Point(20, 264);
            textBoxOutPut1.Multiline = true;
            textBoxOutPut1.Name = "textBoxOutPut1";
            textBoxOutPut1.Size = new Size(504, 148);
            textBoxOutPut1.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 241);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 25;
            label11.Text = "Output:";
            // 
            // textBoxOutPut2
            // 
            textBoxOutPut2.Location = new Point(567, 264);
            textBoxOutPut2.Multiline = true;
            textBoxOutPut2.Name = "textBoxOutPut2";
            textBoxOutPut2.Size = new Size(504, 148);
            textBoxOutPut2.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(570, 241);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 27;
            label12.Text = "Output:";
            // 
            // buttonD1
            // 
            buttonD1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonD1.Location = new Point(20, 420);
            buttonD1.Name = "buttonD1";
            buttonD1.Size = new Size(527, 39);
            buttonD1.TabIndex = 28;
            buttonD1.Text = "Diagram1";
            buttonD1.UseVisualStyleBackColor = true;
            buttonD1.Click += buttonD1_Click;
            // 
            // buttonD2
            // 
            buttonD2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonD2.Location = new Point(567, 420);
            buttonD2.Name = "buttonD2";
            buttonD2.Size = new Size(527, 39);
            buttonD2.TabIndex = 29;
            buttonD2.Text = "Diagram2";
            buttonD2.UseVisualStyleBackColor = true;
            buttonD2.Click += buttonD2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 471);
            Controls.Add(buttonD2);
            Controls.Add(buttonD1);
            Controls.Add(label12);
            Controls.Add(textBoxOutPut2);
            Controls.Add(label11);
            Controls.Add(textBoxOutPut1);
            Controls.Add(textBox5b);
            Controls.Add(textBox4b);
            Controls.Add(textBox3b);
            Controls.Add(textBox2b);
            Controls.Add(textBox1b);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(textBox5a);
            Controls.Add(textBox4a);
            Controls.Add(textBox3a);
            Controls.Add(textBox2a);
            Controls.Add(textBox1a);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Algorytmy genetyczne";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonA1;
        private Button buttonA2;
        private Panel panelLine;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1a;
        private TextBox textBox2a;
        private TextBox textBox3a;
        private TextBox textBox4a;
        private TextBox textBox5a;
        private TextBox textBox5b;
        private TextBox textBox4b;
        private TextBox textBox3b;
        private TextBox textBox2b;
        private TextBox textBox1b;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBoxOutPut1;
        private Label label11;
        private TextBox textBoxOutPut2;
        private Label label12;
        private Button buttonD1;
        private Button buttonD2;
    }
}
