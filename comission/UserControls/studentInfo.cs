using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace comission.UserControls
{
    public partial class studentInfo : UserControl
    {
        public static string connectstring = "provider=microsoft.jet.oledb.4.0;data source=comission.mdb;";
        public OleDbConnection myConnection;
        public studentInfo()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectstring);
        }

        private void button2_Click(object sender, EventArgs e)//сохранение
        {

            myConnection.Open();
            try
            {
                string updateInfo = $"UPDATE Данные SET " +
                    $"Город = '{cityInput.Text}'," +
                    $"Улица = '{streetInput.Text}'," +
                    $"Дом = '{homeInput.Text}'," +
                    $"Квартира = '{kvartInput.Text}'," +
                    $"Мать = '{motherInput.Text}'," +
                    $"Отец = '{fatherInput.Text}'," +
                    $"Телефон = '{numberInput.Text}'," +
                    $"ТелефонРодители = '{numberParentInput.Text}' WHERE Паспорт = '{passportInput.Text}'";
                OleDbCommand commandForPassport = new OleDbCommand(updateInfo, myConnection);
                commandForPassport.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлены", "Успешно");
                cityInput.Text = "";
                streetInput.Text = "";
                homeInput.Text = "";
                kvartInput.Text = "";
                motherInput.Text = "";
                fatherInput.Text = "";
                numberInput.Text = "";
                numberParentInput.Text = "";
                passportInput.Text = "";
                panel1.Visible = true;
            }
            catch (System.Data.OleDb.OleDbException q) when (q.Message == "Отсутствует значение для одного или нескольких требуемых параметров.")
            {
                MessageBox.Show("Проверьте наличие введенных данных", "Ошибка");
            }
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)//паспорт
        {
            myConnection.Open();
            if (passportInput.Text == "")
            {
                MessageBox.Show("Проверьте правильность и наличие введенных данных", "Ошибка");
            }
            else
            {
                string selectPassport = $"SELECT Паспорт FROM Данные WHERE Паспорт='{passportInput.Text}'";
                OleDbCommand commandForPassport = new OleDbCommand(selectPassport, myConnection);
                commandForPassport.ExecuteNonQuery();

                OleDbDataReader reader = commandForPassport.ExecuteReader();
                string passportFromDatabase = string.Empty;
                while (reader.Read())
                {
                    passportFromDatabase = reader[0].ToString();
                }
                reader.Close();
                if (passportInput.Text == passportFromDatabase)
                {
                    panel1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Такого паспорта не существует, проверьте данные", "Ошибка");
                }
            }
            myConnection.Close();
        }

        private void cityInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void streetInput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void motherInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void fatherInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void numberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void passportInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cityInput.Text = "";
            streetInput.Text = "";
            homeInput.Text = "";
            kvartInput.Text = "";
            motherInput.Text = "";
            fatherInput.Text = "";
            numberInput.Text = "";
            numberParentInput.Text = "";
            passportInput.Text = "";
            panel1.Visible = true;
        }

        private void kvartInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
