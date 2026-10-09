namespace FinalProject
{
    partial class frmCourses
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
            this.components = new System.ComponentModel.Container();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.lblCourseDescription = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.rbInPerson = new System.Windows.Forms.RadioButton();
            this.rbOnline = new System.Windows.Forms.RadioButton();
            this.rbHybrid = new System.Windows.Forms.RadioButton();
            this.grpInPerson = new System.Windows.Forms.GroupBox();
            this.txtMeetingTime = new System.Windows.Forms.TextBox();
            this.lblMeeting = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.grpOnline = new System.Windows.Forms.GroupBox();
            this.chkProctored = new System.Windows.Forms.CheckBox();
            this.lblProctoring = new System.Windows.Forms.Label();
            this.txtMeetingLink = new System.Windows.Forms.TextBox();
            this.lblMeetingLink = new System.Windows.Forms.Label();
            this.grpHybrid = new System.Windows.Forms.GroupBox();
            this.txtHybridMeetingType = new System.Windows.Forms.TextBox();
            this.lblHybridMeetingType = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proctoredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hybridMeetingTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDataSet1 = new FinalProject.CourseDataSet();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.masterDataSet = new FinalProject.masterDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter1 = new FinalProject.masterDataSetTableAdapters.CoursesTableAdapter();
            this.coursesTableAdapter2 = new FinalProject.CourseDataSetTableAdapters.CoursesTableAdapter();
            this.grpInPerson.SuspendLayout();
            this.grpOnline.SuspendLayout();
            this.grpHybrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grpMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(74, 36);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(67, 12);
            this.lblCourseCode.TabIndex = 0;
            this.lblCourseCode.Text = "CourseCode";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(211, 33);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(100, 19);
            this.txtCourseCode.TabIndex = 0;
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.Location = new System.Drawing.Point(361, 36);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(64, 12);
            this.lblCourseTitle.TabIndex = 2;
            this.lblCourseTitle.Text = "CourseTitle";
            // 
            // lblCourseDescription
            // 
            this.lblCourseDescription.AutoSize = true;
            this.lblCourseDescription.Location = new System.Drawing.Point(74, 67);
            this.lblCourseDescription.Name = "lblCourseDescription";
            this.lblCourseDescription.Size = new System.Drawing.Size(99, 12);
            this.lblCourseDescription.TabIndex = 3;
            this.lblCourseDescription.Text = "CourseDescription";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(74, 97);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(42, 12);
            this.lblCredits.TabIndex = 4;
            this.lblCredits.Text = "Credits";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(379, 100);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(32, 12);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Level";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(84, 154);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(32, 12);
            this.lblMode.TabIndex = 6;
            this.lblMode.Text = "Mode";
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Location = new System.Drawing.Point(210, 67);
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.Size = new System.Drawing.Size(328, 19);
            this.txtCourseDescription.TabIndex = 2;
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(431, 33);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(100, 19);
            this.txtCourseTitle.TabIndex = 1;
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(211, 97);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(100, 19);
            this.txtCredits.TabIndex = 3;
            // 
            // cboLevel
            // 
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000"});
            this.cboLevel.Location = new System.Drawing.Point(417, 97);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(121, 20);
            this.cboLevel.TabIndex = 4;
            // 
            // rbInPerson
            // 
            this.rbInPerson.AutoSize = true;
            this.rbInPerson.Location = new System.Drawing.Point(6, 18);
            this.rbInPerson.Name = "rbInPerson";
            this.rbInPerson.Size = new System.Drawing.Size(73, 16);
            this.rbInPerson.TabIndex = 5;
            this.rbInPerson.TabStop = true;
            this.rbInPerson.Text = "In-Person";
            this.rbInPerson.UseVisualStyleBackColor = true;
            // 
            // rbOnline
            // 
            this.rbOnline.AutoSize = true;
            this.rbOnline.Location = new System.Drawing.Point(115, 20);
            this.rbOnline.Name = "rbOnline";
            this.rbOnline.Size = new System.Drawing.Size(55, 16);
            this.rbOnline.TabIndex = 6;
            this.rbOnline.TabStop = true;
            this.rbOnline.Text = "Online";
            this.rbOnline.UseVisualStyleBackColor = true;
            // 
            // rbHybrid
            // 
            this.rbHybrid.AutoSize = true;
            this.rbHybrid.Location = new System.Drawing.Point(212, 20);
            this.rbHybrid.Name = "rbHybrid";
            this.rbHybrid.Size = new System.Drawing.Size(56, 16);
            this.rbHybrid.TabIndex = 7;
            this.rbHybrid.TabStop = true;
            this.rbHybrid.Text = "Hybrid";
            this.rbHybrid.UseVisualStyleBackColor = true;
            // 
            // grpInPerson
            // 
            this.grpInPerson.Controls.Add(this.txtMeetingTime);
            this.grpInPerson.Controls.Add(this.lblMeeting);
            this.grpInPerson.Controls.Add(this.txtRoom);
            this.grpInPerson.Controls.Add(this.lblRoom);
            this.grpInPerson.Controls.Add(this.txtBuilding);
            this.grpInPerson.Controls.Add(this.lblBuilding);
            this.grpInPerson.Location = new System.Drawing.Point(76, 198);
            this.grpInPerson.Name = "grpInPerson";
            this.grpInPerson.Size = new System.Drawing.Size(180, 171);
            this.grpInPerson.TabIndex = 14;
            this.grpInPerson.TabStop = false;
            this.grpInPerson.Text = "In-Person Group";
            // 
            // txtMeetingTime
            // 
            this.txtMeetingTime.Location = new System.Drawing.Point(20, 130);
            this.txtMeetingTime.Name = "txtMeetingTime";
            this.txtMeetingTime.Size = new System.Drawing.Size(100, 19);
            this.txtMeetingTime.TabIndex = 2;
            // 
            // lblMeeting
            // 
            this.lblMeeting.AutoSize = true;
            this.lblMeeting.Location = new System.Drawing.Point(18, 115);
            this.lblMeeting.Name = "lblMeeting";
            this.lblMeeting.Size = new System.Drawing.Size(74, 12);
            this.lblMeeting.TabIndex = 4;
            this.lblMeeting.Text = "Meeting Time";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(20, 93);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(100, 19);
            this.txtRoom.TabIndex = 1;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(18, 78);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(34, 12);
            this.lblRoom.TabIndex = 2;
            this.lblRoom.Text = "Room";
            // 
            // txtBuilding
            // 
            this.txtBuilding.Location = new System.Drawing.Point(20, 46);
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.Size = new System.Drawing.Size(100, 19);
            this.txtBuilding.TabIndex = 0;
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Location = new System.Drawing.Point(18, 31);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(50, 12);
            this.lblBuilding.TabIndex = 5;
            this.lblBuilding.Text = "Building ";
            // 
            // grpOnline
            // 
            this.grpOnline.Controls.Add(this.chkProctored);
            this.grpOnline.Controls.Add(this.lblProctoring);
            this.grpOnline.Controls.Add(this.txtMeetingLink);
            this.grpOnline.Controls.Add(this.lblMeetingLink);
            this.grpOnline.Location = new System.Drawing.Point(303, 198);
            this.grpOnline.Name = "grpOnline";
            this.grpOnline.Size = new System.Drawing.Size(175, 171);
            this.grpOnline.TabIndex = 15;
            this.grpOnline.TabStop = false;
            this.grpOnline.Text = "Online Group";
            // 
            // chkProctored
            // 
            this.chkProctored.AutoSize = true;
            this.chkProctored.Location = new System.Drawing.Point(22, 96);
            this.chkProctored.Name = "chkProctored";
            this.chkProctored.Size = new System.Drawing.Size(15, 14);
            this.chkProctored.TabIndex = 1;
            this.chkProctored.UseVisualStyleBackColor = true;
            // 
            // lblProctoring
            // 
            this.lblProctoring.AutoSize = true;
            this.lblProctoring.Location = new System.Drawing.Point(20, 78);
            this.lblProctoring.Name = "lblProctoring";
            this.lblProctoring.Size = new System.Drawing.Size(54, 12);
            this.lblProctoring.TabIndex = 3;
            this.lblProctoring.Text = "Proctored";
            // 
            // txtMeetingLink
            // 
            this.txtMeetingLink.Location = new System.Drawing.Point(22, 46);
            this.txtMeetingLink.Name = "txtMeetingLink";
            this.txtMeetingLink.Size = new System.Drawing.Size(100, 19);
            this.txtMeetingLink.TabIndex = 0;
            // 
            // lblMeetingLink
            // 
            this.lblMeetingLink.AutoSize = true;
            this.lblMeetingLink.Location = new System.Drawing.Point(20, 31);
            this.lblMeetingLink.Name = "lblMeetingLink";
            this.lblMeetingLink.Size = new System.Drawing.Size(70, 12);
            this.lblMeetingLink.TabIndex = 1;
            this.lblMeetingLink.Text = "Meeting Link";
            // 
            // grpHybrid
            // 
            this.grpHybrid.Controls.Add(this.txtHybridMeetingType);
            this.grpHybrid.Controls.Add(this.lblHybridMeetingType);
            this.grpHybrid.Location = new System.Drawing.Point(516, 198);
            this.grpHybrid.Name = "grpHybrid";
            this.grpHybrid.Size = new System.Drawing.Size(180, 171);
            this.grpHybrid.TabIndex = 16;
            this.grpHybrid.TabStop = false;
            this.grpHybrid.Text = "Hybrid Group";
            // 
            // txtHybridMeetingType
            // 
            this.txtHybridMeetingType.Location = new System.Drawing.Point(21, 46);
            this.txtHybridMeetingType.Name = "txtHybridMeetingType";
            this.txtHybridMeetingType.Size = new System.Drawing.Size(100, 19);
            this.txtHybridMeetingType.TabIndex = 0;
            // 
            // lblHybridMeetingType
            // 
            this.lblHybridMeetingType.AutoSize = true;
            this.lblHybridMeetingType.Location = new System.Drawing.Point(19, 31);
            this.lblHybridMeetingType.Name = "lblHybridMeetingType";
            this.lblHybridMeetingType.Size = new System.Drawing.Size(111, 12);
            this.lblHybridMeetingType.TabIndex = 2;
            this.lblHybridMeetingType.Text = "Hybrid Meeting Type";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(76, 410);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(194, 410);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // dgvCourses
            // 
            this.dgvCourses.AutoGenerateColumns = false;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseCodeDataGridViewTextBoxColumn,
            this.courseTitleDataGridViewTextBoxColumn,
            this.courseDescriptionDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.modeDataGridViewTextBoxColumn,
            this.buildingDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.meetingTimeDataGridViewTextBoxColumn,
            this.meetingLinkDataGridViewTextBoxColumn,
            this.proctoredDataGridViewCheckBoxColumn,
            this.hybridMeetingTypeDataGridViewTextBoxColumn});
            this.dgvCourses.DataSource = this.coursesBindingSource1;
            this.dgvCourses.Location = new System.Drawing.Point(76, 451);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowTemplate.Height = 21;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(620, 204);
            this.dgvCourses.TabIndex = 20;
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "CourseId";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "CourseId";
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "CourseCode";
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "CourseCode";
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            // 
            // courseTitleDataGridViewTextBoxColumn
            // 
            this.courseTitleDataGridViewTextBoxColumn.DataPropertyName = "CourseTitle";
            this.courseTitleDataGridViewTextBoxColumn.HeaderText = "CourseTitle";
            this.courseTitleDataGridViewTextBoxColumn.Name = "courseTitleDataGridViewTextBoxColumn";
            // 
            // courseDescriptionDataGridViewTextBoxColumn
            // 
            this.courseDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CourseDescription";
            this.courseDescriptionDataGridViewTextBoxColumn.HeaderText = "CourseDescription";
            this.courseDescriptionDataGridViewTextBoxColumn.Name = "courseDescriptionDataGridViewTextBoxColumn";
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "Credits";
            this.creditsDataGridViewTextBoxColumn.HeaderText = "Credits";
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            // 
            // modeDataGridViewTextBoxColumn
            // 
            this.modeDataGridViewTextBoxColumn.DataPropertyName = "Mode";
            this.modeDataGridViewTextBoxColumn.HeaderText = "Mode";
            this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            // 
            // buildingDataGridViewTextBoxColumn
            // 
            this.buildingDataGridViewTextBoxColumn.DataPropertyName = "Building";
            this.buildingDataGridViewTextBoxColumn.HeaderText = "Building";
            this.buildingDataGridViewTextBoxColumn.Name = "buildingDataGridViewTextBoxColumn";
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // meetingTimeDataGridViewTextBoxColumn
            // 
            this.meetingTimeDataGridViewTextBoxColumn.DataPropertyName = "MeetingTime";
            this.meetingTimeDataGridViewTextBoxColumn.HeaderText = "MeetingTime";
            this.meetingTimeDataGridViewTextBoxColumn.Name = "meetingTimeDataGridViewTextBoxColumn";
            // 
            // meetingLinkDataGridViewTextBoxColumn
            // 
            this.meetingLinkDataGridViewTextBoxColumn.DataPropertyName = "MeetingLink";
            this.meetingLinkDataGridViewTextBoxColumn.HeaderText = "MeetingLink";
            this.meetingLinkDataGridViewTextBoxColumn.Name = "meetingLinkDataGridViewTextBoxColumn";
            // 
            // proctoredDataGridViewCheckBoxColumn
            // 
            this.proctoredDataGridViewCheckBoxColumn.DataPropertyName = "Proctored";
            this.proctoredDataGridViewCheckBoxColumn.HeaderText = "Proctored";
            this.proctoredDataGridViewCheckBoxColumn.Name = "proctoredDataGridViewCheckBoxColumn";
            // 
            // hybridMeetingTypeDataGridViewTextBoxColumn
            // 
            this.hybridMeetingTypeDataGridViewTextBoxColumn.DataPropertyName = "HybridMeetingType";
            this.hybridMeetingTypeDataGridViewTextBoxColumn.HeaderText = "HybridMeetingType";
            this.hybridMeetingTypeDataGridViewTextBoxColumn.Name = "hybridMeetingTypeDataGridViewTextBoxColumn";
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "Courses";
            this.coursesBindingSource1.DataSource = this.courseDataSet1BindingSource;
            // 
            // courseDataSet1BindingSource
            // 
            this.courseDataSet1BindingSource.DataSource = this.courseDataSet1;
            this.courseDataSet1BindingSource.Position = 0;
            // 
            // courseDataSet1
            // 
            this.courseDataSet1.DataSetName = "CourseDataSet";
            this.courseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(305, 410);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.rbInPerson);
            this.grpMode.Controls.Add(this.rbOnline);
            this.grpMode.Controls.Add(this.rbHybrid);
            this.grpMode.Location = new System.Drawing.Point(210, 136);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(286, 42);
            this.grpMode.TabIndex = 22;
            this.grpMode.TabStop = false;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.masterDataSet;
            // 
            // coursesTableAdapter1
            // 
            this.coursesTableAdapter1.ClearBeforeFill = true;
            // 
            // coursesTableAdapter2
            // 
            this.coursesTableAdapter2.ClearBeforeFill = true;
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 697);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpHybrid);
            this.Controls.Add(this.grpOnline);
            this.Controls.Add(this.grpInPerson);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.txtCourseDescription);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblCourseDescription);
            this.Controls.Add(this.lblCourseTitle);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.lblCourseCode);
            this.Name = "frmCourses";
            this.Text = "Student Grade Tracker";
            this.grpInPerson.ResumeLayout(false);
            this.grpInPerson.PerformLayout();
            this.grpOnline.ResumeLayout(false);
            this.grpOnline.PerformLayout();
            this.grpHybrid.ResumeLayout(false);
            this.grpHybrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.Label lblCourseDescription;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtCourseDescription;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.RadioButton rbInPerson;
        private System.Windows.Forms.RadioButton rbOnline;
        private System.Windows.Forms.RadioButton rbHybrid;
        private System.Windows.Forms.GroupBox grpInPerson;
        private System.Windows.Forms.GroupBox grpOnline;
        private System.Windows.Forms.GroupBox grpHybrid;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.TextBox txtMeetingTime;
        private System.Windows.Forms.Label lblMeeting;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.CheckBox chkProctored;
        private System.Windows.Forms.Label lblProctoring;
        private System.Windows.Forms.TextBox txtMeetingLink;
        private System.Windows.Forms.Label lblMeetingLink;
        private System.Windows.Forms.Label lblHybridMeetingType;
        private System.Windows.Forms.TextBox txtHybridMeetingType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grpMode;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private masterDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter1;
        private System.Windows.Forms.BindingSource courseDataSet1BindingSource;
        private CourseDataSet courseDataSet1;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
        private CourseDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn proctoredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hybridMeetingTypeDataGridViewTextBoxColumn;
    }
}