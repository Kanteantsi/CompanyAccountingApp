using System;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DBMS2semCourseWork
{
    public partial class RegistrationAndAuthentificationForm : Form
    {
        string connectionstring = @"Provider=OraOLEDB.Oracle;OLEDB.NET=true;PLSQLRSet=true;USER ID=C##VLAD;DATA SOURCE=localhost:1521/xe;PASSWORD=V123456;";

        private OleDbConnection OleDbConnection = null;

        private OleDbCommandBuilder OleDbCommandBuilder = null;

        private OleDbDataAdapter OleDbDataAdapter = null;

        private DataSet dataSet = null;

        public RegistrationAndAuthentificationForm()
        {
            InitializeComponent();
        }


        private void SignUpAsAdm_Click(object sender, EventArgs e)
        {
            OleDbConnection = new OleDbConnection(connectionstring);
            OleDbConnection.Open();

            bool loginright = false;
            bool passwordright = false;

            if ((AdminLogin.Text == "") || (AdminPassw.Text == ""))
            {
                MessageBox.Show("Есть незаполненные поля");
            }
            else if ((AdminPassw.Text.Length < 8))
            {
                MessageBox.Show("Длина пароля должна составлять 8 или более символов");
            }
            else if ((AdminLogin.Text != "") && (AdminPassw.Text != ""))
            {
                string login = AdminLogin.Text;
                string password = Verification.GetSHA256Hash(AdminPassw.Text).ToLower();
                int countinbase = 0;

                OleDbCommand LoginExist = new OleDbCommand("SELECT COUNT(login) FROM dbusers WHERE login = '" + login + "'  ", OleDbConnection);


                var reader1 = LoginExist.ExecuteReader();

                if (reader1.HasRows)
                {


                    while (reader1.Read())
                    {
                    
                        countinbase = (Convert.ToInt32(reader1[0]));
                    }
                }
                reader1.Close();

                if (countinbase > 0)
                {
                    MessageBox.Show("Такой логин уже есть в базе, выберите другой");

                }
                else if (countinbase == 0)
                {
                    OleDbCommand RegisterAdmin = new OleDbCommand("INSERT INTO dbusers(login,password,role) VALUES('" + login + "','" + password + "','" + "ADMINISTRATOR')", OleDbConnection);
                    RegisterAdmin.ExecuteNonQuery();
                    this.Hide();
                    DataBank.AdmForm.Show();
                }
            }


            
        }

        private void SignUpAsAcc_Click(object sender, EventArgs e)
        {
            OleDbConnection = new OleDbConnection(connectionstring);
            OleDbConnection.Open();

            bool loginright = false;
            bool passwordright = false;

            if ((AccountantLogin.Text == "") || (AccountantPassw.Text == ""))
            {
                MessageBox.Show("Есть незаполненные поля");
            }
            else if ((AccountantPassw.Text.Length<8))
            {
                MessageBox.Show("Длина пароля должна составлять 8 или больше символов");
            }
            else if ((AccountantLogin.Text != "") && (AccountantPassw.Text != ""))
            {
                string login = AccountantLogin.Text;
                string password = Verification.GetSHA256Hash(AccountantPassw.Text).ToLower();
                int countinbase = 0;

                OleDbCommand LoginExist = new OleDbCommand("SELECT COUNT(login) FROM dbusers WHERE login = '" + login + "'  ", OleDbConnection);


                var reader1 = LoginExist.ExecuteReader();

                if (reader1.HasRows)
                {


                    while (reader1.Read()) 
                    {
                      
                        countinbase = (Convert.ToInt32(reader1[0]));
                    }
                }
                reader1.Close();

                if (countinbase > 0)
                {
                    MessageBox.Show("Такой логин уже есть в базе, выберите другой");

                }
                else if (countinbase == 0)
                {
                    OleDbCommand RegisterAdmin = new OleDbCommand("INSERT INTO dbusers(login,password,role) VALUES('" + login + "','" + password + "','" + "ACCOUNTANT')", OleDbConnection);
                    RegisterAdmin.ExecuteNonQuery();
                    this.Hide();
                    DataBank.AccForm.Show();
                }
            }
            
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            OleDbConnection = new OleDbConnection(connectionstring);
            OleDbConnection.Open();

            bool loginright = false;
            bool passwordright = false;

            string login = AuthLogin.Text;
            string password = Verification.GetSHA256Hash(AuthPassword.Text).ToLower();
            int countinbase = 0;
            string role = " ";

            if (AuthLogin.Text == ""|| AuthPassword.Text == "")
            {
                MessageBox.Show("Есть пустые поля");
            }

            OleDbCommand InBase = new OleDbCommand("SELECT COUNT(ID) FROM dbusers WHERE login = '" + login + "'  " + "AND password = '" + password + "'", OleDbConnection);
            

            var reader1 = InBase.ExecuteReader();

            if (reader1.HasRows)
            {


                while (reader1.Read()) 
                {
                  
                     countinbase = (Convert.ToInt32(reader1[0]));
                }
            }
            reader1.Close();

            if (countinbase > 0)
            {
                OleDbCommand GetRole = new OleDbCommand("SELECT role FROM dbusers WHERE login = '" + login + "'  " + "AND password = '" + password + "'", OleDbConnection);

                var reader2 = GetRole.ExecuteReader();

                while (reader2.Read()) 
                {
                 
                    role = (Convert.ToString(reader2[0]));
                }

                if (role == "ADMINISTRATOR")
                {
                    this.Hide();
                    DataBank.AdmForm.Show();
                }
                else if(role == "ACCOUNTANT")
                {
                    this.Hide();
                    DataBank.AccForm.Show();
                }
            }

            else if (countinbase == 0)
            {
                MessageBox.Show("Неверный логин или пароль");
            }




        }

        private void RegistrationAndAuthentificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
