using FinalProject.CourseDataSetTableAdapters;   
using FinalProject.StudentDataSetTableAdapters; 
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();


            ToolStripMenuItem importExportMenu = new ToolStripMenuItem("Import and Export");

            ToolStripMenuItem exportStudentsMenu = new ToolStripMenuItem("Export Students to CSV");
            ToolStripMenuItem exportCoursesMenu = new ToolStripMenuItem("Export Courses to CSV");
            ToolStripMenuItem importStudentsMenu = new ToolStripMenuItem("Import Students from CSV");
            ToolStripMenuItem importCoursesMenu = new ToolStripMenuItem("Import Courses from CSV");




            exportCoursesMenu.Click += (s, e) => ExportCoursesToCsv();
            exportStudentsMenu.Click += (s, e) => ExportStudentsCsv();
            importCoursesMenu.Click += (s, e) => ImportCsv(true);
            importStudentsMenu.Click += (s, e) => ImportCsv(false);
        }


        private void ExportCoursesToCsv(){ 
       
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "Courses.csv";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var adapter = new CoursesTableAdapter();
                    var table = adapter.GetData();

                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        sw.WriteLine("CourseId,CourseCode,CourseTitle,CourseDescription,Credits,Level,Mode,Building,Room,MeetingTime,MeetingLink,Proctored,HybridMeetingType");
                        foreach (var row in table)
                        {
                            string building = row.IsBuildingNull() ? "" : row.Building;
                            string room = row.IsRoomNull() ? "" : row.Room;
                            string meetingTime = row.IsMeetingTimeNull() ? "" : row.MeetingTime;
                            string meetingLink = row.IsMeetingLinkNull() ? "" : row.MeetingLink;
                            string hybridMeetingType = row.IsHybridMeetingTypeNull() ? "" : row.HybridMeetingType;

                            sw.WriteLine(
                                $"{row.CourseId}," +
                                $"{Escape(row.CourseCode)}," +
                                $"{Escape(row.CourseTitle)}," +
                                $"{Escape(row.CourseDescription)}," +
                                $"{row.Credits}," +
                                $"{row.Level}," +
                                $"{row.Mode}," +
                                $"{Escape(building)}," +
                                $"{Escape(room)}," +
                                $"{Escape(meetingTime)}," +
                                $"{Escape(meetingLink)}," +
                                $"{row.Proctored}," +
                                $"{Escape(hybridMeetingType)}"
                            );
                        
                    }
                    }
                    MessageBox.Show("Courses exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Could not open the file. Please check the file path.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You do not have permission to access that file.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("An error occurred while writing the file.\n" + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void ExportStudentsCsv()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "Students.csv";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var adapter = new StudentsTableAdapter();
                    var table = adapter.GetData();

                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        sw.WriteLine("StudentId,FirstName,LastName,Email,Major");
                        foreach (var row in table)
                        {
                            string major = row.IsMajorNull() ? "" : row.Major;

                            sw.WriteLine(
                                $"{row.StudentId}," +
                                $"{Escape(row.FirstName)}," +
                                $"{Escape(row.LastName)}," +
                                $"{Escape(row.Email)}," +
                                $"{Escape(major)}"
                            );
                        }
                    }
                    MessageBox.Show("Students exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Could not open the file. Please check the file path.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You do not have permission to access that file.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("An error occurred while writing the file.\n" + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    
        private void ImportCsv(bool isCourses)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV files (*.csv)|*.csv";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var lines = File.ReadAllLines(ofd.FileName);
                    int count = 0;

                    if (isCourses)
                    {
                        var adapter = new CoursesTableAdapter();
                        foreach (string line in lines.Skip(1))
                        {
                            var cols = line.Split(',');
                            if (cols.Length >= 6)
                            {
                                adapter.Insert(cols[1], cols[2], cols.Length > 3 ? cols[3] : "", int.Parse(cols[4]), int.Parse(cols[5]), "In-Person", "", "", "", "", false, "");
                                count++;
                            }
                        }
                    }
                    else
                    {
                        var adapter = new StudentsTableAdapter();
                        foreach (string line in lines.Skip(1)) 
                        {
                            var cols = line.Split(','); 
                            if (cols.Length >= 4)
                            {
                                string major = cols.Length > 4 ? cols[4] : null; 

                                adapter.Insert(
                                    cols[1].Trim(),   
                                    cols[2].Trim(),   
                                    cols[3].Trim(),  
                                    major              
                                );
                                count++;
                            }
                        }
                    }

                    MessageBox.Show($"{count} records imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Could not open the file. Please check the file path.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You do not have permission to access that file.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("An error occurred while reading the file.\n" + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during import:\n" + ex.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    
        private string Escape(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            return "\"" + s.Replace("\"", "\"\"") + "\"";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmCourses();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frm = new frmStudents();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportCoursesToCsv();
        }

        private void exportCoursesToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportStudentsCsv();
        }

        private void importStudentsFromCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportCsv(false);
        }

        private void importCoursesFromCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportCsv(true);
        }
    }
}