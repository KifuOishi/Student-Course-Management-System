using FinalProject.StudentDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmStudents : Form
    {
        private StudentDataSet studentDataSet = new StudentDataSet();
        private StudentsTableAdapter studentsAdapter = new StudentsTableAdapter();

        public frmStudents()
        {
            InitializeComponent();
            this.Load += frmStudents_Load;
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                studentsAdapter.Fill(studentDataSet.Students);
                dgvStudents.DataSource = studentDataSet.Students;
                if (dgvStudents.Columns["StudentId"] != null)
                    dgvStudents.Columns["StudentId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load students: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            errorProvider1.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "First Name is required");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Last Name is required");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email is required");
                valid = false;
            }
            else if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                errorProvider1.SetError(txtEmail, "Please enter a valid email address");
                valid = false;
            }

            return valid;
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Please select a student to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                var row = (StudentDataSet.StudentsRow)((DataRowView)dgvStudents.CurrentRow.DataBoundItem).Row;

                row.FirstName = txtFirstName.Text.Trim();
                row.LastName = txtLastName.Text.Trim();
                row.Email = txtEmail.Text.Trim();
                row.Major = txtMajor.Text.Trim();

                studentsAdapter.Update(studentDataSet.Students);

                MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtMajor.Clear();
            errorProvider1.Clear();
            txtFirstName.Focus();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var view = dgvStudents.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (view == null) return;  

            var row = (StudentDataSet.StudentsRow)view.Row;
            txtFirstName.Text = row.FirstName;
            txtLastName.Text = row.LastName;
            txtEmail.Text = row.Email;
            txtMajor.Text = row.IsMajorNull() ? "" : row.Major;
            errorProvider1.Clear();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {

                var newRow = studentDataSet.Students.NewStudentsRow();
                newRow.FirstName = txtFirstName.Text.Trim();
                newRow.LastName = txtLastName.Text.Trim();
                newRow.Email = txtEmail.Text.Trim();
                newRow.Major = txtMajor.Text.Trim();

                studentDataSet.Students.AddStudentsRow(newRow);


                studentsAdapter.Update(studentDataSet.Students);

                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Please select a student to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var row = (StudentDataSet.StudentsRow)((DataRowView)dgvStudents.CurrentRow.DataBoundItem).Row;
                    row.Delete();
                    studentsAdapter.Update(studentDataSet.Students);

                    MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
            dgvStudents.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
