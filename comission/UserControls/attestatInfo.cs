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
    public partial class attestatInfo : UserControl
    {
        public static string connectstring = "provider=microsoft.jet.oledb.4.0;data source=comission.mdb;";
        public OleDbConnection myConnection;
        public attestatInfo()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectstring);
        }

        private void button1_Click(object sender, EventArgs e)//ввод атт
        {
            myConnection.Open();
            if (attestInput.Text == "")
            {
                MessageBox.Show("Проверьте правильность и наличие введенных данных", "Ошибка");
            }
            else
            {
                string selectPassport = $"SELECT Номер FROM Аттестаты WHERE Номер='{attestInput.Text}'";
                OleDbCommand commandForPassport = new OleDbCommand(selectPassport, myConnection);
                commandForPassport.ExecuteNonQuery();

                OleDbDataReader reader = commandForPassport.ExecuteReader();
                string attesstFromDatabase = string.Empty;
                while (reader.Read())
                {
                    attesstFromDatabase = reader[0].ToString();
                }
                reader.Close();
                if (attestInput.Text == attesstFromDatabase)
                {
                    panel1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Такого аттестата не существует, проверьте данные", "Ошибка");
                }
            }
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)//save
        {
            myConnection.Open();
            try
            {
                string insertData = $"UPDATE Аттестаты SET " +
                    $"Математика = '{mathInput.Text}'," +
                    $"Физика = '{physicsInput.Text}'," +
                    $"Труд = '{technologyInput.Text}'," +
                    $"Музыка = '{musicInput.Text}'," +
                    $"РусскийЯзык = '{russianInput.Text}'," +
                    $"Физкультура = '{peInput.Text}'," +
                    $"Иностранный = '{foreignInput.Text}'," +
                    $"География = '{geografyInput.Text}'," +
                    $"Биология = '{biologyInput.Text}'," +
                    $"Химия = '{chemistryInput.Text}'," +
                    $"Информатика = '{csInput.Text}'," +
                    $"Обществознание = '{socialInput.Text}' WHERE Номер = '{attestInput.Text}'";
                OleDbCommand commandForPassport = new OleDbCommand(insertData, myConnection);
                commandForPassport.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлены", "Успешно");
                mathInput.Text = "";
                physicsInput.Text = "";
                technologyInput.Text = "";
                musicInput.Text = "";
                russianInput.Text = "";
                peInput.Text = "";
                foreignInput.Text = "";
                geografyInput.Text = "";
                biologyInput.Text = "";
                chemistryInput.Text = "";
                csInput.Text = "";
                socialInput.Text = "";
                attestInput.Text = "";
                panel1.Visible = true;
            }
            catch (System.Data.OleDb.OleDbException q) when (q.Message == "Отсутствует значение для одного или нескольких требуемых параметров.")
            {
                MessageBox.Show("Проверьте наличие введенных данных", "Ошибка");
            }
            myConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)//отмена
        {
            mathInput.Text = "";
            physicsInput.Text = "";
            technologyInput.Text = "";
            musicInput.Text = "";
            russianInput.Text = "";
            peInput.Text = "";
            foreignInput.Text = "";
            geografyInput.Text = "";
            biologyInput.Text = "";
            chemistryInput.Text = "";
            csInput.Text = "";
            socialInput.Text = "";
            attestInput.Text = "";
            panel1.Visible = true;
        }

        private void attestInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
