using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1.Controls
{
    public partial class UserControlSchool : UserControl
    {
        private bool isEditing = false;
        private int editingRowIndex = -1;

        public UserControlSchool()
        {
            InitializeComponent();
            LoadSchoolData(); // Load data when the UserControl is initialized
            DisableControls();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Optional: Set column header styles (if necessary)
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Optional: Set row styles for better visual appeal
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        }

        private void LoadSchoolData()
        {
            try
            {
                string connectionString = @"Data Source=ANH-QUAN;Initial Catalog=WinFormsApp1;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT id, school FROM ut", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void DisableControls()
        {
            textBox_name.Enabled = false;
            button_xoa.Enabled = false;
            button_sua.Enabled = false;
            button_luu.Enabled = false;
        }

        private void EnableControls()
        {
            textBox_name.Enabled = true;
            button_luu.Enabled = true;
            button_xoa.Enabled = true;
            button_sua.Enabled = true;
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            textBox_name.Enabled = true;
            textBox_name.Clear();
            textBox_name.Focus();
            isEditing = false;
            button_luu.Enabled = true;
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            string nameSchool = textBox_name.Text;

            if (string.IsNullOrWhiteSpace(nameSchool))
            {
                MessageBox.Show("Please enter a valid school name.");
                return;
            }

            if (isEditing)
            {
                // Update existing record
                DataGridViewRow row = dataGridView1.Rows[editingRowIndex];
                row.Cells["school"].Value = nameSchool;

                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=ANH-QUAN;Initial Catalog=WinFormsApp1;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE ut SET school = @school WHERE id = @id", con);
                        cmd.Parameters.AddWithValue("@school", nameSchool);
                        cmd.Parameters.AddWithValue("@id", row.Cells["id"].Value);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("School updated successfully.");
                    LoadSchoolData(); // Reload data after updating
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating school: " + ex.Message);
                }
            }
            else
            {
                // Insert new record
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=ANH-QUAN;Initial Catalog=WinFormsApp1;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO ut (school, faculty) VALUES (@school, @faculty)", con);
                        cmd.Parameters.AddWithValue("@school", nameSchool);
                        cmd.Parameters.AddWithValue("@faculty", "Faculty Example"); // You can modify this
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("New school added successfully.");
                    LoadSchoolData(); // Reload data after inserting
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding school: " + ex.Message);
                }
            }

            // Clear form and disable controls after saving
            textBox_name.Clear();
            DisableControls();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chỉ xử lý khi người dùng chọn một dòng, không phải tiêu đề
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)  // Ensure it's not the header row/column
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các control trên form
                if (selectedRow.Cells["school"].Value != null)
                {
                    textBox_name.Text = selectedRow.Cells["school"].Value.ToString();  // Ensure "school" is the correct column name
                }

                // Set isEditing to true, and store the row index for future updates
                isEditing = true;
                editingRowIndex = e.RowIndex;

                // Kích hoạt các nút Sửa và Xóa
                button_sua.Enabled = true;
                button_xoa.Enabled = true;
            }
            else
            {
                // Disable buttons if an invalid row or header is clicked
                button_sua.Enabled = false;
                button_xoa.Enabled = false;
            }
        }




        private void button_xoa_Click_1(object sender, EventArgs e)
        {
            if (editingRowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[editingRowIndex];
                int id = (int)row.Cells["id"].Value;

                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=ANH-QUAN;Initial Catalog=WinFormsApp1;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM ut WHERE id = @id", con);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("School deleted successfully.");
                    LoadSchoolData(); // Reload data after deleting
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting school: " + ex.Message);
                }

                // Clear form and disable controls after deleting
                textBox_name.Clear();
                DisableControls();
                isEditing = false;
                editingRowIndex = -1;
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }
        private void DSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chỉ xử lý khi người dùng chọn một dòng, không phải tiêu đề
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)  // Ensure it's not the header row/column
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các control trên form
                textBox_name.Text = selectedRow.Cells["school"].Value.ToString();  // Assuming "school" is the correct column name

                // Set isEditing to true, and store the row index for future updates
                isEditing = true;
                editingRowIndex = e.RowIndex;

                // Kích hoạt các nút Sửa và Xóa
                button_sua.Enabled = true;
                button_xoa.Enabled = true;
            }
            else
            {
                // Disable buttons if an invalid row or header is clicked
                button_sua.Enabled = false;
                button_xoa.Enabled = false;
            }
        }

        private void button_sua_Click_1(object sender, EventArgs e)
        {
            if (editingRowIndex >= 0)
            {
                isEditing = true;
                textBox_name.Focus();
                EnableControls();
            }
            else
            {
                MessageBox.Show("Please select a record to edit.");
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            // Clear all input fields (textboxes)
            textBox_name.Clear();

            // Reload the data from the database to reset the DataGridView
            LoadSchoolData();

            // Reset the editing state and disable buttons for editing/deleting
            isEditing = false;
            editingRowIndex = -1;

            // Disable all controls that shouldn't be active after cancelling
            button_luu.Enabled = false;
            button_xoa.Enabled = false;
            button_sua.Enabled = false;

            // Optionally, disable the textboxes as well
            textBox_name.Enabled = false;


            MessageBox.Show("Form has been reset.");
        }

        private void button_tim_Click(object sender, EventArgs e)
        {
            string searchValue = textBox_name.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Please enter a school name to search.");
                return;
            }

            try
            {
                string connectionString = @"Data Source=ANH-QUAN;Initial Catalog=WinFormsApp1;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Use a SQL LIKE query to search for matching school names
                    SqlCommand cmd = new SqlCommand("SELECT id, school FROM ut WHERE school LIKE @searchValue", con);
                    cmd.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // If records are found, display them in the DataGridView
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        // If no records are found, show a message and clear the DataGridView
                        MessageBox.Show("No records found.");
                        dataGridView1.DataSource = null;
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message);
            }
        }

    }
}
