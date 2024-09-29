namespace WinFormsApp1
{
    partial class Update_School
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
            button2 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            textBoxId = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(111, 380);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 17;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(298, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(330, 27);
            textBox3.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(111, 273);
            label4.Name = "label4";
            label4.Size = new Size(157, 31);
            label4.TabIndex = 15;
            label4.Text = "Name Subject";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(298, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 27);
            textBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(111, 209);
            label3.Name = "label3";
            label3.Size = new Size(152, 31);
            label3.TabIndex = 13;
            label3.Text = "Name Faculty";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 27);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 156);
            label2.Name = "label2";
            label2.Size = new Size(149, 31);
            label2.TabIndex = 11;
            label2.Text = "Name School";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(75, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 72);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(245, 22);
            label1.Name = "label1";
            label1.Size = new Size(92, 31);
            label1.TabIndex = 3;
            label1.Text = "Update";
            label1.Click += label1_Click;
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
            // button3
            // 
            button3.Location = new Point(235, 380);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 18;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(373, 380);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 19;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 128);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 20;
            label5.Text = "id";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(298, 121);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(330, 27);
            textBoxId.TabIndex = 21;
            // 
            // Update_School
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 450);
            Controls.Add(textBoxId);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Update_School";
            Text = "Update_School";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private Button button3;
        private Button button4;
        private Label label5;
        private TextBox textBoxId;
    }
}