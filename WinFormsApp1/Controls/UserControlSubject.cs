using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Controls
{
    public partial class UserControlSubject : UserControl
    {
        private bool isEditing = false;
        private int editingRowIndex = -1;
        public UserControlSubject()
        {
            InitializeComponent();
            LoadSubjectData();
            DisableControls();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Optional: Set column header styles (if necessary)
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Optional: Set row styles for better visual appeal
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //Gắn sự kiện CellClick cho DataGridView
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void LoadSubjectData()
        {
            try
            {
                string connectionString = @"Data Source=ANH-QUAN;Initial Catalog=WinFormsApp1;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM ut", con);
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

        public void DisableControls()
        {
            textBox_name.Enabled = false;
            textBox_faculty.Enabled = false;
            textBox_subject.Enabled = false;
            button_xoa.Enabled = false;
            button_luu.Enabled = false;
            button_huy.Enabled = false;
        }

        public void EnableControls()
        {
            textBox_name.Enabled = true;
            textBox_faculty.Enabled = true;
            textBox_subject.Enabled = true;
            button_xoa.Enabled = true;
            button_luu.Enabled = true;
            button_huy.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchSubject_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_them_Click(object sender, EventArgs e)
        {
            textBox_name.Enabled = true;
            textBox_faculty.Enabled = true;
            textBox_subject.Enabled = true;

            //Clear textboxes
            textBox_name.Clear();
            textBox_faculty.Clear();
            textBox_subject.Clear();

            //Focus on the first textbox
            textBox_name.Focus();

            button_luu.Enabled = true;

        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            string nameSchool = textBox_name.Text;
            string nameFaculty = textBox_faculty.Text;
            string nameSubject = textBox_subject.Text;

            // Validation to ensure no empty fields
            if (string.IsNullOrWhiteSpace(nameSchool))
            {
                MessageBox.Show("Please enter a valid school name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nameFaculty))
            {
                MessageBox.Show("Please enter a valid faculty name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nameSubject))
            {
                MessageBox.Show("Please enter a valid subject name.");
                return;
            }

            if (isEditing)
            {
                // Update existing record
                DataGridViewRow row = dataGridView1.Rows[editingRowIndex];
                row.Cells["school"].Value = nameSchool;
                row.Cells["faculty"].Value = nameFaculty;
                row.Cells["subject"].Value = nameSubject;

                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=ANH-QUAN;Initial Catalog=WinFormsApp1;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        con.Open();

                        // Update query to include faculty and subject
                        SqlCommand cmd = new SqlCommand(
                            "UPDATE ut SET school = @school, faculty = @faculty, subject = @subject WHERE id = @id", con);

                        // Set parameters for school, faculty, subject and id
                        cmd.Parameters.AddWithValue("@school", nameSchool);
                        cmd.Parameters.AddWithValue("@faculty", nameFaculty);
                        cmd.Parameters.AddWithValue("@subject", nameSubject);
                        cmd.Parameters.AddWithValue("@id", row.Cells["id"].Value);

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("School updated successfully.");
                    LoadSubjectData(); // Reload data after updating
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

                        // Insert query to include school, faculty, and subject
                        SqlCommand cmd = new SqlCommand(
                            "INSERT INTO ut (school, faculty, subject) VALUES (@school, @faculty, @subject)", con);

                        // Set parameters for school, faculty, and subject
                        cmd.Parameters.AddWithValue("@school", nameSchool);
                        cmd.Parameters.AddWithValue("@faculty", nameFaculty);
                        cmd.Parameters.AddWithValue("@subject", nameSubject);

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("New school added successfully.");
                    LoadSubjectData(); // Reload data after inserting
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding school: " + ex.Message);
                }
            }

            // Clear form and disable controls after saving
            textBox_name.Clear();
            textBox_faculty.Clear();
            textBox_subject.Clear();
            DisableControls();

        }


        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (editingRowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView1.Rows[editingRowIndex];
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=ANH-QUAN;Initial Catalog=WinFormsApp1;Integrated Security=True;TrustServerCertificate=True"))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM ut WHERE id = @id", con);
                            cmd.Parameters.AddWithValue("@id", row.Cells["id"].Value);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        MessageBox.Show("Record deleted successfully.");
                        LoadSubjectData(); // Reload data after deleting
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (editingRowIndex >= 0)
            {
                isEditing = true;
                textBox_name.Focus();
                textBox_faculty.Focus();
                textBox_subject.Focus();
                EnableControls();
            }
            else
            {
                MessageBox.Show("Please select a record to edit.");
            }
        }

        //Khi chọn 1 dòng trong DataGridView để sửa
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //khi ấn chọn 1 dòng trong DataGridView
            if (e.RowIndex >= 0)
            {
                //đặt trạng thai đang sửa
                isEditing = true;
                editingRowIndex = e.RowIndex;

                //Hiển thị dữ liệu của dòng đó lên các control
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox_name.Text = row.Cells["school"].Value.ToString();
                textBox_faculty.Text = row.Cells["faculty"].Value.ToString();
                textBox_subject.Text = row.Cells["subject"].Value.ToString();

                //Enable các control
                textBox_name.Enabled = true;
                textBox_faculty.Enabled = true;
                textBox_subject.Enabled = true;
                button_luu.Enabled = true;
                button_xoa.Enabled = true;
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            // Clear all input fields (textboxes)
            textBox_name.Clear();
            textBox_faculty.Clear();

            // Reload the data from the database to reset the DataGridView
            LoadSubjectData();

            // Reset the editing state and disable buttons for editing/deleting
            isEditing = false;
            editingRowIndex = -1;

            // Disable all controls that shouldn't be active after cancelling
            button_luu.Enabled = false;
            button_xoa.Enabled = false;
            button_sua.Enabled = false;

            // Optionally, disable the textboxes as well
            textBox_name.Enabled = false;
            textBox_faculty.Enabled = false;

            MessageBox.Show("Form has been reset.");
        }

        private void button_tim_Click(object sender, EventArgs e)
        {
            string searchSchool = textBox_name.Text.Trim();
            string searchFaculty = textBox_faculty.Text.Trim();
            string searchSubject = textBox_subject.Text.Trim();

            // Check if at least one field has input
            if (string.IsNullOrWhiteSpace(searchSchool) && string.IsNullOrWhiteSpace(searchFaculty) && string.IsNullOrWhiteSpace(searchSubject))
            {
                MessageBox.Show("Please enter at least one search field.");
                return;
            }

            // Dynamically build the SQL query based on the non-empty search fields
            List<string> conditions = new List<string>();

            if (!string.IsNullOrWhiteSpace(searchSchool))
            {
                conditions.Add("school LIKE @school");
            }
            if (!string.IsNullOrWhiteSpace(searchFaculty))
            {
                conditions.Add("faculty LIKE @faculty");
            }
            if (!string.IsNullOrWhiteSpace(searchSubject))
            {
                conditions.Add("subject LIKE @subject");
            }

            // Combine conditions with "AND" to form the WHERE clause
            string query = "SELECT id, school, faculty, subject FROM ut WHERE " + string.Join(" AND ", conditions);

            try
            {
                string connectionString = @"Data Source=ANH-QUAN;Initial Catalog=WinFormsApp1;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Add parameters for the query
                    if (!string.IsNullOrWhiteSpace(searchSchool))
                    {
                        cmd.Parameters.AddWithValue("@school", "%" + searchSchool + "%");
                    }
                    if (!string.IsNullOrWhiteSpace(searchFaculty))
                    {
                        cmd.Parameters.AddWithValue("@faculty", "%" + searchFaculty + "%");
                    }
                    if (!string.IsNullOrWhiteSpace(searchSubject))
                    {
                        cmd.Parameters.AddWithValue("@subject", "%" + searchSubject + "%");
                    }

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
