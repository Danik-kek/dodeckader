namespace dodeckader
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 451);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 480);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "0";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(275, 451);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 3;
            textBox6.Text = "200";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(275, 480);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 4;
            textBox7.Text = "200";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(467, 451);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            textBox3.Text = "100";
            // 
            // button1
            // 
            button1.Location = new Point(467, 380);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Draw";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 427);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 7;
            label1.Text = "Rotation";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 427);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 8;
            label2.Text = "Relocation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 454);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 9;
            label3.Text = "Scale";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 454);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 10;
            label4.Text = "Axis - X:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 483);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "Axis - Y:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(219, 454);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 12;
            label6.Text = "Axis - X:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(219, 483);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 13;
            label7.Text = "Axis - Y:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(467, 497);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "IN Collor";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(467, 522);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(57, 19);
            radioButton2.TabIndex = 15;
            radioButton2.Text = "IN Pin";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 601);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "my dadic";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
