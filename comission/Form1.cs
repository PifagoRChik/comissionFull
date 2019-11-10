using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace comission
{
    public partial class firstForm : Form
    {
        // Подключение БД
        public static string connectstring = "provider=microsoft.jet.oledb.4.0;data source=comission.mdb;";
        public OleDbConnection myConnection;

        public firstForm()
        {
            InitializeComponent();
        }
        public string GetHash(string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectstring);
            myConnection.Open();
            string login = studentLogin_input.Text;
            string password = GetHash(studentPassword_input.Text);

            string quy = $"SELECT Логин, Пароль FROM Пароли WHERE Логин = '{login}'";
            OleDbCommand command = new OleDbCommand(quy, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            string loginFromDatabase = "";
            string passwordFromDatabase = "";
            while (reader.Read())
            {
                loginFromDatabase = reader[0].ToString();
                passwordFromDatabase = reader[1].ToString();
            }
            reader.Close();

            if (login == "" || password == "")
            {
                MessageBox.Show("Вы не ввели логин или пароль");
                myConnection.Close();
            }
            else if (login == loginFromDatabase && password == passwordFromDatabase)
            {
                mainForm newf = new mainForm();
                newf.Show();
                this.Hide();
                myConnection.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                myConnection.Close();
            }
            myConnection.Close();
        }

        private void studentLogin_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                enterButton_Click(sender, e);
            }
        }

        private void studentPassword_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                enterButton_Click(sender, e);
            }
        }
    }
}
/*comment*/
