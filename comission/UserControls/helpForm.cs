using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace comission.UserControls
{
    public partial class helpForm : UserControl
    {
        public helpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Отсутствует информация для отправки или почта для обратной связи", "Пустые значения");
            }
            else
            {
                MailMessage message1 = new MailMessage("sdek.mail.bonch@mail.ru", "voznesenskiy.shura@gmail.com", "Ошибки программы", "Описание ошибки от пользователя.\n" + richTextBox1.Text + "\nПочта для обратной связи - " + textBox1.Text);
                SmtpClient client = new SmtpClient("smtp.mail.ru");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("sdek.mail.bonch@mail.ru", "lZb43rQv27");
                client.EnableSsl = true;
                client.Send(message1);

                MailMessage message2 = new MailMessage("sdek.mail.bonch@mail.ru", textBox1.Text, "Ошибки программы", "Ваше сообщение принято на рассмотрение, благодарим за сотрудничество!\nВ скором времени с вами свяжутся, ожидайте.");
                SmtpClient client1 = new SmtpClient("smtp.mail.ru");
                client1.Port = 587;
                client1.Credentials = new System.Net.NetworkCredential("sdek.mail.bonch@mail.ru", "lZb43rQv27");
                client1.EnableSsl = true;
                client1.Send(message2);

                richTextBox1.Text = "";
                textBox1.Text = "";
                MessageBox.Show("Ваше сообщение отправлено", "Успешно");
            }
        }
    }
}
