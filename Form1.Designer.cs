namespace Finances
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            button2 = new Button();
            listView2 = new ListView();
            groupBox2 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            label5 = new Label();
            textBox3 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(719, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(711, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Додавання";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(453, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 144);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "На яку карту переходять гроші?";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 60);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ваша";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(160, 60);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(66, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Чужа";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(8, 200);
            button1.Name = "button1";
            button1.Size = new Size(695, 209);
            button1.TabIndex = 9;
            button1.Text = "Додати транзакцію";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 160);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 8;
            label4.Text = "грн.";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(152, 153);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 160);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 6;
            label3.Text = "Сума";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 103);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 5;
            label2.Text = "Номер карти транзакції";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 54);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 4;
            label1.Text = "Номер вашї карти";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(listView2);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(711, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пошук";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(605, 11);
            button2.Name = "button2";
            button2.Size = new Size(88, 84);
            button2.TabIndex = 6;
            button2.Text = "Пошук";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView2
            // 
            listView2.Location = new Point(134, 105);
            listView2.Name = "listView2";
            listView2.Size = new Size(450, 304);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(8, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 89);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "За якою картою ведеться пошук?";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(172, 43);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(70, 24);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Друга";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 43);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 24);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Ваша";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 43);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 2;
            label5.Text = "Номер карти";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(410, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 27);
            textBox3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button button1;
        private ListView listView2;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label5;
        private TextBox textBox3;
        private Button button2;
        private GroupBox groupBox1;
    }
}
