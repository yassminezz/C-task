using EntityDay3.Models;

namespace EntityDay3
{
    public partial class Form1 : Form
    {
        AppDbContext context = new AppDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill departments into ComboBox
            comboBox1.DataSource = context.Departments.ToList();
            comboBox1.DisplayMember = "DeptName";
            comboBox1.ValueMember = "DeptID";

            RefreshGridAndButtons();

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void button1_Click(object sender, EventArgs e) // Insert
        {
            string pname = textBox1.Text;    // Project name
            string plocation = textBox3.Text; // Project location
            string pcity = textBox4.Text;     // Project city
            int deptId = (int)comboBox1.SelectedValue; // Department id (foreign key)

            Project p = new Project
            {
                Pname = pname,
                Plocation = plocation,
                City = pcity,
                DeptID = deptId   // ✅ correct FK
                // Pnumber is identity → no need to set it
            };

            context.Projects.Add(p);
            context.SaveChanges();
            MessageBox.Show("Project Inserted successfully.");

            RefreshGridAndButtons();
        }

        private void button2_Click(object sender, EventArgs e) // Update
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Pnumber"].Value; // Use identity from grid
                var existing = context.Projects.SingleOrDefault(x => x.Pnumber == id);

                if (existing != null)
                {
                    existing.Pname = textBox1.Text;
                    existing.Plocation = textBox3.Text;
                    existing.City = textBox4.Text;
                    existing.DeptID = (int)comboBox1.SelectedValue;  // ✅ fixed

                    context.SaveChanges();
                    MessageBox.Show("Project Updated successfully.");

                    RefreshGridAndButtons();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // Delete
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Pnumber"].Value; // Use identity from grid
                var p = context.Projects.SingleOrDefault(s => s.Pnumber == id);

                if (p != null)
                {
                    context.Projects.Remove(p);
                    context.SaveChanges();
                    MessageBox.Show("Project deleted successfully.");

                    RefreshGridAndButtons();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["Pname"].Value?.ToString() ?? "";
                textBox3.Text = dataGridView1.CurrentRow.Cells["Plocation"].Value?.ToString() ?? "";
                textBox4.Text = dataGridView1.CurrentRow.Cells["City"].Value?.ToString() ?? "";
                comboBox1.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells["DeptID"].Value ?? 0); // ✅ fixed
            }

            UpdateButtonStates();
        }

        private void RefreshGridAndButtons()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = context.Projects.ToList();

            if (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows[0].Selected = true;

            UpdateButtonStates();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Example: enable Insert only if project name is not empty
            button1.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text);
        }

        private void UpdateButtonStates()
        {
            bool rowSelected = dataGridView1.CurrentRow != null;

            button1.Enabled = true;        // Insert always enabled
            button3.Enabled = rowSelected; // Update enabled only when a row is selected
            button2.Enabled = rowSelected; // Delete enabled only when a row is selected
        }
    }
}
