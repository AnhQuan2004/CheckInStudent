namespace WinFormsApp1.Controls
{
    partial class UserControlSchool
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

            label1 = new Label();
            button_them = new Button();
            button_xoa = new Button();
            button_sua = new Button();
            button_luu = new Button();
            button_huy = new Button();
            button_tim = new Button();
            dataGridView1 = new DataGridView();
            textBox_name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 19);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên trường";
            // 
            // button_them
            // 
            button_them.Location = new Point(55, 65);
            button_them.Name = "button_them";
            button_them.Size = new Size(94, 29);
            button_them.TabIndex = 2;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(170, 65);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 29);
            button_xoa.TabIndex = 3;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click_1;
            // 
            // button_sua
            // 
            button_sua.Location = new Point(288, 65);
            button_sua.Name = "button_sua";
            button_sua.Size = new Size(94, 29);
            button_sua.TabIndex = 4;
            button_sua.Text = "Sửa";
            button_sua.UseVisualStyleBackColor = true;
            button_sua.Click += button_sua_Click_1;
            // 
            // button_luu
            // 
            button_luu.Location = new Point(404, 65);
            button_luu.Name = "button_luu";
            button_luu.Size = new Size(94, 29);
            button_luu.TabIndex = 5;
            button_luu.Text = "Lưu";
            button_luu.UseVisualStyleBackColor = true;
            button_luu.Click += button_luu_Click;
            // 
            // button_huy
            // 
            button_huy.Location = new Point(521, 65);
            button_huy.Name = "button_huy";
            button_huy.Size = new Size(94, 29);
            button_huy.TabIndex = 6;
            button_huy.Text = "Hủy";
            button_huy.UseVisualStyleBackColor = true;
            button_huy.Click += button_huy_Click;
            // 
            // button_tim
            // 
            button_tim.Location = new Point(638, 65);
            button_tim.Name = "button_tim";
            button_tim.Size = new Size(94, 29);
            button_tim.TabIndex = 7;
            button_tim.Text = "Tìm";
            button_tim.UseVisualStyleBackColor = true;
            button_tim.Click += button_tim_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(677, 255);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(160, 16);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(125, 27);
            textBox_name.TabIndex = 9;
            // 
            // UserControlSchool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox_name);
            Controls.Add(dataGridView1);
            Controls.Add(button_tim);
            Controls.Add(button_huy);
            Controls.Add(button_luu);
            Controls.Add(button_sua);
            Controls.Add(button_xoa);
            Controls.Add(button_them);
            Controls.Add(label1);
            Name = "UserControlSchool";
            Size = new Size(828, 406);
            Load += UserControlSchool_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_them;
        private Button button_xoa;
        private Button button_sua;
        private Button button_luu;
        private Button button_huy;
        private Button button_tim;
        private DataGridView dataGridView1;
        private TextBox textBox_name;

        // Add the Load event handler method here
        private void UserControlSchool_Load(object sender, EventArgs e)
        {
            LoadSchoolData();  // Call to load data into the DataGridView when the control loads
            DisableControls(); // Disable controls initially
        }
    }
}
