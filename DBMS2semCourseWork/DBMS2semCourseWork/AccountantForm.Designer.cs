
namespace DBMS2semCourseWork
{
    partial class AccountantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantForm));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ChTableToProjs = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.UpdateDatabase = new System.Windows.Forms.ToolStripButton();
            this.ChTableToDeptsEmpls = new System.Windows.Forms.Button();
            this.ChTableToDepts = new System.Windows.Forms.Button();
            this.ChTableToEmpls = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EndProj = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateStartCursor = new System.Windows.Forms.DateTimePicker();
            this.MonthExpensesForProjs = new System.Windows.Forms.Button();
            this.MonthExpensesForProjects = new System.Windows.Forms.RichTextBox();
            this.DeptsAndAvgWorkTime = new System.Windows.Forms.RichTextBox();
            this.DeptNameForRec = new System.Windows.Forms.TextBox();
            this.RecWorkTimeProjForDep = new System.Windows.Forms.RichTextBox();
            this.ProjAndWorkersForPeriod = new System.Windows.Forms.RichTextBox();
            this.ProfOfProjForPeriod = new System.Windows.Forms.RichTextBox();
            this.ProfOfNotEndProj = new System.Windows.Forms.RichTextBox();
            this.ProjAndWorkers = new System.Windows.Forms.RichTextBox();
            this.ProjEndByToday = new System.Windows.Forms.RichTextBox();
            this.ShowDeptsAndAvgTimeWork = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ShowRecordTimeProjForDept = new System.Windows.Forms.Button();
            this.DateRealEndOfProj = new System.Windows.Forms.Label();
            this.DateBegOfProj = new System.Windows.Forms.Label();
            this.DateEnd = new System.Windows.Forms.MonthCalendar();
            this.DateBeg = new System.Windows.Forms.MonthCalendar();
            this.ShowProjAndWorkersForPeriod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StartingDateForProfByPeriod = new System.Windows.Forms.MonthCalendar();
            this.ExecCursor = new System.Windows.Forms.Button();
            this.ShowProfOfNonEndProjects = new System.Windows.Forms.Button();
            this.ShowProjAndWorkers = new System.Windows.Forms.Button();
            this.ShowProjEndednByToday = new System.Windows.Forms.Button();
            this.ProjEndedByToday = new System.Windows.Forms.DataGridView();
            this.ProjAndEmpls = new System.Windows.Forms.DataGridView();
            this.ProfOfNonEndedProjs = new System.Windows.Forms.DataGridView();
            this.ProjAndEmplsForPer = new System.Windows.Forms.DataGridView();
            this.DeptsAndAvgTimeOfWork = new System.Windows.Forms.DataGridView();
            this.MonthExpenses = new System.Windows.Forms.DataGridView();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.EndProj.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjEndedByToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjAndEmpls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfOfNonEndedProjs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjAndEmplsForPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptsAndAvgTimeOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage2.Controls.Add(this.ChTableToProjs);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Controls.Add(this.ChTableToDeptsEmpls);
            this.tabPage2.Controls.Add(this.ChTableToDepts);
            this.tabPage2.Controls.Add(this.ChTableToEmpls);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1792, 874);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Working with Tables";
            // 
            // ChTableToProjs
            // 
            this.ChTableToProjs.Location = new System.Drawing.Point(1242, 694);
            this.ChTableToProjs.Name = "ChTableToProjs";
            this.ChTableToProjs.Size = new System.Drawing.Size(329, 82);
            this.ChTableToProjs.TabIndex = 10;
            this.ChTableToProjs.Text = "Change active table to Projects";
            this.ChTableToProjs.UseVisualStyleBackColor = true;
            this.ChTableToProjs.Click += new System.EventHandler(this.ChTableToProjs_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Turquoise;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateDatabase});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1786, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // UpdateDatabase
            // 
            this.UpdateDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UpdateDatabase.Image = ((System.Drawing.Image)(resources.GetObject("UpdateDatabase.Image")));
            this.UpdateDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateDatabase.Name = "UpdateDatabase";
            this.UpdateDatabase.Size = new System.Drawing.Size(100, 22);
            this.UpdateDatabase.Text = "Update Database";
            // 
            // ChTableToDeptsEmpls
            // 
            this.ChTableToDeptsEmpls.Location = new System.Drawing.Point(1242, 509);
            this.ChTableToDeptsEmpls.Name = "ChTableToDeptsEmpls";
            this.ChTableToDeptsEmpls.Size = new System.Drawing.Size(329, 82);
            this.ChTableToDeptsEmpls.TabIndex = 8;
            this.ChTableToDeptsEmpls.Text = "Change active table to Departments-Employees";
            this.ChTableToDeptsEmpls.UseVisualStyleBackColor = true;
            this.ChTableToDeptsEmpls.Click += new System.EventHandler(this.ChTableToDeptsEmpls_Click);
            // 
            // ChTableToDepts
            // 
            this.ChTableToDepts.Location = new System.Drawing.Point(1242, 281);
            this.ChTableToDepts.Name = "ChTableToDepts";
            this.ChTableToDepts.Size = new System.Drawing.Size(329, 82);
            this.ChTableToDepts.TabIndex = 7;
            this.ChTableToDepts.Text = "Change active table to Departments";
            this.ChTableToDepts.UseVisualStyleBackColor = true;
            this.ChTableToDepts.Click += new System.EventHandler(this.ChTableToDepts_Click);
            // 
            // ChTableToEmpls
            // 
            this.ChTableToEmpls.Location = new System.Drawing.Point(1242, 74);
            this.ChTableToEmpls.Name = "ChTableToEmpls";
            this.ChTableToEmpls.Size = new System.Drawing.Size(329, 82);
            this.ChTableToEmpls.TabIndex = 6;
            this.ChTableToEmpls.Text = "Change active table to Employees";
            this.ChTableToEmpls.UseVisualStyleBackColor = true;
            this.ChTableToEmpls.Click += new System.EventHandler(this.ChTableToEmpls_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 763);
            this.dataGridView1.TabIndex = 0;
            // 
            // EndProj
            // 
            this.EndProj.Controls.Add(this.tabPage1);
            this.EndProj.Controls.Add(this.tabPage2);
            this.EndProj.Location = new System.Drawing.Point(13, 13);
            this.EndProj.Multiline = true;
            this.EndProj.Name = "EndProj";
            this.EndProj.SelectedIndex = 0;
            this.EndProj.Size = new System.Drawing.Size(1800, 900);
            this.EndProj.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage1.Controls.Add(this.MonthExpenses);
            this.tabPage1.Controls.Add(this.DeptsAndAvgTimeOfWork);
            this.tabPage1.Controls.Add(this.ProjAndEmplsForPer);
            this.tabPage1.Controls.Add(this.ProfOfNonEndedProjs);
            this.tabPage1.Controls.Add(this.ProjAndEmpls);
            this.tabPage1.Controls.Add(this.ProjEndedByToday);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DateStartCursor);
            this.tabPage1.Controls.Add(this.MonthExpensesForProjs);
            this.tabPage1.Controls.Add(this.MonthExpensesForProjects);
            this.tabPage1.Controls.Add(this.DeptsAndAvgWorkTime);
            this.tabPage1.Controls.Add(this.DeptNameForRec);
            this.tabPage1.Controls.Add(this.RecWorkTimeProjForDep);
            this.tabPage1.Controls.Add(this.ProjAndWorkersForPeriod);
            this.tabPage1.Controls.Add(this.ProfOfProjForPeriod);
            this.tabPage1.Controls.Add(this.ProfOfNotEndProj);
            this.tabPage1.Controls.Add(this.ProjAndWorkers);
            this.tabPage1.Controls.Add(this.ProjEndByToday);
            this.tabPage1.Controls.Add(this.ShowDeptsAndAvgTimeWork);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.ShowRecordTimeProjForDept);
            this.tabPage1.Controls.Add(this.DateRealEndOfProj);
            this.tabPage1.Controls.Add(this.DateBegOfProj);
            this.tabPage1.Controls.Add(this.DateEnd);
            this.tabPage1.Controls.Add(this.DateBeg);
            this.tabPage1.Controls.Add(this.ShowProjAndWorkersForPeriod);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.StartingDateForProfByPeriod);
            this.tabPage1.Controls.Add(this.ExecCursor);
            this.tabPage1.Controls.Add(this.ShowProfOfNonEndProjects);
            this.tabPage1.Controls.Add(this.ShowProjAndWorkers);
            this.tabPage1.Controls.Add(this.ShowProjEndednByToday);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1792, 874);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operations";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(531, 696);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Days of Work";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(527, 788);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "DepartmentID";
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1656, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Date End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1660, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Date Begin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1408, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Date Begin";
            // 
            // DateStartCursor
            // 
            this.DateStartCursor.CustomFormat = "yyyy-MM-dd";
            this.DateStartCursor.Location = new System.Drawing.Point(1711, 582);
            this.DateStartCursor.Name = "DateStartCursor";
            this.DateStartCursor.Size = new System.Drawing.Size(51, 20);
            this.DateStartCursor.TabIndex = 34;
            this.DateStartCursor.Visible = false;
            // 
            // MonthExpensesForProjs
            // 
            this.MonthExpensesForProjs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthExpensesForProjs.Location = new System.Drawing.Point(1377, 624);
            this.MonthExpensesForProjs.Name = "MonthExpensesForProjs";
            this.MonthExpensesForProjs.Size = new System.Drawing.Size(329, 44);
            this.MonthExpensesForProjs.TabIndex = 31;
            this.MonthExpensesForProjs.Text = "Month Expenses For Projects";
            this.MonthExpensesForProjs.UseVisualStyleBackColor = true;
            this.MonthExpensesForProjs.Click += new System.EventHandler(this.MonthExpensesForProjs_Click);
            // 
            // MonthExpensesForProjects
            // 
            this.MonthExpensesForProjects.Location = new System.Drawing.Point(1728, 624);
            this.MonthExpensesForProjects.Name = "MonthExpensesForProjects";
            this.MonthExpensesForProjects.Size = new System.Drawing.Size(16, 13);
            this.MonthExpensesForProjects.TabIndex = 30;
            this.MonthExpensesForProjects.Text = "";
            this.MonthExpensesForProjects.Visible = false;
            // 
            // DeptsAndAvgWorkTime
            // 
            this.DeptsAndAvgWorkTime.Location = new System.Drawing.Point(590, 748);
            this.DeptsAndAvgWorkTime.Name = "DeptsAndAvgWorkTime";
            this.DeptsAndAvgWorkTime.Size = new System.Drawing.Size(23, 15);
            this.DeptsAndAvgWorkTime.TabIndex = 29;
            this.DeptsAndAvgWorkTime.Text = "";
            this.DeptsAndAvgWorkTime.Visible = false;
            // 
            // DeptNameForRec
            // 
            this.DeptNameForRec.BackColor = System.Drawing.Color.Turquoise;
            this.DeptNameForRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeptNameForRec.Location = new System.Drawing.Point(813, 585);
            this.DeptNameForRec.Name = "DeptNameForRec";
            this.DeptNameForRec.Size = new System.Drawing.Size(369, 29);
            this.DeptNameForRec.TabIndex = 26;
            // 
            // RecWorkTimeProjForDep
            // 
            this.RecWorkTimeProjForDep.BackColor = System.Drawing.Color.Turquoise;
            this.RecWorkTimeProjForDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecWorkTimeProjForDep.Location = new System.Drawing.Point(736, 624);
            this.RecWorkTimeProjForDep.Name = "RecWorkTimeProjForDep";
            this.RecWorkTimeProjForDep.Size = new System.Drawing.Size(521, 62);
            this.RecWorkTimeProjForDep.TabIndex = 25;
            this.RecWorkTimeProjForDep.Text = "";
            // 
            // ProjAndWorkersForPeriod
            // 
            this.ProjAndWorkersForPeriod.Location = new System.Drawing.Point(736, 52);
            this.ProjAndWorkersForPeriod.Name = "ProjAndWorkersForPeriod";
            this.ProjAndWorkersForPeriod.Size = new System.Drawing.Size(12, 13);
            this.ProjAndWorkersForPeriod.TabIndex = 13;
            this.ProjAndWorkersForPeriod.Text = "";
            this.ProjAndWorkersForPeriod.Visible = false;
            // 
            // ProfOfProjForPeriod
            // 
            this.ProfOfProjForPeriod.BackColor = System.Drawing.Color.Turquoise;
            this.ProfOfProjForPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfOfProjForPeriod.Location = new System.Drawing.Point(772, 370);
            this.ProfOfProjForPeriod.Name = "ProfOfProjForPeriod";
            this.ProfOfProjForPeriod.Size = new System.Drawing.Size(540, 134);
            this.ProfOfProjForPeriod.TabIndex = 7;
            this.ProfOfProjForPeriod.Text = "";
            // 
            // ProfOfNotEndProj
            // 
            this.ProfOfNotEndProj.Location = new System.Drawing.Point(613, 854);
            this.ProfOfNotEndProj.Name = "ProfOfNotEndProj";
            this.ProfOfNotEndProj.Size = new System.Drawing.Size(20, 14);
            this.ProfOfNotEndProj.TabIndex = 5;
            this.ProfOfNotEndProj.Text = "";
            this.ProfOfNotEndProj.Visible = false;
            // 
            // ProjAndWorkers
            // 
            this.ProjAndWorkers.Location = new System.Drawing.Point(590, 38);
            this.ProjAndWorkers.Name = "ProjAndWorkers";
            this.ProjAndWorkers.Size = new System.Drawing.Size(17, 10);
            this.ProjAndWorkers.TabIndex = 3;
            this.ProjAndWorkers.Text = "";
            this.ProjAndWorkers.Visible = false;
            // 
            // ProjEndByToday
            // 
            this.ProjEndByToday.Location = new System.Drawing.Point(623, 22);
            this.ProjEndByToday.Name = "ProjEndByToday";
            this.ProjEndByToday.Size = new System.Drawing.Size(10, 10);
            this.ProjEndByToday.TabIndex = 0;
            this.ProjEndByToday.Text = "";
            this.ProjEndByToday.Visible = false;
            // 
            // ShowDeptsAndAvgTimeWork
            // 
            this.ShowDeptsAndAvgTimeWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowDeptsAndAvgTimeWork.Location = new System.Drawing.Point(711, 692);
            this.ShowDeptsAndAvgTimeWork.Name = "ShowDeptsAndAvgTimeWork";
            this.ShowDeptsAndAvgTimeWork.Size = new System.Drawing.Size(427, 37);
            this.ShowDeptsAndAvgTimeWork.TabIndex = 28;
            this.ShowDeptsAndAvgTimeWork.Text = "Show Departments And Average Time of Work";
            this.ShowDeptsAndAvgTimeWork.UseVisualStyleBackColor = true;
            this.ShowDeptsAndAvgTimeWork.Click += new System.EventHandler(this.ShowDeptsAndAvgTimeWork_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(882, 608);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 27;
            // 
            // ShowRecordTimeProjForDept
            // 
            this.ShowRecordTimeProjForDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowRecordTimeProjForDept.Location = new System.Drawing.Point(792, 531);
            this.ShowRecordTimeProjForDept.Name = "ShowRecordTimeProjForDept";
            this.ShowRecordTimeProjForDept.Size = new System.Drawing.Size(407, 37);
            this.ShowRecordTimeProjForDept.TabIndex = 24;
            this.ShowRecordTimeProjForDept.Text = "Show Record Time Project For Department";
            this.ShowRecordTimeProjForDept.UseVisualStyleBackColor = true;
            this.ShowRecordTimeProjForDept.Click += new System.EventHandler(this.ShowRecordTimeProjForDept_Click);
            // 
            // DateRealEndOfProj
            // 
            this.DateRealEndOfProj.AutoSize = true;
            this.DateRealEndOfProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateRealEndOfProj.Location = new System.Drawing.Point(1626, 42);
            this.DateRealEndOfProj.Name = "DateRealEndOfProj";
            this.DateRealEndOfProj.Size = new System.Drawing.Size(0, 24);
            this.DateRealEndOfProj.TabIndex = 17;
            // 
            // DateBegOfProj
            // 
            this.DateBegOfProj.AutoSize = true;
            this.DateBegOfProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBegOfProj.Location = new System.Drawing.Point(1420, 42);
            this.DateBegOfProj.Name = "DateBegOfProj";
            this.DateBegOfProj.Size = new System.Drawing.Size(0, 24);
            this.DateBegOfProj.TabIndex = 16;
            // 
            // DateEnd
            // 
            this.DateEnd.Location = new System.Drawing.Point(1616, 245);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.TabIndex = 15;
            // 
            // DateBeg
            // 
            this.DateBeg.Location = new System.Drawing.Point(1619, 52);
            this.DateBeg.Name = "DateBeg";
            this.DateBeg.TabIndex = 14;
            // 
            // ShowProjAndWorkersForPeriod
            // 
            this.ShowProjAndWorkersForPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowProjAndWorkersForPeriod.Location = new System.Drawing.Point(1030, 27);
            this.ShowProjAndWorkersForPeriod.Name = "ShowProjAndWorkersForPeriod";
            this.ShowProjAndWorkersForPeriod.Size = new System.Drawing.Size(459, 37);
            this.ShowProjAndWorkersForPeriod.TabIndex = 12;
            this.ShowProjAndWorkersForPeriod.Text = "Show Projects and their\'s workers for period";
            this.ShowProjAndWorkersForPeriod.UseVisualStyleBackColor = true;
            this.ShowProjAndWorkersForPeriod.Click += new System.EventHandler(this.ShowProjAndWorkersForPeriod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1531, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // StartingDateForProfByPeriod
            // 
            this.StartingDateForProfByPeriod.Location = new System.Drawing.Point(1382, 342);
            this.StartingDateForProfByPeriod.Name = "StartingDateForProfByPeriod";
            this.StartingDateForProfByPeriod.TabIndex = 8;
            // 
            // ExecCursor
            // 
            this.ExecCursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecCursor.Location = new System.Drawing.Point(772, 299);
            this.ExecCursor.Name = "ExecCursor";
            this.ExecCursor.Size = new System.Drawing.Size(522, 37);
            this.ExecCursor.TabIndex = 6;
            this.ExecCursor.Text = "Show Profit of  projects ended from begin date to today";
            this.ExecCursor.UseVisualStyleBackColor = true;
            this.ExecCursor.Click += new System.EventHandler(this.ExecCursor_Click);
            // 
            // ShowProfOfNonEndProjects
            // 
            this.ShowProfOfNonEndProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowProfOfNonEndProjects.Location = new System.Drawing.Point(93, 566);
            this.ShowProfOfNonEndProjects.Name = "ShowProfOfNonEndProjects";
            this.ShowProfOfNonEndProjects.Size = new System.Drawing.Size(331, 37);
            this.ShowProfOfNonEndProjects.TabIndex = 4;
            this.ShowProfOfNonEndProjects.Text = "Show Profit of not-ended projects";
            this.ShowProfOfNonEndProjects.UseVisualStyleBackColor = true;
            this.ShowProfOfNonEndProjects.Click += new System.EventHandler(this.ShowProfOfNonEndProjects_Click);
            // 
            // ShowProjAndWorkers
            // 
            this.ShowProjAndWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowProjAndWorkers.Location = new System.Drawing.Point(105, 289);
            this.ShowProjAndWorkers.Name = "ShowProjAndWorkers";
            this.ShowProjAndWorkers.Size = new System.Drawing.Size(331, 37);
            this.ShowProjAndWorkers.TabIndex = 2;
            this.ShowProjAndWorkers.Text = "Show Projects and their\'s workers";
            this.ShowProjAndWorkers.UseVisualStyleBackColor = true;
            this.ShowProjAndWorkers.Click += new System.EventHandler(this.ShowProjAndWorkers_Click);
            // 
            // ShowProjEndednByToday
            // 
            this.ShowProjEndednByToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowProjEndednByToday.Location = new System.Drawing.Point(53, 38);
            this.ShowProjEndednByToday.Name = "ShowProjEndednByToday";
            this.ShowProjEndednByToday.Size = new System.Drawing.Size(459, 41);
            this.ShowProjEndednByToday.TabIndex = 1;
            this.ShowProjEndednByToday.Text = "Show Project Ended by today";
            this.ShowProjEndednByToday.UseVisualStyleBackColor = true;
            this.ShowProjEndednByToday.Click += new System.EventHandler(this.ShowProjEndednByToday_Click);
            // 
            // ProjEndedByToday
            // 
            this.ProjEndedByToday.BackgroundColor = System.Drawing.Color.Turquoise;
            this.ProjEndedByToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjEndedByToday.Location = new System.Drawing.Point(6, 85);
            this.ProjEndedByToday.Name = "ProjEndedByToday";
            this.ProjEndedByToday.Size = new System.Drawing.Size(774, 185);
            this.ProjEndedByToday.TabIndex = 44;
            // 
            // ProjAndEmpls
            // 
            this.ProjAndEmpls.BackgroundColor = System.Drawing.Color.Turquoise;
            this.ProjAndEmpls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjAndEmpls.Location = new System.Drawing.Point(20, 349);
            this.ProjAndEmpls.Name = "ProjAndEmpls";
            this.ProjAndEmpls.Size = new System.Drawing.Size(673, 185);
            this.ProjAndEmpls.TabIndex = 45;
            // 
            // ProfOfNonEndedProjs
            // 
            this.ProfOfNonEndedProjs.BackgroundColor = System.Drawing.Color.Turquoise;
            this.ProfOfNonEndedProjs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfOfNonEndedProjs.Location = new System.Drawing.Point(75, 624);
            this.ProfOfNonEndedProjs.Name = "ProfOfNonEndedProjs";
            this.ProfOfNonEndedProjs.Size = new System.Drawing.Size(349, 162);
            this.ProfOfNonEndedProjs.TabIndex = 46;
            // 
            // ProjAndEmplsForPer
            // 
            this.ProjAndEmplsForPer.BackgroundColor = System.Drawing.Color.Turquoise;
            this.ProjAndEmplsForPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjAndEmplsForPer.Location = new System.Drawing.Point(840, 85);
            this.ProjAndEmplsForPer.Name = "ProjAndEmplsForPer";
            this.ProjAndEmplsForPer.Size = new System.Drawing.Size(764, 185);
            this.ProjAndEmplsForPer.TabIndex = 47;
            // 
            // DeptsAndAvgTimeOfWork
            // 
            this.DeptsAndAvgTimeOfWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DeptsAndAvgTimeOfWork.BackgroundColor = System.Drawing.Color.Turquoise;
            this.DeptsAndAvgTimeOfWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeptsAndAvgTimeOfWork.Location = new System.Drawing.Point(749, 758);
            this.DeptsAndAvgTimeOfWork.Name = "DeptsAndAvgTimeOfWork";
            this.DeptsAndAvgTimeOfWork.Size = new System.Drawing.Size(360, 90);
            this.DeptsAndAvgTimeOfWork.TabIndex = 48;
            // 
            // MonthExpenses
            // 
            this.MonthExpenses.BackgroundColor = System.Drawing.Color.Turquoise;
            this.MonthExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MonthExpenses.Location = new System.Drawing.Point(1344, 696);
            this.MonthExpenses.Name = "MonthExpenses";
            this.MonthExpenses.Size = new System.Drawing.Size(400, 163);
            this.MonthExpenses.TabIndex = 49;
            // 
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.EndProj);
            this.Name = "AccountantForm";
            this.Text = "AccountantForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountantForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountantForm_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.EndProj.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjEndedByToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjAndEmpls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfOfNonEndedProjs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjAndEmplsForPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptsAndAvgTimeOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl EndProj;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox DeptsAndAvgWorkTime;
        private System.Windows.Forms.TextBox DeptNameForRec;
        private System.Windows.Forms.RichTextBox RecWorkTimeProjForDep;
        private System.Windows.Forms.RichTextBox ProjAndWorkersForPeriod;
        private System.Windows.Forms.RichTextBox ProfOfProjForPeriod;
        private System.Windows.Forms.RichTextBox ProfOfNotEndProj;
        private System.Windows.Forms.RichTextBox ProjAndWorkers;
        private System.Windows.Forms.RichTextBox ProjEndByToday;
        private System.Windows.Forms.Button ShowDeptsAndAvgTimeWork;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ShowRecordTimeProjForDept;
        private System.Windows.Forms.Label DateRealEndOfProj;
        private System.Windows.Forms.Label DateBegOfProj;
        private System.Windows.Forms.MonthCalendar DateEnd;
        private System.Windows.Forms.MonthCalendar DateBeg;
        private System.Windows.Forms.Button ShowProjAndWorkersForPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar StartingDateForProfByPeriod;
        private System.Windows.Forms.Button ExecCursor;
        private System.Windows.Forms.Button ShowProfOfNonEndProjects;
        private System.Windows.Forms.Button ShowProjAndWorkers;
        private System.Windows.Forms.Button ShowProjEndednByToday;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton UpdateDatabase;
        private System.Windows.Forms.Button ChTableToDeptsEmpls;
        private System.Windows.Forms.Button ChTableToDepts;
        private System.Windows.Forms.Button ChTableToEmpls;
        private System.Windows.Forms.Button ChTableToProjs;
        private System.Windows.Forms.Button MonthExpensesForProjs;
        private System.Windows.Forms.RichTextBox MonthExpensesForProjects;
        private System.Windows.Forms.DateTimePicker DateStartCursor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ProjEndedByToday;
        private System.Windows.Forms.DataGridView ProjAndEmpls;
        private System.Windows.Forms.DataGridView ProfOfNonEndedProjs;
        private System.Windows.Forms.DataGridView ProjAndEmplsForPer;
        private System.Windows.Forms.DataGridView DeptsAndAvgTimeOfWork;
        private System.Windows.Forms.DataGridView MonthExpenses;
    }
}