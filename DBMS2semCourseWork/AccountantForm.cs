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

                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{

                //    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                //    dataGridView1[lastIndexTable, i] = linkCell;
                //}

                //dataGridView1.Refresh();
                //dataGridView1.Update();
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
            //SqlDataReader sqlReader = null;
            //var cultureInfo = new CultureInfo("	it-it");
            OleDbCommand ProjEndednByToday = new OleDbCommand("Select * From projects Where date_end_real < SYSDATE", OleDbConnection);
     


            var reader = ProjEndednByToday.ExecuteReader();

            if (reader.HasRows)
            {
                //Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                while (reader.Read()) /*ManagerFullName,RequestDate,ClientFullName,Acceptance*/
                {
                    ProjEndByToday.Text += (Convert.ToString(reader["id"] + "  " + reader["name"]) + "    " + Convert.ToString(reader["cost"]) + "    " + Convert.ToString(reader["department_id"]) + "    " + Convert.ToString(reader["date_beg"]) + "       " + Convert.ToString(reader["date_end"]) + Convert.ToString(reader["date_end_real"])  + "\n");
                }
            }
            reader.Close();
        }

        private void ShowProjAndWorkers_Click(object sender, EventArgs e)
        {
            

            OleDbConnection = new OleDbConnection(connectionstring);
            OleDbConnection.Open();
            //SqlDataReader sqlReader = null;
            //var cultureInfo = new CultureInfo("	it-it");
            OleDbCommand ShowProjAndWorkers = new OleDbCommand("Select projects.id, name, cost, employees.first_name,employees.pather_name,employees.last_name from projects INNER JOIN DEPARTMENTS_EMPLOYEES on(departments_employees.department_id = projects.department_id) INNER JOIN EMPLOYEES on(departments_employees.employee_id = EMPLOYEES.id)", OleDbConnection);



            var reader = ShowProjAndWorkers.ExecuteReader();

            if (reader.HasRows)
            {
                //Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                while (reader.Read()) /*ManagerFullName,RequestDate,ClientFullName,Acceptance*/
                {
                    ProjAndWorkers.Text += (Convert.ToString(reader["id"] + "  " +  reader["name"]) + "    " + Convert.ToString(reader["cost"]) + "    " + Convert.ToString(reader["first_name"]) + "    " + Convert.ToString(reader["pather_name"]) + "       " + Convert.ToString(reader["last_name"]) + "\n");
                }
            }
            reader.Close();


        }

        private void ShowProfOfNonEndProjects_Click(object sender, EventArgs e)
        {
            


            OleDbConnection = new OleDbConnection(connectionstring);
            OleDbConnection.Open();
            //SqlDataReader sqlReader = null;
            //var cultureInfo = new CultureInfo("	it-it");
            OleDbCommand ShowProjAndWorkers = new OleDbCommand("Select name, cost, projects.cost - MONTHS_BETWEEN(TO_DATE(projects.DATE_END_REAL), TO_DATE(projects.date_beg)) * SUM(employees.salary) AS profit from projects INNER JOIN DEPARTMENTS_EMPLOYEES on(departments_employees.department_id = projects.department_id) INNER JOIN EMPLOYEES on(departments_employees.employee_id = EMPLOYEES.id) Where projects.DATE_END_REAL > SYSDATE group by name,cost,projects.DATE_END_REAL,projects.date_beg", OleDbConnection);



            var reader = ShowProjAndWorkers.ExecuteReader();

            if (reader.HasRows)
            {
                //Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                while (reader.Read()) /*ManagerFullName,RequestDate,ClientFullName,Acceptance*/
                {
                    ProfOfNotEndProj.Text += (Convert.ToString(reader["name"] + "  " + reader["cost"]) +  "    " + Convert.ToString(reader["profit"]) + "\n");
                }
            }
            reader.Close();

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
            string path = @"E:\SUBD\MY COURSEWORK\DBMS2semCourseWork";
            using (FileStream fstream = new FileStream($"{path}\avgDeptWorkTime.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(DeptsAndAvgWorkTime.Text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                MessageBox.Show("Результат записан в файл avgDeptWorkTime.txt");
            }

            reader.Close();
        }

        private void ShowRecordTimeProjForDept_Click(object sender, EventArgs e)
        {
            OleDbCommand InBase = new OleDbCommand("SELECT COUNT(*) FROM departments WHERE name = '" + DeptNameForRec.Text + "'  ", OleDbConnection);

            int countofdept = 0;
            var reader4 = InBase.ExecuteReader();

            if (reader4.HasRows)
            {
                //Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                while (reader4.Read()) /*ManagerFullName,RequestDate,ClientFullName,Acceptance*/
                {
                    //ProjAndWorkersForPeriod.Text += (Convert.ToString(reader["id"] ) + Convert.ToString(reader["first_name"]) + "    " + Convert.ToString(reader["pather_name"]) + "       " + Convert.ToString(reader["last_name"]) + Convert.ToString(reader["position"]) + Convert.ToString(reader["salary"]) + Convert.ToString(reader["id_1"]) + Convert.ToString(reader["department_id"]) + Convert.ToString(reader["employee_id"]) + Convert.ToString(reader["id_2"]) + Convert.ToString(reader["name"])  + "    " + Convert.ToString(reader["cost"]) + "    " + Convert.ToString(reader["department_id_1"]) + "    " + Convert.ToString(reader["date_beg"]) + "       " + Convert.ToString(reader["date_end"]) + Convert.ToString(reader["date_end_real"]) + "\n");
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
                    //string projname;

                    var reader1 = GetProjId.ExecuteReader();

                    if (reader1.HasRows)
                    {


                        while (reader1.Read())
                        {

                            deptid = (Convert.ToInt32(reader1[0]));
                        }
                    }
                    reader1.Close();

                    OleDbCommand GetLast = new OleDbCommand("SELECT MAX(PROJECTS.date_end_real - PROJECTS.date_beg) FROM PROJECTS Where projects.department_id = " + deptid, OleDbConnection);

                    int last = 0;

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

                    RecWorkTimeProjForDep.Text = "Длительность проекта: " + last + "Название проекта: " + name;

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



        }
    }
}
