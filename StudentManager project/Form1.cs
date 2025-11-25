using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

=======
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager_project
{
    public partial class Form1 : Form
    {
>>>>>>> b402c15 (Intial comit: StudentManager project)
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void LoadGrid()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student st = new Student()
            {
                Id = txtId.Text,
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text)
            };

            students.Add(st);
            LoadGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var st = students.FirstOrDefault(x => x.Id == txtId.Text);

            if (st != null)
            {
                st.Name = txtName.Text;
                st.Age = int.Parse(txtAge.Text);
                LoadGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var st = students.FirstOrDefault(x => x.Id == txtId.Text);

            if (st != null)
            {
                students.Remove(st);
                LoadGrid();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();

            var result = students
                .Where(x => x.Id.ToLower().Contains(keyword)
                         || x.Name.ToLower().Contains(keyword))
                .ToList();

            dgvStudents.DataSource = null;
            dgvStudents.DataSource = result;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAge.Text = dgvStudents.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
=======
>>>>>>> b402c15 (Intial comit: StudentManager project)
    }
}
