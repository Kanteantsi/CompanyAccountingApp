
namespace DBMS2semCourseWork
{
    partial class RegistrationAndAuthentificationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Switch = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SignUpAsAdm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.AdmLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AdmPatherName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AdmFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.admlog = new System.Windows.Forms.Label();
            this.AdminPassw = new System.Windows.Forms.TextBox();
            this.AdminLogin = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SignUpAsAcc = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.AccLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AccPatherName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AccFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountantPassw = new System.Windows.Forms.TextBox();
            this.AccountantLogin = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LogIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AuthPassword = new System.Windows.Forms.TextBox();
            this.AuthLogin = new System.Windows.Forms.TextBox();
            this.Switch.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Switch
            // 
            this.Switch.Controls.Add(this.tabPage1);
            this.Switch.Controls.Add(this.tabPage2);
            this.Switch.Controls.Add(this.tabPage3);
            this.Switch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Switch.Location = new System.Drawing.Point(465, 256);
            this.Switch.Name = "Switch";
            this.Switch.SelectedIndex = 0;
            this.Switch.Size = new System.Drawing.Size(970, 547);
            this.Switch.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage1.Controls.Add(this.SignUpAsAdm);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.AdmLastName);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.AdmPatherName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.AdmFirstName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.admlog);
            this.tabPage1.Controls.Add(this.AdminPassw);
            this.tabPage1.Controls.Add(this.AdminLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(962, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Administrator";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // SignUpAsAdm
            // 
            this.SignUpAsAdm.Location = new System.Drawing.Point(300, 351);
            this.SignUpAsAdm.Name = "SignUpAsAdm";
            this.SignUpAsAdm.Size = new System.Drawing.Size(148, 42);
            this.SignUpAsAdm.TabIndex = 10;
            this.SignUpAsAdm.Text = "Sign up as administrator";
            this.SignUpAsAdm.UseVisualStyleBackColor = true;
            this.SignUpAsAdm.Click += new System.EventHandler(this.SignUpAsAdm_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Last Name";
            this.label8.Visible = false;
            // 
            // AdmLastName
            // 
            this.AdmLastName.Location = new System.Drawing.Point(485, 277);
            this.AdmLastName.Name = "AdmLastName";
            this.AdmLastName.Size = new System.Drawing.Size(118, 20);
            this.AdmLastName.TabIndex = 8;
            this.AdmLastName.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pather Name";
            this.label7.Visible = false;
            // 
            // AdmPatherName
            // 
            this.AdmPatherName.Location = new System.Drawing.Point(300, 277);
            this.AdmPatherName.Name = "AdmPatherName";
            this.AdmPatherName.Size = new System.Drawing.Size(118, 20);
            this.AdmPatherName.TabIndex = 6;
            this.AdmPatherName.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "First Name";
            this.label6.Visible = false;
            // 
            // AdmFirstName
            // 
            this.AdmFirstName.Location = new System.Drawing.Point(102, 277);
            this.AdmFirstName.Name = "AdmFirstName";
            this.AdmFirstName.Size = new System.Drawing.Size(118, 20);
            this.AdmFirstName.TabIndex = 4;
            this.AdmFirstName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // admlog
            // 
            this.admlog.AutoSize = true;
            this.admlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admlog.Location = new System.Drawing.Point(43, 74);
            this.admlog.Name = "admlog";
            this.admlog.Size = new System.Drawing.Size(55, 27);
            this.admlog.TabIndex = 2;
            this.admlog.Text = "Login";
            this.admlog.UseCompatibleTextRendering = true;
            // 
            // AdminPassw
            // 
            this.AdminPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminPassw.Location = new System.Drawing.Point(158, 134);
            this.AdminPassw.Name = "AdminPassw";
            this.AdminPassw.Size = new System.Drawing.Size(151, 29);
            this.AdminPassw.TabIndex = 1;
            // 
            // AdminLogin
            // 
            this.AdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminLogin.Location = new System.Drawing.Point(158, 71);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(151, 29);
            this.AdminLogin.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage2.Controls.Add(this.SignUpAsAcc);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.AccLastName);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.AccPatherName);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.AccFirstName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.AccountantPassw);
            this.tabPage2.Controls.Add(this.AccountantLogin);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(962, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Accountant";
            // 
            // SignUpAsAcc
            // 
            this.SignUpAsAcc.Location = new System.Drawing.Point(296, 349);
            this.SignUpAsAcc.Name = "SignUpAsAcc";
            this.SignUpAsAcc.Size = new System.Drawing.Size(167, 52);
            this.SignUpAsAcc.TabIndex = 16;
            this.SignUpAsAcc.Text = "Sign up as accountant";
            this.SignUpAsAcc.UseVisualStyleBackColor = true;
            this.SignUpAsAcc.Click += new System.EventHandler(this.SignUpAsAcc_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Last Name";
            this.label9.Visible = false;
            // 
            // AccLastName
            // 
            this.AccLastName.Location = new System.Drawing.Point(499, 270);
            this.AccLastName.Name = "AccLastName";
            this.AccLastName.Size = new System.Drawing.Size(118, 20);
            this.AccLastName.TabIndex = 14;
            this.AccLastName.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Pather Name";
            this.label10.Visible = false;
            // 
            // AccPatherName
            // 
            this.AccPatherName.Location = new System.Drawing.Point(314, 270);
            this.AccPatherName.Name = "AccPatherName";
            this.AccPatherName.Size = new System.Drawing.Size(118, 20);
            this.AccPatherName.TabIndex = 12;
            this.AccPatherName.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "First Name";
            this.label11.Visible = false;
            // 
            // AccFirstName
            // 
            this.AccFirstName.Location = new System.Drawing.Point(127, 270);
            this.AccFirstName.Name = "AccFirstName";
            this.AccFirstName.Size = new System.Drawing.Size(118, 20);
            this.AccFirstName.TabIndex = 10;
            this.AccFirstName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // AccountantPassw
            // 
            this.AccountantPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountantPassw.Location = new System.Drawing.Point(159, 118);
            this.AccountantPassw.Name = "AccountantPassw";
            this.AccountantPassw.Size = new System.Drawing.Size(151, 29);
            this.AccountantPassw.TabIndex = 5;
            // 
            // AccountantLogin
            // 
            this.AccountantLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountantLogin.Location = new System.Drawing.Point(159, 52);
            this.AccountantLogin.Name = "AccountantLogin";
            this.AccountantLogin.Size = new System.Drawing.Size(151, 29);
            this.AccountantLogin.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage3.Controls.Add(this.LogIn);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.AuthPassword);
            this.tabPage3.Controls.Add(this.AuthLogin);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(962, 521);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sign In";
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(218, 233);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(132, 44);
            this.LogIn.TabIndex = 12;
            this.LogIn.Text = "Log in";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(84, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(84, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Login";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // AuthPassword
            // 
            this.AuthPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthPassword.Location = new System.Drawing.Point(199, 124);
            this.AuthPassword.Name = "AuthPassword";
            this.AuthPassword.Size = new System.Drawing.Size(151, 29);
            this.AuthPassword.TabIndex = 9;
            this.AuthPassword.UseSystemPasswordChar = true;
            // 
            // AuthLogin
            // 
            this.AuthLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthLogin.Location = new System.Drawing.Point(199, 58);
            this.AuthLogin.Name = "AuthLogin";
            this.AuthLogin.Size = new System.Drawing.Size(151, 29);
            this.AuthLogin.TabIndex = 8;
            // 
            // RegistrationAndAuthentificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Switch);
            this.Name = "RegistrationAndAuthentificationForm";
            this.Text = "Регистрация/Аутентификация";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationAndAuthentificationForm_FormClosing);
            this.Switch.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Switch;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AdmPatherName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AdmFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label admlog;
        private System.Windows.Forms.TextBox AdminPassw;
        private System.Windows.Forms.TextBox AdminLogin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AccountantPassw;
        private System.Windows.Forms.TextBox AccountantLogin;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AuthPassword;
        private System.Windows.Forms.TextBox AuthLogin;
        private System.Windows.Forms.Button SignUpAsAdm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AdmLastName;
        private System.Windows.Forms.Button SignUpAsAcc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AccLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AccPatherName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AccFirstName;
        private System.Windows.Forms.Button LogIn;
    }
}

