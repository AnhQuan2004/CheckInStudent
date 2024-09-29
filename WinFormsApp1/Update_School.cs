using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Update_School : Form
    {
        public Update_School()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=ANH-QUAN;Initial Catalog=WinFormsApp1;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
                connection.Open();

                // Assuming you have a textbox or another method to retrieve the 'id'
                SqlCommand command = new SqlCommand("UPDATE ut SET school = @school, faculty = @faculty, subject = @subject WHERE id = @id", connection);

                // Set the values for school, faculty, subject, and id
                command.Parameters.AddWithValue("@school", textBox1.Text);
                command.Parameters.AddWithValue("@faculty", textBox2.Text);
                command.Parameters.AddWithValue("@subject", textBox3.Text);
                command.Parameters.AddWithValue("@id", textBoxId.Text); // Make sure you have the control to get id

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("School updated successfully");

                // Set DialogResult to OK so that Form1 knows the update was successful
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void ClearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
