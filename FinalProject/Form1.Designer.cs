namespace FinalProject
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCoursesToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importStudentsFromCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCoursesFromCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(512, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Courses";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem2.Text = "Students";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.exportCoursesToCSVToolStripMenuItem,
            this.importStudentsFromCSVToolStripMenuItem,
            this.importCoursesFromCSVToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(114, 20);
            this.toolStripMenuItem3.Text = "Import and Export";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.exportToolStripMenuItem.Text = "Export Students to CSV";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exportCoursesToCSVToolStripMenuItem
            // 
            this.exportCoursesToCSVToolStripMenuItem.Name = "exportCoursesToCSVToolStripMenuItem";
            this.exportCoursesToCSVToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.exportCoursesToCSVToolStripMenuItem.Text = "Export Courses to CSV";
            this.exportCoursesToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportCoursesToCSVToolStripMenuItem_Click);
            // 
            // importStudentsFromCSVToolStripMenuItem
            // 
            this.importStudentsFromCSVToolStripMenuItem.Name = "importStudentsFromCSVToolStripMenuItem";
            this.importStudentsFromCSVToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.importStudentsFromCSVToolStripMenuItem.Text = "Import Students from CSV";
            this.importStudentsFromCSVToolStripMenuItem.Click += new System.EventHandler(this.importStudentsFromCSVToolStripMenuItem_Click);
            // 
            // importCoursesFromCSVToolStripMenuItem
            // 
            this.importCoursesFromCSVToolStripMenuItem.Name = "importCoursesFromCSVToolStripMenuItem";
            this.importCoursesFromCSVToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.importCoursesFromCSVToolStripMenuItem.Text = "Import Courses from CSV";
            this.importCoursesFromCSVToolStripMenuItem.Click += new System.EventHandler(this.importCoursesFromCSVToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(512, 261);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "MainWindow";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCoursesToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importStudentsFromCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCoursesFromCSVToolStripMenuItem;
    }
}

