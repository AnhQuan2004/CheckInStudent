using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Controls.UserControlSchool userControlSchool = new Controls.UserControlSchool();
        Controls.UserControlFaculty userControlFaculty = new Controls.UserControlFaculty();
        Controls.UserControlSubject userControlSubject = new Controls.UserControlSubject();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(); // Load data when the form loads
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Properly instantiate and open the New_School_Form
            using (New_School_Form newSchoolForm = new New_School_Form())
            {
                if (newSchoolForm.ShowDialog() == DialogResult.OK && newSchoolForm.DataAdded)
                {
                    // Reload the data in DataGridView after adding new school
                    LoadData();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Update_School updateSchool = new Update_School())
            {
                if (updateSchool.ShowDialog() == DialogResult.OK)
                {
                    // Reload the data in DataGridView after updating school
                    LoadData();
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            try
            {
                // Correct your connection string and query
                SqlConnection con = new SqlConnection(@"Data Source=ANH-QUAN;Initial Catalog=WinFormsApp1;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ut", con); // Ensure 'ut' is the correct table
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt; // Bind data to the DataGridView
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void panelSchool_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlSchool);
            userControlSchool.Dock = DockStyle.Fill;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelFaculty_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlFaculty);
            userControlFaculty.Dock = DockStyle.Fill;
        }

        private void PanelSubject_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlSubject);
            userControlSubject.Dock = DockStyle.Fill;
        }

    }
}
