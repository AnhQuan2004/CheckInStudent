namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            button3 = new Button();
            panelSchool = new Button();
            bindingSource1 = new BindingSource(components);
            panelMain = new Panel();
            PanelFaculty = new Button();
            PanelSubject = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 62);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(958, 0);
            button1.Name = "button1";
            button1.Size = new Size(45, 30);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(0, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(1006, 10);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(683, 84);
            button2.Name = "button2";
            button2.Size = new Size(134, 46);
            button2.TabIndex = 2;
            button2.Text = "Create School";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(836, 84);
            button3.Name = "button3";
            button3.Size = new Size(134, 46);
            button3.TabIndex = 3;
            button3.Text = "Update School";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panelSchool
            // 
            panelSchool.Location = new Point(22, 80);
            panelSchool.Name = "panelSchool";
            panelSchool.Padding = new Padding(0, 0, 0, 6);
            panelSchool.Size = new Size(153, 50);
            panelSchool.TabIndex = 5;
            panelSchool.Text = "School";
            panelSchool.UseVisualStyleBackColor = true;
            panelSchool.Click += panelSchool_Click;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(12, 152);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(977, 343);
            panelMain.TabIndex = 6;
            panelMain.Paint += panelMain_Paint;
            // 
            // PanelFaculty
            // 
            PanelFaculty.Location = new Point(203, 80);
            PanelFaculty.Name = "PanelFaculty";
            PanelFaculty.Padding = new Padding(0, 0, 0, 6);
            PanelFaculty.Size = new Size(153, 50);
            PanelFaculty.TabIndex = 7;
            PanelFaculty.Text = "Khoa";
            PanelFaculty.UseVisualStyleBackColor = true;
            PanelFaculty.Click += PanelFaculty_Click;
            // 
            // PanelSubject
            // 
            PanelSubject.Location = new Point(401, 80);
            PanelSubject.Name = "PanelSubject";
            PanelSubject.Size = new Size(153, 50);
            PanelSubject.TabIndex = 8;
            PanelSubject.Text = "Môn";
            PanelSubject.UseVisualStyleBackColor = true;
            PanelSubject.Click += PanelSubject_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 317);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(546, 82);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 507);
            Controls.Add(PanelSubject);
            Controls.Add(PanelFaculty);
            Controls.Add(panelMain);
            Controls.Add(panelSchool);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button panelSchool;
        private BindingSource bindingSource1;
        private Panel panelMain;
        private Button PanelFaculty;
        private Button PanelSubject;
        private DataGridView dataGridView1;
    }
}
