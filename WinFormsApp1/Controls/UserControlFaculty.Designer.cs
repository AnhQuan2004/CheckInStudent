namespace WinFormsApp1.Controls
{
    partial class UserControlFaculty
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_faculty = new TextBox();
            label3 = new Label();
            textBox_name = new TextBox();
            dataGridView1 = new DataGridView();
            button_tim = new Button();
            button_huy = new Button();
            button_luu = new Button();
            button_sua = new Button();
            button_xoa = new Button();
            button_them = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox_faculty
            // 
            textBox_faculty.Location = new Point(403, 23);
            textBox_faculty.Name = "textBox_faculty";
            textBox_faculty.Size = new Size(125, 27);
            textBox_faculty.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 26);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 34;
            label3.Text = "Tên Khoa";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(159, 20);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(125, 27);
            textBox_name.TabIndex = 31;
            textBox_name.TextChanged += textBox_name_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(677, 255);
            dataGridView1.TabIndex = 30;
            // 
            // button_tim
            // 
            button_tim.Location = new Point(637, 69);
            button_tim.Name = "button_tim";
            button_tim.Size = new Size(94, 29);
            button_tim.TabIndex = 29;
            button_tim.Text = "Tìm";
            button_tim.UseVisualStyleBackColor = true;
            button_tim.Click += button_tim_Click;
            // 
            // button_huy
            // 
            button_huy.Location = new Point(520, 69);
            button_huy.Name = "button_huy";
            button_huy.Size = new Size(94, 29);
            button_huy.TabIndex = 28;
            button_huy.Text = "Hủy";
            button_huy.UseVisualStyleBackColor = true;
            button_huy.Click += button_huy_Click;
            // 
            // button_luu
            // 
            button_luu.Location = new Point(403, 69);
            button_luu.Name = "button_luu";
            button_luu.Size = new Size(94, 29);
            button_luu.TabIndex = 27;
            button_luu.Text = "Lưu";
            button_luu.UseVisualStyleBackColor = true;
            button_luu.Click += button_luu_Click;
            // 
            // button_sua
            // 
            button_sua.Location = new Point(287, 69);
            button_sua.Name = "button_sua";
            button_sua.Size = new Size(94, 29);
            button_sua.TabIndex = 26;
            button_sua.Text = "Sửa";
            button_sua.UseVisualStyleBackColor = true;
            button_sua.Click += button_sua_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(169, 69);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 29);
            button_xoa.TabIndex = 25;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_them
            // 
            button_them.Location = new Point(54, 69);
            button_them.Name = "button_them";
            button_them.Size = new Size(94, 29);
            button_them.TabIndex = 24;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 23);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 23;
            label1.Text = "Tên trường";
            // 
            // UserControlFaculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox_faculty);
            Controls.Add(label3);
            Controls.Add(textBox_name);
            Controls.Add(dataGridView1);
            Controls.Add(button_tim);
            Controls.Add(button_huy);
            Controls.Add(button_luu);
            Controls.Add(button_sua);
            Controls.Add(button_xoa);
            Controls.Add(button_them);
            Controls.Add(label1);
            Name = "UserControlFaculty";
            Size = new Size(828, 406);
            Load += UserControlFaculty_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_faculty;
        private Label label3;
        private TextBox textBox_name;
        private DataGridView dataGridView1;
        private Button button_tim;
        private Button button_huy;
        private Button button_luu;
        private Button button_sua;
        private Button button_xoa;
        private Button button_them;
        private Label label1;
    }
}
