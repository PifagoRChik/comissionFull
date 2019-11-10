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
    public partial class allStudents : UserControl
    {
        public static string connectstring = "provider=microsoft.jet.oledb.4.0;data source=comission.mdb;";
        public OleDbConnection myConnection;
        
        public allStudents()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectstring);
            zapol();
        }
        public void searchStudent()
        {
            myConnection.Open();
            dataGridView1.Rows.Clear();
            string quy = $"SELECT * FROM Студенты WHERE Фамилия = '{textBox1.Text}'";
            OleDbCommand command = new OleDbCommand(quy, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
            myConnection.Close();
        }
        public void zapol()
        {
            myConnection.Open();
            string quy = "SELECT * FROM Студенты ORDER BY Фамилия";
            OleDbCommand command = new OleDbCommand(quy, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[7]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
            myConnection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            studentCard.Visible = false;
            photoBox.ImageLocation = null;
            familyInput.Text = "";
            nameInput.Text = "";
            fatherNameInput.Text = "";
            passport.Text = "";
            attestLabel.Text = "";
            specializationSelect.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            string quy = $"UPDATE Студенты SET " +
                $"Фамилия = '{familyInput.Text}', " +
                $"Имя = '{nameInput.Text}', " +
                $"Отчество = '{fatherNameInput.Text}', " +
                $"Специальность = '{specializationSelect.SelectedItem.ToString()}'" +
                $"WHERE Паспорт = '{passport.Text}'";
            OleDbCommand command = new OleDbCommand(quy, myConnection);
            command.ExecuteNonQuery();
            myConnection.Close();
            photoBox.ImageLocation = null;
            familyInput.Text = "";
            nameInput.Text = "";
            fatherNameInput.Text = "";
            passport.Text = "";
            attestLabel.Text = "";
            specializationSelect.Text = "";
            dataGridView1.Rows.Clear();
            zapol();
            studentCard.Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            myConnection.Open();

            if(e.ColumnIndex == 3)
            {
                string valueFromCell = Convert.ToString(dataGridView1.CurrentCell.Value);
                string quy = $"SELECT * FROM Студенты WHERE Паспорт = '{valueFromCell}'";
                OleDbCommand selectStudent = new OleDbCommand(quy, myConnection);
                OleDbDataReader readerStudent = selectStudent.ExecuteReader();
                while (readerStudent.Read())
                {
                    photoBox.ImageLocation = readerStudent[6].ToString();
                    familyInput.Text = readerStudent[0].ToString();
                    nameInput.Text = readerStudent[1].ToString();
                    fatherNameInput.Text = readerStudent[2].ToString();
                    passport.Text = readerStudent[3].ToString();
                    attestLabel.Text = readerStudent[4].ToString();
                    specializationSelect.Text = readerStudent[5].ToString();
                }
                studentCard.Visible = true;
                readerStudent.Close();
            }
            else
            {
                MessageBox.Show("Выберите паспорт или аттестат", "Неверный выбор");
            }
            
            myConnection.Close();
            
        }

        private void familyInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void nameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void fatherNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                searchStudent();
            }
        }

        private void allStudents_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            zapol();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textBox1.Text = "";
            zapol();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            zapol();
        }

    }
}
