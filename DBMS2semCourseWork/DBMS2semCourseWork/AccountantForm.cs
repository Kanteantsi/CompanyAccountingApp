using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace DBMS2semCourseWork
{
    public partial class AccountantForm : Form
    {
        string connectionstring = @"Provider=OraOLEDB.Oracle;OLEDB.NET=true;PLSQLRSet=true;USER ID=C##VLAD;DATA SOURCE=localhost:1521/xe;PASSWORD=V123456;";

        private OleDbConnection OleDbConnection = null;

        private OleDbCommandBuilder OleDbCommandBuilder = null;

        private OleDbDataAdapter OleDbDataAdapter = null;

        private DataSet dataSet = null;

        private string currentTable;

        private bool newRowAdding = false;

        private Dictionary<string, int> numberOfColumns =
        new Dictionary<string, int> { {"Departments", 1 },
                                          {"Departments_Employees",  2 },
                                          {"Employees",       5 },
                                           {"Projects",    6 }
                                              };

        private int lastIndexTable = 2; // меняется в зависимости от таблицы


        public AccountantForm()
        {
            InitializeComponent();
        }

        private void AccountantForm_Load(object sender, EventArgs e)
        {
             OleDbConnection = new OleDbConnection(connectionstring);

            OleDbConnection.Open();
        }


        private void GetAndFillTable(string tableName)
        {
            int value = -1;
            if (numberOfColumns.TryGetValue(tableName, out value))
            {
                lastIndexTable = value;
                currentTable = tableName;
                LoadData();
            }
            else
            {
                MessageBox.Show($"Таблица {tableName} не найдена", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAndFillTable("CreditOrder");
        }



        private void ChTableToEmpls_Click(object sender, EventArgs e)
        {
            GetAndFillTable("Employees");
        }

        private void ChTableToDepts_Click(object sender, EventArgs e)
        {
            GetAndFillTable("Departments");
        }

        private void ChTableToDeptsEmpls_Click(object sender, EventArgs e)
        {
            GetAndFillTable("Departments_Employees");
        }

        private void ChTableToProjs_Click(object sender, EventArgs e)
        {
            GetAndFillTable("Projects");
        }


        private void LoadData()
        {
            try
            {
                OleDbDataAdapter = new OleDbDataAdapter("Select * FROM " + currentTable, OleDbConnection);

                OleDbCommandBuilder = new OleDbCommandBuilder(OleDbDataAdapter);

                OleDbCommandBuilder.GetInsertCommand();
                OleDbCommandBuilder.GetUpdateCommand();
                OleDbCommandBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                OleDbDataAdapter.Fill(dataSet, currentTable);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataSet.Tables[currentTable];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowProjEndednByToday_Click(object sender, EventArgs e)
        {





            OleDbConnection = new OleDbConnection(connectionstring);
            OleDbConnection.Open();

            OleDbCommand ProjEndednByToday = new OleDbCommand("Select * From projects Where date_end_real < SYSDATE", OleDbConnection);
     


            var reader = ProjEndednByToday.ExecuteReader();

            if (reader.HasRows)
            {
           

                while (reader.Read()) 
                {
                    ProjEndByToday.Text += (Convert.ToString(reader["id"] + "  " + reader["name"]) + "    " + Convert.ToString(reader["cost"]) + "    " + Convert.ToString(reader["department_id"]) + "    " + Convert.ToString(reader["date_beg"]) + "       " + Convert.ToString(reader["date_end"]) + Convert.ToString(reader["date_end_real"])  + "\n");
                }
            }
            reader.Close();




            var select = "Select * From projects Where date_end_real < SYSDATE";
            var c = new OleDbConnection(connectionstring); 
            var dataAdapter = new OleDbDataAdapter(select, c);

            var commandBuilder = new OleDbCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            ProjEndedByToday.ReadOnly = true;
            ProjEndedByToday.DataSource = ds.Tables[0];
        }

        private void ShowProjAndWorkers_Click(object sender, EventArgs e)
        {
            

            OleDbConnection = new OleDbConnection(connectionstring);
            OleDbConnection.Open();

            OleDbCommand ShowProjAndWorkers = new OleDbCommand("Select projects.id, name, cost, employees.first_name,employees.pather_name,employees.last_name from projects INNER JOIN DEPARTMENTS_EMPLOYEES on(departments_employees.department_id = projects.department_id) INNER JOIN EMPLOYEES on(departments_employees.employee_id = EMPLOYEES.id)", OleDbConnection);



            var reader = ShowProjAndWorkers.ExecuteReader();

            if (reader.HasRows)
            {


                while (reader.Read()) 
                {
                    ProjAndWorkers.Text += (Convert.ToString(reader["id"] + "  " +  reader["name"]) + "    " + Convert.ToString(reader["cost"]) + "    " + Convert.ToString(reader["first_name"]) + "    " + Convert.ToString(reader["pather_name"]) + "       " + Convert.ToString(reader["last_name"]) + "\n");
                }
            }
            reader.Close();

            var select = "Select projects.id, name, cost, employees.first_name,employees.pather_name,employees.last_name from projects INNER JOIN DEPARTMENTS_EMPLOYEES on(departments_employees.department_id = projects.department_id) INNER JOIN EMPLOYEES on(departments_employees.employee_id = EMPLOYEES.id)";
            var c = new OleDbConnection(connectionstring);
            var dataAdapter = new OleDbDataAdapter(select, c);

            var commandBuilder = new OleDbCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            ProjAndEmpls.ReadOnly = true;
            ProjAndEmpls.DataSource = ds.Tables[0];
        }

        private void ShowProfOfNonEndProjects_Click(object sender, EventArgs e)
        {
            


            OleDbConnection = new OleDbConnection(connectionstring);
            OleDbConnection.Open();

            OleDbCommand ShowProjAndWorkers = new OleDbCommand("Select name, cost, projects.cost - MONTHS_BETWEEN(TO_DATE(projects.DATE_END_REAL), TO_DATE(projects.date_beg)) * SUM(employees.salary) AS profit from projects INNER JOIN DEPARTMENTS_EMPLOYEES on(departments_employees.department_id = projects.department_id) INNER JOIN EMPLOYEES on(departments_employees.employee_id = EMPLOYEES.id) Where projects.DATE_END_REAL > SYSDATE group by name,cost,projects.DATE_END_REAL,projects.date_beg", OleDbConnection);



            var reader = ShowProjAndWorkers.ExecuteReader();

            if (reader.HasRows)
            {
               

                while (reader.Read()) 
                {
                    ProfOfNotEndProj.Text += (Convert.ToString(reader["name"] + "  " + reader["cost"]) +  "    " + Convert.ToString(reader["profit"]) + "\n");
                }
            }
            reader.Close();

            


            var select = "Select name, cost, projects.cost - MONTHS_BETWEEN(TO_DATE(projects.DATE_END_REAL), TO_DATE(projects.date_beg)) * SUM(employees.salary) AS profit from projects INNER JOIN DEPARTMENTS_EMPLOYEES on(departments_employees.department_id = projects.department_id) INNER JOIN EMPLOYEES on(departments_employees.employee_id = EMPLOYEES.id) Where projects.DATE_END_REAL > SYSDATE group by name,cost,projects.DATE_END_REAL,projects.date_beg";
            var c = new OleDbConnection(connectionstring); 
            var dataAdapter = new OleDbDataAdapter(select, c);

            var commandBuilder = new OleDbCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            ProfOfNonEndedProjs.ReadOnly = true;
            ProfOfNonEndedProjs.DataSource = ds.Tables[0];

        }

        private void ShowProjAndWorkersForPeriod_Click(object sender, EventArgs e)
        {



            
            


            OleDbConnection = new OleDbConnection(connectionstring);
            OleDbConnection.Open();
       
            OleDbCommand ShowProjAndWorkersForPeriod = new OleDbCommand("SELECT FIRST_NAME,PATHER_NAME,LAST_NAME,POSITION,SALARY,DEPARTMENTS_EMPLOYEES.DEPARTMENT_ID,PROJECTS.NAME AS PROJECT_NAME FROM EMPLOYEES JOIN DEPARTMENTS_EMPLOYEES on(departments_employees.employee_id = employees.id) JOIN PROJECTS on(departments_employees.department_id = projects.department_id) WHERE PROJECTS.DATE_BEG >= :date_beg  AND PROJECTS.DATE_END_REAL <= :date_end_real", OleDbConnection);
            ShowProjAndWorkersForPeriod.Parameters.Add(":date_beg", OleDbType.Date).Value = DataBank.AccForm.DateBeg.SelectionStart.Date.ToString("dd-MM-yyyy");
            ShowProjAndWorkersForPeriod.Parameters.Add(":date_end_real", OleDbType.Date).Value = DataBank.AccForm.DateEnd.SelectionStart.Date.ToString("dd-MM-yyyy");
          

            var reader = ShowProjAndWorkersForPeriod.ExecuteReader();

            if (reader.HasRows)
            {


                while (reader.Read())
                {
                    ProjAndWorkersForPeriod.Text += (Convert.ToString(reader["first_name"]) + "    " + Convert.ToString(reader["pather_name"]) + "       " + Convert.ToString(reader["last_name"]) + Convert.ToString(reader["position"]) + Convert.ToString(reader["salary"]) + Convert.ToString(reader["department_id"]) + Convert.ToString(reader["project_name"]) + "\n");
                }

                reader.Close();
            }

            else if (!reader.HasRows)
            {
                MessageBox.Show("Для указанной даты данных нет");
            }

            var select = "SELECT FIRST_NAME,PATHER_NAME,LAST_NAME,POSITION,SALARY,DEPARTMENTS_EMPLOYEES.DEPARTMENT_ID,PROJECTS.NAME AS PROJECT_NAME FROM EMPLOYEES JOIN DEPARTMENTS_EMPLOYEES on(departments_employees.employee_id = employees.id) JOIN PROJECTS on(departments_employees.department_id = projects.department_id) WHERE PROJECTS.DATE_BEG >= '" + DataBank.AccForm.DateBeg.SelectionStart.Date.ToString("yyyy-MM-dd") + "' AND PROJECTS.DATE_END_REAL <= '"+ DataBank.AccForm.DateEnd.SelectionStart.Date.ToString("yyyy-MM-dd") +"'";
            var c = new OleDbConnection(connectionstring); 
            var dataAdapter = new OleDbDataAdapter(select, c);

            var commandBuilder = new OleDbCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            ProjAndEmplsForPer.ReadOnly = true;
            ProjAndEmplsForPer.DataSource = ds.Tables[0];



        }

        private void MonthExpensesForProjs_Click(object sender, EventArgs e)
        {
            OleDbConnection = new OleDbConnection(connectionstring);
            OleDbConnection.Open();


            



            OleDbCommand MonthExpensesForProjs = new OleDbCommand("Select name, cost, ( SUM(employees.salary) ) AS expenses from projects INNER JOIN DEPARTMENTS_EMPLOYEES on (departments_employees.department_id = projects.department_id)  INNER JOIN EMPLOYEES on(departments_employees.employee_id = EMPLOYEES.id) group by name,cost", OleDbConnection);



            var reader = MonthExpensesForProjs.ExecuteReader();

            if (reader.HasRows)
            {
        
                while (reader.Read()) 
                {
                    MonthExpensesForProjects.Text += (Convert.ToString(reader["name"]) + Convert.ToString(reader["cost"]) + "    " + Convert.ToString(reader["expenses"])  + "\n");
                }
            }
            reader.Close();



            var select = "Select name, cost, ( SUM(employees.salary) ) AS expenses from projects INNER JOIN DEPARTMENTS_EMPLOYEES on (departments_employees.department_id = projects.department_id)  INNER JOIN EMPLOYEES on(departments_employees.employee_id = EMPLOYEES.id) group by name,cost";
            var c = new OleDbConnection(connectionstring); 
            var dataAdapter = new OleDbDataAdapter(select, c);

            var commandBuilder = new OleDbCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            MonthExpenses.ReadOnly = true;
            MonthExpenses.DataSource = ds.Tables[0];

        }

        private void ShowDeptsAndAvgTimeWork_Click(object sender, EventArgs e)
        {
            OleDbConnection = new OleDbConnection(connectionstring);
            OleDbConnection.Open();
            OleDbCommand AvgProjTimeForDepts = new OleDbCommand("Select departments.id, AVG (PROJECTS.date_end_real - PROJECTS.date_beg) AS avg_working_time From departments JOIN Projects on departments.id = PROJECTS.department_id  GROUP By departments.id", OleDbConnection);
   

            var reader = AvgProjTimeForDepts.ExecuteReader();

            if (reader.HasRows)
            {


                while (reader.Read()) 
                {
                   
                    DeptsAndAvgWorkTime.Text += (Convert.ToString(reader[0]) + "   " + Convert.ToString(reader[1]) + "\n");
                }
            }


            var select = "Select departments.id, AVG (PROJECTS.date_end_real - PROJECTS.date_beg) AS avg_working_time From departments JOIN Projects on departments.id = PROJECTS.department_id  GROUP By departments.id";
            var c = new OleDbConnection(connectionstring); 
            var dataAdapter = new OleDbDataAdapter(select, c);

            var commandBuilder = new OleDbCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            DeptsAndAvgTimeOfWork.ReadOnly = true;
            DeptsAndAvgTimeOfWork.DataSource = ds.Tables[0];

            //string path = @"E:\СУБД\Моя курсовая\DBMS2semCourseWork";



            using (StreamWriter txt = new StreamWriter("E:\\СУБД\\Моя курсовая\\DBMS2semCourseWork\\AvgDeptWorkTime.txt"))
            {
                txt.Write("Отделы и их среднее время работы \n"+ DeptsAndAvgWorkTime.Text);
                
            }
            MessageBox.Show("Результат записан в AvgDeptWorkTime.txt");

            reader.Close();
        }

        private void ShowRecordTimeProjForDept_Click(object sender, EventArgs e)
        {
            OleDbCommand InBase = new OleDbCommand("SELECT COUNT(*) FROM departments WHERE name = '" + DeptNameForRec.Text + "'  ", OleDbConnection);

            int countofdept = 0;
            var reader4 = InBase.ExecuteReader();

            if (reader4.HasRows)
            {
          

                while (reader4.Read()) 
                {
                   
                    countofdept = (Convert.ToInt32(reader4[0]));
                }
            }
 

            reader4.Close();

            if (countofdept > 0)
            {
                try
                {
                    OleDbCommand GetProjId = new OleDbCommand("Select departments.id FROM departments INNER JOIN Projects on departments.id = projects.department_id WHERE departments.name = '" + DeptNameForRec.Text + "' ", OleDbConnection);
                    int deptid = 0;
                 

                    var reader1 = GetProjId.ExecuteReader();

                    if (reader1.HasRows)
                    {


                        while (reader1.Read())
                        {

                            deptid = (Convert.ToInt32(reader1[0]));
                        }
                    }
                    reader1.Close();


                    OleDbCommand HasProjs = new OleDbCommand("SELECT COUNT(*) FROM projects WHERE department_id = '" + deptid +"'", OleDbConnection);
                    int countofprojs = 0;
                    var reader8 = HasProjs.ExecuteReader();

                    if (reader8.HasRows)
                    {


                        while (reader8.Read()) 
                        {
                            
                            countofprojs = (Convert.ToInt32(reader8[0]));
                        }
                    }

                    if (countofprojs == 0)
                    {

                        MessageBox.Show("Данный отдел ещё не назначен ни на один проект");
                        OleDbConnection.Close();
                    }
                    else if(countofprojs != 0)
                    {
                        int last = 0;
                        OleDbCommand GetLast = new OleDbCommand("SELECT MAX(PROJECTS.date_end_real - PROJECTS.date_beg) FROM PROJECTS Where projects.department_id = " + deptid, OleDbConnection);



                        var reader2 = GetLast.ExecuteReader();

                        if (reader2.HasRows)
                        {


                            while (reader2.Read())
                            {

                                last = (Convert.ToInt32(reader2[0]));
                            }
                        }
                        reader2.Close();




                        OleDbCommand GetName = new OleDbCommand("Select name From projects WHERE (PROJECTS.date_end_real - PROJECTS.date_beg) = " + last, OleDbConnection);

                        string name = " ";

                        var reader3 = GetName.ExecuteReader();

                        if (reader3.HasRows)
                        {


                            while (reader3.Read())
                            {

                                name = (Convert.ToString(reader3[0]));
                            }
                        }
                        reader3.Close();

                        RecWorkTimeProjForDep.Text = "Длительность проекта: " + last + " (день)дней \n" + "Название проекта: " + name;

                        using (StreamWriter txt = new StreamWriter("E:\\СУБД\\Моя курсовая\\DBMS2semCourseWork\\RecordWorkTimeProjForDept.txt"))
                        {
                            txt.Write("Проект с рекордным временем для отдела, и его длительность: \n" + RecWorkTimeProjForDep.Text);
                        }
                        MessageBox.Show("Результат записан в RecordWorkTimeProjForDept.txt");
                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

              
            }

            else if (countofdept == 0)
            {
                MessageBox.Show("Такого отдела нет, или было задано пустое поле");
            }

            

        }

        private void ExecCursor_Click(object sender, EventArgs e)
        {
            OleDbCommand GetProfit = new OleDbCommand("profit", OleDbConnection);
            GetProfit.CommandType = CommandType.StoredProcedure;

           
            GetProfit.Parameters.Add("str_date", OleDbType.DBDate).Value = StartingDateForProfByPeriod.SelectionStart;
            GetProfit.Parameters.Add("prf", OleDbType.Numeric);


            GetProfit.Parameters[0].Direction = ParameterDirection.Input;
            GetProfit.Parameters[1].Direction = ParameterDirection.Output;


            GetProfit.ExecuteNonQuery();
            ProfOfProjForPeriod.Text = Convert.ToString(GetProfit.Parameters[1].Value);

            using (StreamWriter txt = new StreamWriter("E:\\СУБД\\Моя курсовая\\DBMS2semCourseWork\\ProfitForPeriod.txt"))
            {
                txt.Write("Суммарная прибыль за выбранный период: \n" + ProfOfProjForPeriod.Text);
            }
            MessageBox.Show("Результат записан в ProfitForPeriod.txt");



        }

        private void AccountantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
