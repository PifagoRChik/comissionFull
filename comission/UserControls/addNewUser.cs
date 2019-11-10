using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace comission.UserControls
{
    public partial class addNewUser : UserControl
    {
        public string filePath = string.Empty;
        public string filePathDocument = string.Empty;
        public static string connectstring = "provider=microsoft.jet.oledb.4.0;data source=comission.mdb;";
        public OleDbConnection myConnection;
        public addNewUser()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectstring);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
            photoBox.ImageLocation = filePath;
            photoBox.BorderStyle = BorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            string quy = $"SELECT Паспорт FROM Студенты WHERE Паспорт='{passportInput.Text}'";
            OleDbCommand commandForPassport = new OleDbCommand(quy, myConnection);
            commandForPassport.ExecuteNonQuery();

            OleDbDataReader reader = commandForPassport.ExecuteReader();
            string passportFromDatabase = string.Empty;
            while (reader.Read())
            {
                passportFromDatabase = reader[0].ToString();
            }
            reader.Close();

            string selectAtt = $"SELECT Аттестат FROM Студенты WHERE Аттестат='{attestInput.Text}'";
            OleDbCommand commandForAttest = new OleDbCommand(selectAtt, myConnection);
            commandForAttest.ExecuteNonQuery();

            OleDbDataReader reader1 = commandForAttest.ExecuteReader();
            string attestFromDatabase = "";
            while (reader1.Read())
            {
                attestFromDatabase = reader[0].ToString();
            }
            reader1.Close();

            try
            {
                
                if (passportInput.Text == "")
                {
                    MessageBox.Show("Введите паспорт", "Ошибка");
                }
                else if (attestInput.Text == "")
                {
                    MessageBox.Show("Введите аттестат", "Ошибка");
                }
                else if (passportFromDatabase == passportInput.Text)
                {
                    MessageBox.Show($"Абитуриент с номером паспорта {passportFromDatabase} уже существует", "Ошибка создания абитуриента");
                }
                else if (attestFromDatabase == attestInput.Text)
                {
                    MessageBox.Show($"Абитуриент с номером аттестата {attestFromDatabase} уже существует", "Ошибка создания абитуриента");
                }
                else
                {
                    string path = $@"images\{passportInput.Text}";
                    DirectoryInfo dirInfo = new DirectoryInfo(path);
                    if (!dirInfo.Exists)
                    {
                        dirInfo.Create();
                    }
                    File.Copy(filePath, Path.Combine(path, "photo.jpg"), true);
                    File.Copy(filePathDocument, Path.Combine(path, "att.jpg"), true);
                    quy = $"INSERT INTO Студенты (Фамилия, Имя, Отчество, Паспорт, Аттестат, Специальность, Фото, ФотоАттестата) VALUES " +
                        $"('{familyInput.Text}'," +
                        $"'{nameInput.Text}'," +
                        $"'{fatherNameInput.Text}'," +
                        $"'{passportInput.Text}'," +
                        $"'{attestInput.Text}'," +
                        $"'{specializationBox.SelectedItem.ToString()}'," +
                        $"'{Path.Combine(path, "photo.jpg")}'," +
                        $"'{Path.Combine(path, "att.jpg")}')";

                    OleDbCommand command = new OleDbCommand(quy, myConnection);
                    command.ExecuteNonQuery();

                    string insertPassport = $"INSERT INTO Данные (Паспорт) VALUES ('{passportInput.Text}')";
                    OleDbCommand command1 = new OleDbCommand(insertPassport, myConnection);
                    command1.ExecuteNonQuery();

                    string insertAttest = $"INSERT INTO Аттестаты (Номер) VALUES ('{attestInput.Text}')";
                    OleDbCommand command2 = new OleDbCommand(insertAttest, myConnection);
                    command2.ExecuteNonQuery();


                    MessageBox.Show("Успешно добавлено", "Success");
                    familyInput.Text = "";
                    nameInput.Text = "";
                    fatherNameInput.Text = "";
                    passportInput.Text = "";
                    attestInput.Text = "";
                    specializationBox.SelectedItem = null;
                    photoBox.Image = null;
                    documentBox.Image = null;
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Проверьте наличие и правильность введенных данных", "Ошибка");
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Проверьте наличие введенной информации о специальности","Ошибка");
            }
            finally
            {
                myConnection.Close();
                this.Invalidate();
            }
            
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

        private void passportInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void addDocument_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePathDocument = openFileDialog.FileName;
                }
            }
            documentBox.ImageLocation = filePathDocument;
            documentBox.BorderStyle = BorderStyle.None;
        }
    }
}
