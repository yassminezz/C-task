using EntittyLab2.Models;
using System.Data;

namespace EntittyLab2
{
    public partial class Form1 : Form
    {
        CompanySdContext context = new CompanySdContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bind ComboBox to Departments
            comboBox1.DataSource = context.Departments.ToList();
            comboBox1.DisplayMember = "Dname";
            comboBox1.ValueMember = "Dnum";

            RefreshGridAndButtons();

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["Pname"].Value?.ToString() ?? "";
                textBox2.Text = dataGridView1.CurrentRow.Cells["Pnumber"].Value?.ToString() ?? "";
                textBox3.Text = dataGridView1.CurrentRow.Cells["Plocation"].Value?.ToString() ?? "";
                textBox4.Text = dataGridView1.CurrentRow.Cells["City"].Value?.ToString() ?? "";
                comboBox1.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Dnum"].Value ?? 0);
            }

            UpdateButtonStates();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox2.Text);
            string pname = textBox1.Text;
            string plocation = textBox3.Text;
            string pcity = textBox4.Text;
            int dnum = (int)comboBox1.SelectedValue;
            Project p = new Project
            {
                Pname = pname,
                Pnumber = id,
                Plocation = plocation,
                City = pcity,
                Dnum = dnum
            };
            if (context.Projects.Where(x => x.Pnumber == id).SingleOrDefault() == null)
            {
                context.Projects.Add(p);
                context.SaveChanges();
                MessageBox.Show("Project Inserted successfully.");

                RefreshGridAndButtons();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox2.Text);
            string pname = textBox1.Text;
            string plocation = textBox3.Text;
            string pcity = textBox4.Text;
            int dnum = (int)comboBox1.SelectedValue;
            var existing = context.Projects.SingleOrDefault(x => x.Pnumber == id);
            if (existing != null)
            {
                existing.Pname = pname;
                existing.Plocation = plocation;
                existing.City = pcity;
                existing.Dnum = dnum;

                context.SaveChanges();
                MessageBox.Show("Project Updated successfully.");

                RefreshGridAndButtons();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox2.Text);
            var p = context.Projects.SingleOrDefault(s => s.Pnumber == id);
            if (p != null)
            {
                context.Projects.Remove(p);
                context.SaveChanges();
                MessageBox.Show("Project deleted successfully.");

                RefreshGridAndButtons();
            }
        }

        private void RefreshGridAndButtons()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = context.Projects.ToList();

            if (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows[0].Selected = true;

            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            bool rowSelected = dataGridView1.CurrentRow != null;

            // Check if Pnumber in textbox2 exists
            bool idExists = int.TryParse(textBox2.Text, out int id) && context.Projects.Any(p => p.Pnumber == id);

            button1.Enabled = !idExists;   // Add enabled only if Pnumber is unique
            button3.Enabled = rowSelected; // Update enabled if a row is selected
            button2.Enabled = rowSelected; // Delete enabled if a row is selected
        }



    }
}
