using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace DBMS2semCourseWork
{
    public partial class AdministratorForm : Form
    {
        string connectionstring = @"Provider=OraOLEDB.Oracle;OLEDB.NET=true;PLSQLRSet=true;USER ID=C##VLAD;DATA SOURCE=localhost:1521/xe;PASSWORD=V123456;";

        private OleDbConnection OleDbConnection = null;

        private OleDbCommandBuilder OleDbCommandBuilder = null;

        private OleDbDataAdapter OleDbDataAdapter = null;

        private DataSet dataSet = null;

        private DataTable dataTable = null;
        private BindingSource bindingSource = null;

        private bool newRowAdding = false;

        public AdministratorForm()
        {
            InitializeComponent();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }
        private int lastIndexTable = 2;

        private string currentTable;

        private Dictionary<string, int> numberOfColumns =
        new Dictionary<string, int> { {"Departments", 1 },
                                          {"Departments_Employees",  2 },
                                          {"Employees",       5 },
                                           {"Projects",    6 }
                                      };

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




        private void LoadData()
        {
            try
            {

                OleDbConnection = new OleDbConnection(connectionstring);
                OleDbConnection.Open();
                OleDbDataAdapter = new OleDbDataAdapter("Select * FROM " + currentTable, OleDbConnection);
                OleDbCommandBuilder = new OleDbCommandBuilder(OleDbDataAdapter);
                
                dataTable = new DataTable();
                OleDbDataAdapter.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dataGridView1.DataSource = bindingSource;

                OleDbConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    ProjAndWorkers.Text += (Convert.ToString(reader["id"] + "  " + reader["name"]) + "    " + Convert.ToString(reader["cost"]) + "    " + Convert.ToString(reader["first_name"]) + "    " + Convert.ToString(reader["pather_name"]) + "       " + Convert.ToString(reader["last_name"]) + "\n");
                }
            }
            reader.Close();

            var select = "Select projects.id, name, cost, employees.first_name,employees.pather_name,employees.last_name from projects INNER JOIN DEPARTMENTS_EMPLOYEES on(departments_employees.department_id = projects.department_id) INNER JOIN EMPLOYEES on(departments_employees.employee_id = EMPLOYEES.id)";
            var c = new OleDbConnection(connectionstring);
            var dataAdapter = new OleDbDataAdapter(select, c);

            var commandBuilder = new OleDbCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            ProjsAndTheirWorkers.ReadOnly = true;
            ProjsAndTheirWorkers.DataSource = ds.Tables[0];
        }

        private void ShowProjAndWorkersForPeriod_Click(object sender, EventArgs e)
        {


            OleDbConnection = new OleDbConnection(connectionstring);
            OleDbConnection.Open();

            OleDbCommand ShowProjAndWorkersForPeriod = new OleDbCommand("SELECT FIRST_NAME,PATHER_NAME,LAST_NAME,POSITION,SALARY,DEPARTMENTS_EMPLOYEES.DEPARTMENT_ID,PROJECTS.NAME AS PROJECT_NAME FROM EMPLOYEES JOIN DEPARTMENTS_EMPLOYEES on(departments_employees.employee_id = employees.id) JOIN PROJECTS on(departments_employees.department_id = projects.department_id) WHERE PROJECTS.DATE_BEG >= :date_beg  AND PROJECTS.DATE_END_REAL <= :date_end_real", OleDbConnection);
            ShowProjAndWorkersForPeriod.Parameters.Add(":date_beg", OleDbType.Date).Value = DataBank.AdmForm.DateBeg.SelectionStart.Date.ToString("dd-MM-yyyy");
            ShowProjAndWorkersForPeriod.Parameters.Add(":date_end_real", OleDbType.Date).Value = DataBank.AdmForm.DateEnd.SelectionStart.Date.ToString("dd-MM-yyyy");


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
                MessageBox.Show("Для данного периода данных о проектах их сотрудниках не найдено");
            }


            var select = "SELECT FIRST_NAME,PATHER_NAME,LAST_NAME,POSITION,SALARY,DEPARTMENTS_EMPLOYEES.DEPARTMENT_ID,PROJECTS.NAME AS PROJECT_NAME FROM EMPLOYEES JOIN DEPARTMENTS_EMPLOYEES on(departments_employees.employee_id = employees.id) JOIN PROJECTS on(departments_employees.department_id = projects.department_id) WHERE PROJECTS.DATE_BEG >= '" + DataBank.AdmForm.DateBeg.SelectionStart.Date.ToString("yyyy-MM-dd") + "' AND PROJECTS.DATE_END_REAL <= '" + DataBank.AdmForm.DateEnd.SelectionStart.Date.ToString("yyyy-MM-dd") + "'";
            var c = new OleDbConnection(connectionstring); // Your Connection String here
            var dataAdapter = new OleDbDataAdapter(select, c);

            var commandBuilder = new OleDbCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            ProjAndWorksForPer.ReadOnly = true;
            ProjAndWorksForPer.DataSource = ds.Tables[0];

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

                    DeptsAndAvgWorkTime.Text += (Convert.ToString(reader[0]) + "   " + Convert.ToString(reader[1]) + "\n" );
                }
                
            }


            reader.Close();

            using (StreamWriter txt = new StreamWriter("E:\\СУБД\\Моя курсовая\\DBMS2semCourseWork\\AvgDeptWorkTime.txt"))
            {
                txt.Write("Отделы и их среднее время работы \n" + DeptsAndAvgWorkTime.Text);

            }
            MessageBox.Show("Результат записан в AvgDeptWorkTime.txt");


            


            var select = "Select departments.id, AVG (PROJECTS.date_end_real - PROJECTS.date_beg) AS avg_working_time From departments JOIN Projects on departments.id = PROJECTS.department_id  GROUP By departments.id";
            var c = new OleDbConnection(connectionstring); // Your Connection String here
            var dataAdapter = new OleDbDataAdapter(select, c);

            var commandBuilder = new OleDbCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            DeptsAndAvgTimeOfWork.ReadOnly = true;
            DeptsAndAvgTimeOfWork.DataSource = ds.Tables[0];

        }

        private void ChTableToEmpls_Click_1(object sender, EventArgs e)
        {
            GetAndFillTable("Employees");
        }

        private void ChTableToDepts_Click_1(object sender, EventArgs e)
        {
            GetAndFillTable("Departments");
        }

        private void ChTableToDeptsEmpls_Click_1(object sender, EventArgs e)
        {
            GetAndFillTable("Departments_Employees");
        }

        private void ChTableToProjs_Click_1(object sender, EventArgs e)
        {
            GetAndFillTable("Projects");
        }


        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            OleDbConnection = new OleDbConnection(connectionstring);

            OleDbConnection.Open();


        }

        private void ShowSameProjsForTwoEmpls_Click(object sender, EventArgs e)
        {
            OleDbConnection = new OleDbConnection(connectionstring);
            OleDbConnection.Open();
        

            
            OleDbCommand GetId1 = new OleDbCommand("SELECT ID FROM EMPLOYEES WHERE FIRST_NAME = '" + DataBank.AdmForm.FirEmplFN.Text + "'  " + "AND PATHER_NAME = '" + DataBank.AdmForm.FirEmplPN.Text + "' AND LAST_NAME = '" + DataBank.AdmForm.FirEmplLN.Text + "'", OleDbConnection);
            int emplid1 = 0;

            var reader1 = GetId1.ExecuteReader();

            if (reader1.HasRows)
            {
          

                while (reader1.Read()) 
                {
                    emplid1 = (Convert.ToInt32(reader1[0]));
                }
            }
            reader1.Close();

            OleDbCommand GetId2 = new OleDbCommand("SELECT ID FROM EMPLOYEES WHERE FIRST_NAME = '" + DataBank.AdmForm.SecEmplFN.Text + "'  " + "AND PATHER_NAME = '" + DataBank.AdmForm.SecEmplPN.Text + "' AND LAST_NAME = '" + DataBank.AdmForm.SecEmplLN.Text + "'", OleDbConnection);
            int emplid2 = 0;

            var reader2 = GetId1.ExecuteReader();

            if (reader2.HasRows)
            {
  

                while (reader2.Read()) 
                {
       
                    emplid2 = (Convert.ToInt32(reader2[0]));
                }
            }
            reader2.Close();


            OleDbCommand ShowSameProjsForTwoEmpls = new OleDbCommand("SELECT NAME FROM PROJECTS PJ WHERE EXISTS (SELECT DEPARTMENT_ID FROM DEPARTMENTS_EMPLOYEES DPE WHERE DEPARTMENT_ID = PJ.DEPARTMENT_ID AND EMPLOYEE_ID = " + emplid1 + " AND EXISTS (SELECT DEPARTMENT_ID FROM DEPARTMENTS_EMPLOYEES WHERE DEPARTMENT_ID = DPE.DEPARTMENT_ID AND EMPLOYEE_ID = " + emplid2 + "))", OleDbConnection);




            var reader = ShowSameProjsForTwoEmpls.ExecuteReader();

            if (reader.HasRows)
            {


                while (reader.Read()) 
                {
                    
                    SameProjForTwoEmpl.Text += (Convert.ToString(reader[0]) + "\n");


                }
                reader.Close();

                using (StreamWriter txt = new StreamWriter("E:\\СУБД\\Моя курсовая\\DBMS2semCourseWork\\SameProjForTwoEmpls.txt"))
                {
                    txt.Write("Проекты, в которых участвовали оба введённых сотрудника: \n" + SameProjForTwoEmpl.Text);
                }
                MessageBox.Show("Результат записан в SameProjForTwoEmpls.txt");
            }
            else if(!reader.HasRows)
            {
                MessageBox.Show("Для этих сотрудников данных о совместных проектах не найдено, или были заданы пустые поля");
            }
        }

        private void DeleteFromDeptSmallSalary_Click(object sender, EventArgs e)
        {

            try
            {

          
            
            using (var con = new OleDbConnection(connectionstring))
            {
                con.Open();

                OleDbCommand InBase = new OleDbCommand("SELECT COUNT(*) FROM departments WHERE name = '" + DeptNameForDelEmpl.Text + "'  ", con);

                int countofdept = 0;
                
                var reader4 = InBase.ExecuteReader();

                if (reader4.HasRows)
                {


                    while (reader4.Read())
                    {

                        countofdept = (Convert.ToInt32(reader4[0]));
                    }
                    reader4.Close();
                }

                    

                if (countofdept > 0)
                {
                    try
                    {


                        OleDbCommand GetProjId = new OleDbCommand("Select departments.id FROM departments WHERE departments.name = '" + DeptNameForDelEmpl.Text + "' ", con);
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

                        OleDbCommand DeleteFromDeptSmallSalary = new OleDbCommand("DELETE FROM DEPARTMENTS_EMPLOYEES WHERE department_id = "+deptid+ " AND EMPLOYEE_ID = ( SELECT EMPLOYEE_ID FROM DEPARTMENTS_EMPLOYEES   JOIN Employees on  DEPARTMENTS_EMPLOYEES.employee_id = employees.id  WHERE DEPARTMENT_ID = "+deptid+" AND EMPLOYEES.SALARY = (SELECT MIN(SALARY) FROM EMPLOYEES JOIN  DEPARTMENTS_EMPLOYEES on DEPARTMENTS_EMPLOYEES.employee_id = employees.id) AND ROWNUM = 1)", con);
                        DeleteFromDeptSmallSalary.ExecuteNonQuery();
                        MessageBox.Show("Сотрудник с наименьшей зарплатой был удалён");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        //con.Close();
                    }
                }

                else if ((countofdept == 0) || (DeptNameForDelEmpl.Text == ""))
                {
                    MessageBox.Show("Такого отдела нет, или поле ввода пустое");
                    //con.Close();
                }

            }



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void DeleteRestingDepartment_Click(object sender, EventArgs e)
        {
            int iddept = -1;

            using (var con = new OleDbConnection(connectionstring))
            {
                con.Open();
                
                var cmd = new OleDbCommand("SELECT department_id  FROM   DEPARTMENTS_EMPLOYEES   WHERE NOT EXISTS (SELECT department_id FROM projects WHERE Departments_employees.department_id = projects.department_id) GROUP BY department_id    HAVING COUNT(EMPLOYEE_ID) >= 3", OleDbConnection);
                cmd.Connection = con;
               
                var reader4 = cmd.ExecuteReader();

                if (reader4.HasRows)
                {
                    

                    while (reader4.Read()) 
                    {
                      
                        iddept = (Convert.ToInt32(reader4[0]));
                    }
                    reader4.Close();
                   
                }
                

                if ((iddept == -1))
                {
                    MessageBox.Show("Нет отдела, который не был бы занят в проектах, имея при этом трёх или больше сотрудников");

                }
                else if (iddept != -1)
                {
                   
                    {

                        OleDbCommand cmd1 = new OleDbCommand("DELETE FROM DEPARTMENTS WHERE ID = (SELECT DEPARTMENT_ID  FROM   DEPARTMENTS_EMPLOYEES   WHERE NOT EXISTS(SELECT department_id FROM projects WHERE Departments_employees.department_id = projects.department_id)   GROUP BY department_id    HAVING COUNT(EMPLOYEE_ID) >= 3)", OleDbConnection);
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        

                        iddept = -1;
                        MessageBox.Show("Были успешно удалены отделы,которые не были бы заняты в проектах, имея при этом трёх или больше сотрудников ");
                    }
                }

               
            }



        }

        private void ChangeProjDateEndRealByName_Click(object sender, EventArgs e)
        {

            using (var con = new OleDbConnection(connectionstring))
            {
                con.Open();
                int countofproj = 0;
                var cmd = new OleDbCommand("SELECT COUNT(*) FROM projects WHERE name = '" + ProjectForDateChangeName.Text + "'  ", OleDbConnection);
                cmd.Connection = con;
               
                var reader4 = cmd.ExecuteReader();

                if (reader4.HasRows)
                {


                    while (reader4.Read()) 
                    {
                        
                        countofproj = (Convert.ToInt32(reader4[0]));
                    }
                    reader4.Close();
                   
                }
                

                if ((countofproj == 0)||(ProjectForDateChangeName.Text == ""))
                {
                    MessageBox.Show("Проекта с таким именем не найдено, или задано пустое поле");
              
                }
                else if (!((countofproj == 0) || (ProjectForDateChangeName.Text == "")))
                {
                   try
                    {

                        string test2 = DateOfEndReal.SelectionStart.ToString("yyyy-MM-dd");
                        var cmd1 = new OleDbCommand("UPDATE projects SET date_end_real = '" + test2 + "' where name = '" + ProjectForDateChangeName.Text + "'", OleDbConnection);
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Для проекта была успешно изменена дата реального окончания");
                        con.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());

                    }

                }

                
            }


        }

        private void ChangeNameOfProject_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connectionstring))
            {
                con.Open();
                int countofproj = 0;
                var cmd = new OleDbCommand("SELECT COUNT(*) FROM projects WHERE name = '" + OldNameOfChangedProject.Text + "'  ", OleDbConnection);
                cmd.Connection = con;

                var reader4 = cmd.ExecuteReader();

                if (reader4.HasRows)
                {


                    while (reader4.Read()) 
                    {
                     
                        countofproj = (Convert.ToInt32(reader4[0]));
                    }
                    reader4.Close();

                }


                if ((countofproj == 0) || (OldNameOfChangedProject.Text == ""))
                {
                    MessageBox.Show("Проекта с таким именем не найдено, или задано пустое поле");
                    //con.Close();
                }
                else if (!((countofproj == 0) || (OldNameOfChangedProject.Text == "")))

                {
                    //con.Open();
                    var cmd1 = new OleDbCommand("UPDATE projects SET name = '" + NewNameOfChangedProject.Text + "' where name = '" + OldNameOfChangedProject.Text + "'", OleDbConnection);
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Для проекта была успешно изменено название");
                    con.Close();
                }


            }
        }

    

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataAdapter.Update(dataTable);
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                OleDbDataAdapter.Update(dataTable);
            }
            catch (Exception exceptionObj)
            {
             
                MessageBox.Show(exceptionObj.Message.ToString());
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
                  
            {
             
                MessageBox.Show("Введённые данные имели неправильный формат. Будьте внимательны");
            }
        }

        private void AdministratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AddNewProjTransac_Click(object sender, EventArgs e)
        {
            try {
            using (var con = new OleDbConnection(connectionstring))
            {
                con.Open();
                int deptid = 0;
                var cmd = new OleDbCommand("SELECT id FROM departments WHERE name = '" + DeptNameForTransac.Text + "'  ", OleDbConnection);
                cmd.Connection = con;

                var reader4 = cmd.ExecuteReader();

                if (reader4.HasRows)
                {


                    while (reader4.Read()) 
                    {
                     
                        deptid = (Convert.ToInt32(reader4[0]));
                    }
                    reader4.Close();

                }


                if ((deptid == 0) || (DeptNameForTransac.Text == ""))
                {
                    MessageBox.Show("Проект не может быть добавлен, так как отдела с таким именем не найдено, или задано пустое поле");
                   
                }
                else if ((ProjCostForTransac.Text == "")||(Regex.Match(ProjCostForTransac.Text, @"[а-яА-Я]|[a-zA-Z]").Success))


                {
                    MessageBox.Show("Проект не может быть добавлен, так как поле стоимости пустое или содержит буквы ");
                    
                }


                    else if ((ProjNameForTransac.Text == ""))


                    {
                        MessageBox.Show("Проект не может быть добавлен, так как поле названия проекта пустое");
                       
                    }

                    int period = 0;


                var cmd2 = new OleDbCommand("SELECT TRUNC (TO_DATE ('" + DateEndRealForTransac.SelectionStart.ToString("yyyy-MM-dd") + "', 'yyyy/mm/dd') - TO_DATE ('" + DateBegForTransac.SelectionStart.ToString("yyyy-MM-dd") + "', 'yyyy/mm/dd')) FROM DUAL", OleDbConnection);
                    cmd2.Connection = con;

                    var reader2 = cmd2.ExecuteReader();




                if (reader2.HasRows)
                {
      

                    while (reader2.Read()) 
                    {

                        period = (Convert.ToInt32(reader2[0]));
                    }
                    reader2.Close();

                }

                  int period1 = 0;

                    var cmd3 = new OleDbCommand("SELECT TRUNC (TO_DATE ('" + DateEndForTransac.SelectionStart.ToString("yyyy-MM-dd") + "', 'yyyy/mm/dd') - TO_DATE ('" + DateBegForTransac.SelectionStart.ToString("yyyy-MM-dd") + "', 'yyyy/mm/dd')) FROM DUAL", OleDbConnection);
                    cmd3.Connection = con;

                    var reader3 = cmd3.ExecuteReader();




                    if (reader3.HasRows)
                    {


                        while (reader3.Read()) 
                        {
                           
                            period1 = (Convert.ToInt32(reader3[0]));
                        }
                        reader3.Close();

                    }


                    if ((ProjCostForTransac.Text != "") && (Regex.Match(ProjCostForTransac.Text, @"[а-яА-Я]|[a-zA-Z]").Success) && (deptid != 0) || (DeptNameForTransac.Text != ""))
                { 

                if (period <= 0)
                    {
                        MessageBox.Show("Проект не может быть добавлен, так как дата реального окончания раньше даты начала, или совпадает с ней");
                    }
                else if (period1 <= 0)
                        {
                            MessageBox.Show("Проект не может быть добавлен, так как дата окончания раньше даты начала, или совпадает с ней");
                        }
                else if ( (period <= 60) && (period > 0) )
                {
                    try
                    {
                        var cmd1 = new OleDbCommand("INSERT INTO PROJECTS(name, cost, department_id,date_beg,date_end,date_end_real) VALUES('" + ProjNameForTransac.Text + "', " + Convert.ToInt32(ProjCostForTransac.Text) + "," + deptid + ",'" + DateBegForTransac.SelectionStart.ToString("yyyy-MM-dd") + "','" + DateEndForTransac.SelectionStart.ToString("yyyy-MM-dd") + "','" + DateEndRealForTransac.SelectionStart.ToString("yyyy-MM-dd") + "')", OleDbConnection);
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Проект был успешно добавлен");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                }
                else if (period > 60)
                {
                    MessageBox.Show("Проект не может быть добавлен, так как разница между его началом и реальным окончанием больше двух месяцев");
                }

                }



            }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



   
    }
}
