
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Linq;
using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;


using System.Data.OleDb;
using Microsoft.VisualBasic.CompilerServices;
using static System.Windows.Forms.AxHost;

namespace HBRS
{
    public partial class frmLogin
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        #region Default Instance

        private static frmLogin defaultInstance;

        public static frmLogin Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmLogin();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

        #endregion
        public void OK_Click(System.Object sender, System.EventArgs e)
        {

            if (UsernameTextBox.Text.Trim() == "" || PasswordTextBox.Text.Trim() == "")
            {
                Interaction.MsgBox("Заполните все поля!", Constants.vbInformation, "Внимание");
            }
            else
            {
                Module1.con.Open();
                var sql = "SELECT * FROM tblUser WHERE username = \'" + Module1.SafeSqlLiteral(UsernameTextBox.Text, 2) + "\' AND password = \'" + Module1.SafeSqlLiteral(PasswordTextBox.Text, 2) + "\'";

                var cmd = new OleDbCommand(sql, Module1.con);
                OleDbDataReader dr = cmd.ExecuteReader();

                try
                {
                    if (dr.Read() == false)
                    {
                        Interaction.MsgBox("Неверный логин!", Constants.vbCritical, "Внимание");
                    }
                    else
                    {
                        Interaction.MsgBox("Вход выполнен!", Constants.vbInformation, "Внимание");
                        frmMain.Default.status.Items[0].Text = "Вход выполнен под : " + UsernameTextBox.Text.Trim();
                        DateTime datenow = DateTime.Now;
                        frmMain.Default.status.Items[2].Text = "Дата и время : " + datenow.ToString("MMMM dd, yyyy") + " " + DateAndTime.TimeOfDay;
                        Module1.con.Close();
                        this.Hide();
                        frmMain.Default.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

                Module1.con.Close();
            }

        }

        public void Cancel_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
            ProjectData.EndApp();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем форму для регистрации нового пользователя
            var registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        public partial class RegistrationForm : Form
        {
            private TextBox txtUsername;
            private TextBox txtPassword;
            private Button btnRegister;
            private Label lblUsername;
            private Label lblPassword;

            public RegistrationForm()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                this.lblUsername = new Label();
                this.lblPassword = new Label();
                this.txtUsername = new TextBox();
                this.txtPassword = new TextBox();
                this.btnRegister = new Button();
                this.SuspendLayout();
                // 
                // lblUsername
                // 
                this.lblUsername.AutoSize = true;
                this.lblUsername.Location = new System.Drawing.Point(50, 30);
                this.lblUsername.Name = "lblUsername";
                this.lblUsername.Size = new System.Drawing.Size(55, 13);
                this.lblUsername.TabIndex = 3;
                this.lblUsername.Text = "Логин";
                // 
                // lblPassword
                // 
                this.lblPassword.AutoSize = true;
                this.lblPassword.Location = new System.Drawing.Point(50, 80);
                this.lblPassword.Name = "lblPassword";
                this.lblPassword.Size = new System.Drawing.Size(53, 13);
                this.lblPassword.TabIndex = 4;
                this.lblPassword.Text = "Пароль";
                // 
                // txtUsername
                // 
                this.txtUsername.Location = new System.Drawing.Point(50, 50);
                this.txtUsername.Name = "txtUsername";
                this.txtUsername.Size = new System.Drawing.Size(200, 20);
                this.txtUsername.TabIndex = 0;
                // 
                // txtPassword
                // 
                this.txtPassword.Location = new System.Drawing.Point(50, 100);
                this.txtPassword.Name = "txtPassword";
                this.txtPassword.Size = new System.Drawing.Size(200, 20);
                this.txtPassword.TabIndex = 1;
                this.txtPassword.UseSystemPasswordChar = true;
                // 
                // btnRegister
                // 
                this.btnRegister.Location = new System.Drawing.Point(100, 150);
                this.btnRegister.Name = "btnRegister";
                this.btnRegister.Size = new System.Drawing.Size(120, 50);
                this.btnRegister.TabIndex = 2;
                this.btnRegister.Text = "Зарегистрироваться";
                this.btnRegister.UseVisualStyleBackColor = true;
                this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
                // 
                // RegistrationForm
                // 
                this.ClientSize = new System.Drawing.Size(300, 250);
                this.Controls.Add(this.btnRegister);
                this.Controls.Add(this.txtPassword);
                this.Controls.Add(this.txtUsername);
                this.Controls.Add(this.lblPassword);
                this.Controls.Add(this.lblUsername);
                this.Name = "RegistrationForm";
                this.Text = "Форма регистрации";
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            private void btnRegister_Click(object sender, EventArgs e)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    // Подключаемся к базе данных
                    using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb;Persist Security Info=False;"))

                    {
                        con.Open();

                        // Проверяем, существует ли уже пользователь с таким логином
                        string sql = "SELECT COUNT(*) FROM tblUser WHERE username = @username";
                        using (OleDbCommand cmd = new OleDbCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            int count = (int)cmd.ExecuteScalar();

                            if (count != 0)
                            {

                                Module1.con.Open();
                                OleDbCommand insertCmd = new OleDbCommand("INSERT INTO tblUser (username, password) values (\'" +
                                txtUsername.Text + "\',\'" +
                                txtPassword.Text + "\')", Module1.con);
                                insertCmd.ExecuteNonQuery();

                            }
                            else
                            {
                                MessageBox.Show("Операция выполнена!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите логин и пароль!");
                }
            }
        }
    }

}
