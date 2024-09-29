using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class New_School_Form : Form
    {
        public bool DataAdded { get; private set; } = false;

        public New_School_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Closes the form
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This method can be left empty if no behavior is required when text changes
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Corrected connection string
                SqlConnection con = new SqlConnection(@"Data Source=ANH-QUAN;Initial Catalog=WinFormsApp1;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
                con.Open();

                // SQL Insert command for table 'ut'
                SqlCommand cmd = new SqlCommand("INSERT INTO ut (school, faculty, subject) VALUES (@school, @faculty, @subject)", con);

                // Adding values from textboxes to the SQL parameters
                cmd.Parameters.AddWithValue("@school", textBox1.Text);
                cmd.Parameters.AddWithValue("@faculty", textBox2.Text);
                cmd.Parameters.AddWithValue("@subject", textBox3.Text);

                cmd.ExecuteNonQuery(); // Executes the SQL query
                con.Close();

                MessageBox.Show("School added successfully");

                DataAdded = true; // Set flag to true after successful addition
                this.DialogResult = DialogResult.OK; // Set the dialog result to OK to notify Form1
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
