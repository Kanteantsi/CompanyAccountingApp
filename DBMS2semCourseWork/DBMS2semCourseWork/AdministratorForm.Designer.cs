
namespace DBMS2semCourseWork
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.DateEndRealForTransac = new System.Windows.Forms.MonthCalendar();
            this.DateEndForTransac = new System.Windows.Forms.MonthCalendar();
            this.DateBegForTransac = new System.Windows.Forms.MonthCalendar();
            this.DeptNameForTransac = new System.Windows.Forms.TextBox();
            this.ProjCostForTransac = new System.Windows.Forms.TextBox();
            this.ProjNameForTransac = new System.Windows.Forms.TextBox();
            this.AddNewProjTransac = new System.Windows.Forms.Button();
            this.ProjAndWorksForPer = new System.Windows.Forms.DataGridView();
            this.ProjsAndTheirWorkers = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.ProjectForDateChangeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateOfEndReal = new System.Windows.Forms.MonthCalendar();
            this.ChangeProjDateEndRealByName = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.NewNameOfChangedProject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OldNameOfChangedProject = new System.Windows.Forms.TextBox();
            this.ChangeNameOfProject = new System.Windows.Forms.Button();
            this.DateRealEndOfProj = new System.Windows.Forms.Label();
            this.DateBegOfProj = new System.Windows.Forms.Label();
            this.DateEnd = new System.Windows.Forms.MonthCalendar();
            this.DateBeg = new System.Windows.Forms.MonthCalendar();
            this.ProjAndWorkersForPeriod = new System.Windows.Forms.RichTextBox();
            this.ShowProjAndWorkersForPeriod = new System.Windows.Forms.Button();
            this.ProjAndWorkers = new System.Windows.Forms.RichTextBox();
            this.ShowProjAndWorkers = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeptsAndAvgTimeOfWork = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SecEmplLN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SecEmplPN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SecEmplFN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FirEmplLN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FirEmplPN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.FirEmplFN = new System.Windows.Forms.TextBox();
            this.SameProjForTwoEmpl = new System.Windows.Forms.RichTextBox();
            this.ShowSameProjsForTwoEmpls = new System.Windows.Forms.Button();
            this.DeptsAndAvgWorkTime = new System.Windows.Forms.RichTextBox();
            this.ShowDeptsAndAvgTimeWork = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeptNameForDelEmpl = new System.Windows.Forms.TextBox();
            this.DeleteFromDeptSmallSalary = new System.Windows.Forms.Button();
            this.DeleteRestingDepartment = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.UpdateDatabase = new System.Windows.Forms.ToolStripButton();
            this.ChTableToProjs = new System.Windows.Forms.Button();
            this.ChTableToDeptsEmpls = new System.Windows.Forms.Button();
            this.ChTableToDepts = new System.Windows.Forms.Button();
            this.ChTableToEmpls = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjAndWorksForPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjsAndTheirWorkers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeptsAndAvgTimeOfWork)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1752, 929);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.DateEndRealForTransac);
            this.tabPage1.Controls.Add(this.DateEndForTransac);
            this.tabPage1.Controls.Add(this.DateBegForTransac);
            this.tabPage1.Controls.Add(this.DeptNameForTransac);
            this.tabPage1.Controls.Add(this.ProjCostForTransac);
            this.tabPage1.Controls.Add(this.ProjNameForTransac);
            this.tabPage1.Controls.Add(this.AddNewProjTransac);
            this.tabPage1.Controls.Add(this.ProjAndWorksForPer);
            this.tabPage1.Controls.Add(this.ProjsAndTheirWorkers);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ProjectForDateChangeName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.DateOfEndReal);
            this.tabPage1.Controls.Add(this.ChangeProjDateEndRealByName);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.NewNameOfChangedProject);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.OldNameOfChangedProject);
            this.tabPage1.Controls.Add(this.ChangeNameOfProject);
            this.tabPage1.Controls.Add(this.DateRealEndOfProj);
            this.tabPage1.Controls.Add(this.DateBegOfProj);
            this.tabPage1.Controls.Add(this.DateEnd);
            this.tabPage1.Controls.Add(this.DateBeg);
            this.tabPage1.Controls.Add(this.ProjAndWorkersForPeriod);
            this.tabPage1.Controls.Add(this.ShowProjAndWorkersForPeriod);
            this.tabPage1.Controls.Add(this.ProjAndWorkers);
            this.tabPage1.Controls.Add(this.ShowProjAndWorkers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1744, 903);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Projects";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(1497, 617);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(151, 24);
            this.label22.TabIndex = 47;
            this.label22.Text = "Date of End Real";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(1201, 617);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 24);
            this.label21.TabIndex = 46;
            this.label21.Text = "Date of End";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(887, 617);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 24);
            this.label20.TabIndex = 45;
            this.label20.Text = "Date of Begin";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(1501, 527);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 24);
            this.label19.TabIndex = 44;
            this.label19.Text = "Department Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(1213, 527);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 24);
            this.label18.TabIndex = 43;
            this.label18.Text = "Project Cost";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(887, 527);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 24);
            this.label17.TabIndex = 42;
            this.label17.Text = "Project Name";
            // 
            // DateEndRealForTransac
            // 
            this.DateEndRealForTransac.Location = new System.Drawing.Point(1484, 650);
            this.DateEndRealForTransac.Name = "DateEndRealForTransac";
            this.DateEndRealForTransac.TabIndex = 41;
            // 
            // DateEndForTransac
            // 
            this.DateEndForTransac.Location = new System.Drawing.Point(1187, 650);
            this.DateEndForTransac.Name = "DateEndForTransac";
            this.DateEndForTransac.TabIndex = 40;
            // 
            // DateBegForTransac
            // 
            this.DateBegForTransac.Location = new System.Drawing.Point(876, 650);
            this.DateBegForTransac.Name = "DateBegForTransac";
            this.DateBegForTransac.TabIndex = 39;
            // 
            // DeptNameForTransac
            // 
            this.DeptNameForTransac.Location = new System.Drawing.Point(1484, 562);
            this.DeptNameForTransac.Name = "DeptNameForTransac";
            this.DeptNameForTransac.Size = new System.Drawing.Size(164, 20);
            this.DeptNameForTransac.TabIndex = 37;
            // 
            // ProjCostForTransac
            // 
            this.ProjCostForTransac.Location = new System.Drawing.Point(1187, 562);
            this.ProjCostForTransac.Name = "ProjCostForTransac";
            this.ProjCostForTransac.Size = new System.Drawing.Size(164, 20);
            this.ProjCostForTransac.TabIndex = 36;
            // 
            // ProjNameForTransac
            // 
            this.ProjNameForTransac.Location = new System.Drawing.Point(876, 562);
            this.ProjNameForTransac.Name = "ProjNameForTransac";
            this.ProjNameForTransac.Size = new System.Drawing.Size(164, 20);
            this.ProjNameForTransac.TabIndex = 35;
            // 
            // AddNewProjTransac
            // 
            this.AddNewProjTransac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewProjTransac.Location = new System.Drawing.Point(1169, 469);
            this.AddNewProjTransac.Name = "AddNewProjTransac";
            this.AddNewProjTransac.Size = new System.Drawing.Size(208, 39);
            this.AddNewProjTransac.TabIndex = 34;
            this.AddNewProjTransac.Text = "Add new project";
            this.AddNewProjTransac.UseVisualStyleBackColor = true;
            this.AddNewProjTransac.Click += new System.EventHandler(this.AddNewProjTransac_Click);
            // 
            // ProjAndWorksForPer
            // 
            this.ProjAndWorksForPer.BackgroundColor = System.Drawing.Color.IndianRed;
            this.ProjAndWorksForPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjAndWorksForPer.Location = new System.Drawing.Point(47, 378);
            this.ProjAndWorksForPer.Name = "ProjAndWorksForPer";
            this.ProjAndWorksForPer.Size = new System.Drawing.Size(765, 184);
            this.ProjAndWorksForPer.TabIndex = 33;
            // 
            // ProjsAndTheirWorkers
            // 
            this.ProjsAndTheirWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ProjsAndTheirWorkers.BackgroundColor = System.Drawing.Color.IndianRed;
            this.ProjsAndTheirWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjsAndTheirWorkers.Location = new System.Drawing.Point(47, 101);
            this.ProjsAndTheirWorkers.Name = "ProjsAndTheirWorkers";
            this.ProjsAndTheirWorkers.Size = new System.Drawing.Size(570, 200);
            this.ProjsAndTheirWorkers.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(883, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Project name";
            // 
            // ProjectForDateChangeName
            // 
            this.ProjectForDateChangeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectForDateChangeName.Location = new System.Drawing.Point(861, 161);
            this.ProjectForDateChangeName.Name = "ProjectForDateChangeName";
            this.ProjectForDateChangeName.Size = new System.Drawing.Size(273, 29);
            this.ProjectForDateChangeName.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(938, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "new date of end real";
            // 
            // DateOfEndReal
            // 
            this.DateOfEndReal.Location = new System.Drawing.Point(926, 239);
            this.DateOfEndReal.Name = "DateOfEndReal";
            this.DateOfEndReal.TabIndex = 26;
            // 
            // ChangeProjDateEndRealByName
            // 
            this.ChangeProjDateEndRealByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeProjDateEndRealByName.Location = new System.Drawing.Point(861, 53);
            this.ChangeProjDateEndRealByName.Name = "ChangeProjDateEndRealByName";
            this.ChangeProjDateEndRealByName.Size = new System.Drawing.Size(258, 59);
            this.ChangeProjDateEndRealByName.TabIndex = 23;
            this.ChangeProjDateEndRealByName.Text = "Change date end real by project name";
            this.ChangeProjDateEndRealByName.UseVisualStyleBackColor = true;
            this.ChangeProjDateEndRealByName.Click += new System.EventHandler(this.ChangeProjDateEndRealByName_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1292, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "New Name Of Changed Project";
            // 
            // NewNameOfChangedProject
            // 
            this.NewNameOfChangedProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewNameOfChangedProject.Location = new System.Drawing.Point(1321, 256);
            this.NewNameOfChangedProject.Name = "NewNameOfChangedProject";
            this.NewNameOfChangedProject.Size = new System.Drawing.Size(220, 29);
            this.NewNameOfChangedProject.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1301, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Old Name Of Changed Project";
            // 
            // OldNameOfChangedProject
            // 
            this.OldNameOfChangedProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldNameOfChangedProject.Location = new System.Drawing.Point(1319, 186);
            this.OldNameOfChangedProject.Name = "OldNameOfChangedProject";
            this.OldNameOfChangedProject.Size = new System.Drawing.Size(220, 29);
            this.OldNameOfChangedProject.TabIndex = 19;
            // 
            // ChangeNameOfProject
            // 
            this.ChangeNameOfProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeNameOfProject.Location = new System.Drawing.Point(1294, 75);
            this.ChangeNameOfProject.Name = "ChangeNameOfProject";
            this.ChangeNameOfProject.Size = new System.Drawing.Size(273, 47);
            this.ChangeNameOfProject.TabIndex = 18;
            this.ChangeNameOfProject.Text = "Change Name Of Project";
            this.ChangeNameOfProject.UseVisualStyleBackColor = true;
            this.ChangeNameOfProject.Click += new System.EventHandler(this.ChangeNameOfProject_Click);
            // 
            // DateRealEndOfProj
            // 
            this.DateRealEndOfProj.AutoSize = true;
            this.DateRealEndOfProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateRealEndOfProj.Location = new System.Drawing.Point(390, 595);
            this.DateRealEndOfProj.Name = "DateRealEndOfProj";
            this.DateRealEndOfProj.Size = new System.Drawing.Size(227, 24);
            this.DateRealEndOfProj.TabIndex = 11;
            this.DateRealEndOfProj.Text = "Date Real End Of Projects";
            // 
            // DateBegOfProj
            // 
            this.DateBegOfProj.AutoSize = true;
            this.DateBegOfProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBegOfProj.Location = new System.Drawing.Point(57, 595);
            this.DateBegOfProj.Name = "DateBegOfProj";
            this.DateBegOfProj.Size = new System.Drawing.Size(198, 24);
            this.DateBegOfProj.TabIndex = 10;
            this.DateBegOfProj.Text = "Date Begin Of Projects";
            // 
            // DateEnd
            // 
            this.DateEnd.Location = new System.Drawing.Point(413, 635);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.TabIndex = 9;
            // 
            // DateBeg
            // 
            this.DateBeg.Location = new System.Drawing.Point(75, 635);
            this.DateBeg.Name = "DateBeg";
            this.DateBeg.TabIndex = 8;
            // 
            // ProjAndWorkersForPeriod
            // 
            this.ProjAndWorkersForPeriod.Location = new System.Drawing.Point(722, 587);
            this.ProjAndWorkersForPeriod.Name = "ProjAndWorkersForPeriod";
            this.ProjAndWorkersForPeriod.Size = new System.Drawing.Size(16, 10);
            this.ProjAndWorkersForPeriod.TabIndex = 7;
            this.ProjAndWorkersForPeriod.Text = "";
            this.ProjAndWorkersForPeriod.Visible = false;
            // 
            // ShowProjAndWorkersForPeriod
            // 
            this.ShowProjAndWorkersForPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowProjAndWorkersForPeriod.Location = new System.Drawing.Point(89, 320);
            this.ShowProjAndWorkersForPeriod.Name = "ShowProjAndWorkersForPeriod";
            this.ShowProjAndWorkersForPeriod.Size = new System.Drawing.Size(424, 37);
            this.ShowProjAndWorkersForPeriod.TabIndex = 6;
            this.ShowProjAndWorkersForPeriod.Text = "Show Projects and their\'s workers for period";
            this.ShowProjAndWorkersForPeriod.UseVisualStyleBackColor = true;
            this.ShowProjAndWorkersForPeriod.Click += new System.EventHandler(this.ShowProjAndWorkersForPeriod_Click);
            // 
            // ProjAndWorkers
            // 
            this.ProjAndWorkers.Location = new System.Drawing.Point(524, 6);
            this.ProjAndWorkers.Name = "ProjAndWorkers";
            this.ProjAndWorkers.Size = new System.Drawing.Size(10, 10);
            this.ProjAndWorkers.TabIndex = 5;
            this.ProjAndWorkers.Text = "";
            this.ProjAndWorkers.Visible = false;
            // 
            // ShowProjAndWorkers
            // 
            this.ShowProjAndWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowProjAndWorkers.Location = new System.Drawing.Point(89, 36);
            this.ShowProjAndWorkers.Name = "ShowProjAndWorkers";
            this.ShowProjAndWorkers.Size = new System.Drawing.Size(331, 37);
            this.ShowProjAndWorkers.TabIndex = 4;
            this.ShowProjAndWorkers.Text = "Show Projects and their\'s workers";
            this.ShowProjAndWorkers.UseVisualStyleBackColor = true;
            this.ShowProjAndWorkers.Click += new System.EventHandler(this.ShowProjAndWorkers_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage2.Controls.Add(this.DeptsAndAvgTimeOfWork);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.SecEmplLN);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.SecEmplPN);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.SecEmplFN);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.FirEmplLN);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.FirEmplPN);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.FirEmplFN);
            this.tabPage2.Controls.Add(this.SameProjForTwoEmpl);
            this.tabPage2.Controls.Add(this.ShowSameProjsForTwoEmpls);
            this.tabPage2.Controls.Add(this.DeptsAndAvgWorkTime);
            this.tabPage2.Controls.Add(this.ShowDeptsAndAvgTimeWork);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.DeptNameForDelEmpl);
            this.tabPage2.Controls.Add(this.DeleteFromDeptSmallSalary);
            this.tabPage2.Controls.Add(this.DeleteRestingDepartment);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1744, 903);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Departments, Employees";
            // 
            // DeptsAndAvgTimeOfWork
            // 
            this.DeptsAndAvgTimeOfWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DeptsAndAvgTimeOfWork.BackgroundColor = System.Drawing.Color.IndianRed;
            this.DeptsAndAvgTimeOfWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeptsAndAvgTimeOfWork.Location = new System.Drawing.Point(529, 203);
            this.DeptsAndAvgTimeOfWork.Name = "DeptsAndAvgTimeOfWork";
            this.DeptsAndAvgTimeOfWork.Size = new System.Drawing.Size(326, 140);
            this.DeptsAndAvgTimeOfWork.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(369, 696);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 42;
            this.label8.Text = "Project Names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(751, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Days of Work";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(593, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "DepartmentID";
            this.label2.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(762, 553);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(272, 24);
            this.label16.TabIndex = 39;
            this.label16.Text = "Second Employee\'s Full Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(113, 554);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(241, 24);
            this.label15.TabIndex = 38;
            this.label15.Text = "First Employee\'s Full Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1030, 612);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 24);
            this.label12.TabIndex = 37;
            this.label12.Text = "Last Name";
            // 
            // SecEmplLN
            // 
            this.SecEmplLN.Location = new System.Drawing.Point(1028, 655);
            this.SecEmplLN.Name = "SecEmplLN";
            this.SecEmplLN.Size = new System.Drawing.Size(118, 20);
            this.SecEmplLN.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(846, 612);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 24);
            this.label13.TabIndex = 35;
            this.label13.Text = "Pather Name";
            // 
            // SecEmplPN
            // 
            this.SecEmplPN.Location = new System.Drawing.Point(840, 655);
            this.SecEmplPN.Name = "SecEmplPN";
            this.SecEmplPN.Size = new System.Drawing.Size(118, 20);
            this.SecEmplPN.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(653, 612);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 24);
            this.label14.TabIndex = 33;
            this.label14.Text = "First Name";
            // 
            // SecEmplFN
            // 
            this.SecEmplFN.Location = new System.Drawing.Point(655, 655);
            this.SecEmplFN.Name = "SecEmplFN";
            this.SecEmplFN.Size = new System.Drawing.Size(118, 20);
            this.SecEmplFN.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(428, 612);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Last Name";
            // 
            // FirEmplLN
            // 
            this.FirEmplLN.Location = new System.Drawing.Point(430, 655);
            this.FirEmplLN.Name = "FirEmplLN";
            this.FirEmplLN.Size = new System.Drawing.Size(118, 20);
            this.FirEmplLN.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(241, 612);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "Pather Name";
            // 
            // FirEmplPN
            // 
            this.FirEmplPN.Location = new System.Drawing.Point(242, 655);
            this.FirEmplPN.Name = "FirEmplPN";
            this.FirEmplPN.Size = new System.Drawing.Size(118, 20);
            this.FirEmplPN.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(59, 612);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "First Name";
            // 
            // FirEmplFN
            // 
            this.FirEmplFN.Location = new System.Drawing.Point(64, 655);
            this.FirEmplFN.Name = "FirEmplFN";
            this.FirEmplFN.Size = new System.Drawing.Size(118, 20);
            this.FirEmplFN.TabIndex = 26;
            // 
            // SameProjForTwoEmpl
            // 
            this.SameProjForTwoEmpl.BackColor = System.Drawing.Color.IndianRed;
            this.SameProjForTwoEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SameProjForTwoEmpl.Location = new System.Drawing.Point(320, 733);
            this.SameProjForTwoEmpl.Name = "SameProjForTwoEmpl";
            this.SameProjForTwoEmpl.Size = new System.Drawing.Size(581, 81);
            this.SameProjForTwoEmpl.TabIndex = 25;
            this.SameProjForTwoEmpl.Text = "";
            // 
            // ShowSameProjsForTwoEmpls
            // 
            this.ShowSameProjsForTwoEmpls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowSameProjsForTwoEmpls.Location = new System.Drawing.Point(442, 474);
            this.ShowSameProjsForTwoEmpls.Name = "ShowSameProjsForTwoEmpls";
            this.ShowSameProjsForTwoEmpls.Size = new System.Drawing.Size(459, 37);
            this.ShowSameProjsForTwoEmpls.TabIndex = 24;
            this.ShowSameProjsForTwoEmpls.Text = "Show Same Project For Two Employees";
            this.ShowSameProjsForTwoEmpls.UseVisualStyleBackColor = true;
            this.ShowSameProjsForTwoEmpls.Click += new System.EventHandler(this.ShowSameProjsForTwoEmpls_Click);
            // 
            // DeptsAndAvgWorkTime
            // 
            this.DeptsAndAvgWorkTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeptsAndAvgWorkTime.Location = new System.Drawing.Point(906, 29);
            this.DeptsAndAvgWorkTime.Name = "DeptsAndAvgWorkTime";
            this.DeptsAndAvgWorkTime.Size = new System.Drawing.Size(21, 20);
            this.DeptsAndAvgWorkTime.TabIndex = 19;
            this.DeptsAndAvgWorkTime.Text = "";
            this.DeptsAndAvgWorkTime.Visible = false;
            // 
            // ShowDeptsAndAvgTimeWork
            // 
            this.ShowDeptsAndAvgTimeWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowDeptsAndAvgTimeWork.Location = new System.Drawing.Point(487, 146);
            this.ShowDeptsAndAvgTimeWork.Name = "ShowDeptsAndAvgTimeWork";
            this.ShowDeptsAndAvgTimeWork.Size = new System.Drawing.Size(414, 37);
            this.ShowDeptsAndAvgTimeWork.TabIndex = 18;
            this.ShowDeptsAndAvgTimeWork.Text = "Show Departments And Average Time of Work";
            this.ShowDeptsAndAvgTimeWork.UseVisualStyleBackColor = true;
            this.ShowDeptsAndAvgTimeWork.Click += new System.EventHandler(this.ShowDeptsAndAvgTimeWork_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Department name";
            // 
            // DeptNameForDelEmpl
            // 
            this.DeptNameForDelEmpl.Location = new System.Drawing.Point(63, 340);
            this.DeptNameForDelEmpl.Name = "DeptNameForDelEmpl";
            this.DeptNameForDelEmpl.Size = new System.Drawing.Size(273, 20);
            this.DeptNameForDelEmpl.TabIndex = 2;
            // 
            // DeleteFromDeptSmallSalary
            // 
            this.DeleteFromDeptSmallSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteFromDeptSmallSalary.Location = new System.Drawing.Point(35, 220);
            this.DeleteFromDeptSmallSalary.Name = "DeleteFromDeptSmallSalary";
            this.DeleteFromDeptSmallSalary.Size = new System.Drawing.Size(347, 70);
            this.DeleteFromDeptSmallSalary.TabIndex = 1;
            this.DeleteFromDeptSmallSalary.Text = "Delete employee with smallest salary, from department with this name";
            this.DeleteFromDeptSmallSalary.UseVisualStyleBackColor = true;
            this.DeleteFromDeptSmallSalary.Click += new System.EventHandler(this.DeleteFromDeptSmallSalary_Click);
            // 
            // DeleteRestingDepartment
            // 
            this.DeleteRestingDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteRestingDepartment.Location = new System.Drawing.Point(35, 85);
            this.DeleteRestingDepartment.Name = "DeleteRestingDepartment";
            this.DeleteRestingDepartment.Size = new System.Drawing.Size(370, 98);
            this.DeleteRestingDepartment.TabIndex = 0;
            this.DeleteRestingDepartment.Text = "Delete departments, if amount of workers is bigger than three, and no work in pro" +
    "jects";
            this.DeleteRestingDepartment.UseVisualStyleBackColor = true;
            this.DeleteRestingDepartment.Click += new System.EventHandler(this.DeleteRestingDepartment_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage3.Controls.Add(this.Insert);
            this.tabPage3.Controls.Add(this.Delete);
            this.tabPage3.Controls.Add(this.Update);
            this.tabPage3.Controls.Add(this.toolStrip1);
            this.tabPage3.Controls.Add(this.ChTableToProjs);
            this.tabPage3.Controls.Add(this.ChTableToDeptsEmpls);
            this.tabPage3.Controls.Add(this.ChTableToDepts);
            this.tabPage3.Controls.Add(this.ChTableToEmpls);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1744, 903);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Working with tables";
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Insert.Location = new System.Drawing.Point(789, 718);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(183, 52);
            this.Insert.TabIndex = 8;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Visible = false;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(424, 718);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(154, 52);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update.Location = new System.Drawing.Point(102, 718);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(139, 52);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update/Insert";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateDatabase});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1674, 25);
            this.toolStrip1.TabIndex = 5;
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
            // ChTableToProjs
            // 
            this.ChTableToProjs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChTableToProjs.Location = new System.Drawing.Point(1179, 706);
            this.ChTableToProjs.Name = "ChTableToProjs";
            this.ChTableToProjs.Size = new System.Drawing.Size(329, 82);
            this.ChTableToProjs.TabIndex = 4;
            this.ChTableToProjs.Text = "Change active table to Projects";
            this.ChTableToProjs.UseVisualStyleBackColor = true;
            this.ChTableToProjs.Click += new System.EventHandler(this.ChTableToProjs_Click_1);
            // 
            // ChTableToDeptsEmpls
            // 
            this.ChTableToDeptsEmpls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChTableToDeptsEmpls.Location = new System.Drawing.Point(1179, 509);
            this.ChTableToDeptsEmpls.Name = "ChTableToDeptsEmpls";
            this.ChTableToDeptsEmpls.Size = new System.Drawing.Size(329, 82);
            this.ChTableToDeptsEmpls.TabIndex = 3;
            this.ChTableToDeptsEmpls.Text = "Change active table to Departments-Employees";
            this.ChTableToDeptsEmpls.UseVisualStyleBackColor = true;
            this.ChTableToDeptsEmpls.Click += new System.EventHandler(this.ChTableToDeptsEmpls_Click_1);
            // 
            // ChTableToDepts
            // 
            this.ChTableToDepts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChTableToDepts.Location = new System.Drawing.Point(1179, 311);
            this.ChTableToDepts.Name = "ChTableToDepts";
            this.ChTableToDepts.Size = new System.Drawing.Size(329, 82);
            this.ChTableToDepts.TabIndex = 2;
            this.ChTableToDepts.Text = "Change active table to Departments";
            this.ChTableToDepts.UseVisualStyleBackColor = true;
            this.ChTableToDepts.Click += new System.EventHandler(this.ChTableToDepts_Click_1);
            // 
            // ChTableToEmpls
            // 
            this.ChTableToEmpls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChTableToEmpls.Location = new System.Drawing.Point(1179, 100);
            this.ChTableToEmpls.Name = "ChTableToEmpls";
            this.ChTableToEmpls.Size = new System.Drawing.Size(329, 82);
            this.ChTableToEmpls.TabIndex = 1;
            this.ChTableToEmpls.Text = "Change active table to Employees";
            this.ChTableToEmpls.UseVisualStyleBackColor = true;
            this.ChTableToEmpls.Click += new System.EventHandler(this.ChTableToEmpls_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1004, 599);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);

            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorForm_FormClosing);
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjAndWorksForPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjsAndTheirWorkers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeptsAndAvgTimeOfWork)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox ProjAndWorkers;
        private System.Windows.Forms.Button ShowProjAndWorkers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button DeleteRestingDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeptNameForDelEmpl;
        private System.Windows.Forms.Button DeleteFromDeptSmallSalary;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProjectForDateChangeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar DateOfEndReal;
        private System.Windows.Forms.Button ChangeProjDateEndRealByName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NewNameOfChangedProject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OldNameOfChangedProject;
        private System.Windows.Forms.Button ChangeNameOfProject;
        private System.Windows.Forms.Label DateRealEndOfProj;
        private System.Windows.Forms.Label DateBegOfProj;
        private System.Windows.Forms.MonthCalendar DateEnd;
        private System.Windows.Forms.MonthCalendar DateBeg;
        private System.Windows.Forms.RichTextBox ProjAndWorkersForPeriod;
        private System.Windows.Forms.Button ShowProjAndWorkersForPeriod;
        private System.Windows.Forms.RichTextBox SameProjForTwoEmpl;
        private System.Windows.Forms.Button ShowSameProjsForTwoEmpls;
        private System.Windows.Forms.RichTextBox DeptsAndAvgWorkTime;
        private System.Windows.Forms.Button ShowDeptsAndAvgTimeWork;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SecEmplLN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SecEmplPN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SecEmplFN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FirEmplLN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FirEmplPN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox FirEmplFN;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton UpdateDatabase;
        private System.Windows.Forms.Button ChTableToProjs;
        private System.Windows.Forms.Button ChTableToDeptsEmpls;
        private System.Windows.Forms.Button ChTableToDepts;
        private System.Windows.Forms.Button ChTableToEmpls;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ProjsAndTheirWorkers;
        private System.Windows.Forms.DataGridView DeptsAndAvgTimeOfWork;
        private System.Windows.Forms.DataGridView ProjAndWorksForPer;
        private System.Windows.Forms.Button AddNewProjTransac;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MonthCalendar DateEndRealForTransac;
        private System.Windows.Forms.MonthCalendar DateEndForTransac;
        private System.Windows.Forms.MonthCalendar DateBegForTransac;
        private System.Windows.Forms.TextBox DeptNameForTransac;
        private System.Windows.Forms.TextBox ProjCostForTransac;
        private System.Windows.Forms.TextBox ProjNameForTransac;
    }
}