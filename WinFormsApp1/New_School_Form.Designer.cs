namespace WinFormsApp1
{
    partial class New_School_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(197, 22);
            label1.Name = "label1";
            label1.Size = new Size(191, 31);
            label1.TabIndex = 3;
            label1.Text = "Add New School";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(578, 0);
            button1.Name = "button1";
            button1.Size = new Size(55, 53);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(626, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 125);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(625, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 467);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 467);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(-1, 71);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 467);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.SteelBlue;
            panel6.Location = new Point(3, 453);
            panel6.Name = "panel6";
            panel6.Size = new Size(630, 11);
            panel6.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 120);
            label2.Name = "label2";
            label2.Size = new Size(149, 31);
            label2.TabIndex = 3;
            label2.Text = "Name School";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(222, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 27);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 173);
            label3.Name = "label3";
            label3.Size = new Size(152, 31);
            label3.TabIndex = 5;
            label3.Text = "Name Faculty";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(222, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(330, 27);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 237);
            label4.Name = "label4";
            label4.Size = new Size(157, 31);
            label4.TabIndex = 7;
            label4.Text = "Name Subject";
            // 
            // button2
            // 
            button2.Location = new Point(78, 351);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // New_School_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 538);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "New_School_Form";
            Text = "New_School_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button2;
    }
}