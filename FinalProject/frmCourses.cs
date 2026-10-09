using FinalProject.CourseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject
{
    public partial class frmCourses : Form
    {
        private CourseDataSet courseDataSet = new CourseDataSet();
        private CoursesTableAdapter coursesAdapter = new CoursesTableAdapter();

        private int? editingCourseId = null;
        public frmCourses()
        {
            InitializeComponent();
            grpInPerson.Visible = false;
            grpOnline.Visible = false;
            grpHybrid.Visible = false;

            this.Load += frmCourses_Load;
            rbInPerson.CheckedChanged += Mode_CheckedChanged;
            rbOnline.CheckedChanged += Mode_CheckedChanged;
            rbHybrid.CheckedChanged += Mode_CheckedChanged;
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                coursesAdapter.Fill(courseDataSet.Courses);
                dgvCourses.DataSource = courseDataSet.Courses;
                if (dgvCourses.Columns["CourseId"] != null)
                    dgvCourses.Columns["CourseId"].Visible = false;

          
                dgvCourses.ClearSelection();
                dgvCourses.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
        }
        private void Mode_CheckedChanged(object sender, EventArgs e)
        {
            grpInPerson.Visible = rbInPerson.Checked || rbHybrid.Checked;
            grpOnline.Visible = rbOnline.Checked || rbHybrid.Checked;
            grpHybrid.Visible = rbHybrid.Checked;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Please fix the errors above.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                bool isNewRecord = !editingCourseId.HasValue;

                CourseDataSet.CoursesRow row;

                if (isNewRecord)
                {
                    row = courseDataSet.Courses.NewCoursesRow();
                }
                else
                {
                    
                    row = courseDataSet.Courses.FindByCourseId(editingCourseId.Value);
                }


                row.CourseCode = txtCourseCode.Text.Trim();
                row.CourseTitle = txtCourseTitle.Text.Trim();
                row.CourseDescription = txtCourseDescription.Text.Trim();
                row.Credits = int.Parse(txtCredits.Text);
                row.Level = int.Parse(cboLevel.Text);
                row.Mode = rbInPerson.Checked ? "In-Person" : rbOnline.Checked ? "Online" : "Hybrid";
                row.Building = (rbInPerson.Checked || rbHybrid.Checked) ? txtBuilding.Text.Trim() : "";
                row.Room = (rbInPerson.Checked || rbHybrid.Checked) ? txtRoom.Text.Trim() : "";
                row.MeetingTime = (rbInPerson.Checked || rbHybrid.Checked) ? txtMeetingTime.Text.Trim() : "";
                row.MeetingLink = (rbOnline.Checked || rbHybrid.Checked) ? txtMeetingLink.Text.Trim() : "";
                row.Proctored = (rbOnline.Checked || rbHybrid.Checked) && chkProctored.Checked;
                row.HybridMeetingType = rbHybrid.Checked ? txtHybridMeetingType.Text.Trim() : "";

                if (isNewRecord)
                {
                    courseDataSet.Courses.AddCoursesRow(row);
                }

             
                int affected = coursesAdapter.Update(courseDataSet.Courses);

                MessageBox.Show(isNewRecord
                    ? "Course added successfully to database!"
                    : "Course updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnReset_Click(sender, e);  
                LoadData();               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCourseCode.Clear();
            txtCourseTitle.Clear();
            txtCourseDescription.Clear();
            txtCredits.Clear();
            cboLevel.SelectedIndex = -1;
            rbInPerson.Checked = false;
            rbOnline.Checked = false;
            rbHybrid.Checked = false;

            txtBuilding.Clear();
            txtRoom.Clear();
            txtMeetingTime.Clear();

            txtMeetingLink.Clear();
            chkProctored.Checked = false;

            txtHybridMeetingType.Clear();

            grpInPerson.Visible = false;
            grpOnline.Visible = false;
            grpHybrid.Visible = false;

            txtCourseCode.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var view = dgvCourses.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (view == null) return;   

            var row = (CourseDataSet.CoursesRow)view.Row;

            editingCourseId = row.CourseId;

            txtCourseCode.Text = row.CourseCode;
            txtCourseTitle.Text = row.CourseTitle;
            txtCourseDescription.Text = row.CourseDescription;
            txtCredits.Text = row.Credits.ToString();
            cboLevel.Text = row.Level.ToString();

            rbInPerson.Checked = row.Mode == "In-Person";
            rbOnline.Checked = row.Mode == "Online";
            rbHybrid.Checked = row.Mode == "Hybrid";

            txtBuilding.Text = row.IsBuildingNull() ? "" : row.Building;
            txtRoom.Text = row.IsRoomNull() ? "" : row.Room;
            txtMeetingTime.Text = row.IsMeetingTimeNull() ? "" : row.MeetingTime;
            txtMeetingLink.Text = row.IsMeetingLinkNull() ? "" : row.MeetingLink;
            chkProctored.Checked = row.Proctored;
            txtHybridMeetingType.Text = row.IsHybridMeetingTypeNull() ? "" : row.HybridMeetingType;

            Mode_CheckedChanged(sender, e);
        }

        private bool ValidateInputs()
        {
            errorProvider.Clear();
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtCourseCode.Text)) { errorProvider.SetError(txtCourseCode, "Required"); ok = false; }
            if (string.IsNullOrWhiteSpace(txtCourseTitle.Text)) { errorProvider.SetError(txtCourseTitle, "Required"); ok = false; }
            if (!int.TryParse(txtCredits.Text, out int c) || c < 1 || c > 6) { errorProvider.SetError(txtCredits, "1-6"); ok = false; }
            if (cboLevel.SelectedIndex == -1) { errorProvider.SetError(cboLevel, "Selection"); ok = false; }
            if (!rbInPerson.Checked && !rbOnline.Checked && !rbHybrid.Checked) { errorProvider.SetError(grpMode, "Selection"); ok = false; }
            if ((rbInPerson.Checked || rbHybrid.Checked) && string.IsNullOrWhiteSpace(txtBuilding.Text)) { errorProvider.SetError(txtBuilding, "Required"); ok = false; }
            if ((rbInPerson.Checked || rbHybrid.Checked) && string.IsNullOrWhiteSpace(txtRoom.Text)) { errorProvider.SetError(txtRoom, "Required"); ok = false; }
            if ((rbOnline.Checked || rbHybrid.Checked) && string.IsNullOrWhiteSpace(txtMeetingLink.Text)) { errorProvider.SetError(txtMeetingLink, "Required"); ok = false; }
            if (rbHybrid.Checked && string.IsNullOrWhiteSpace(txtHybridMeetingType.Text)) { errorProvider.SetError(txtHybridMeetingType, "Required"); ok = false; }
            return ok;
        }
    }
}
