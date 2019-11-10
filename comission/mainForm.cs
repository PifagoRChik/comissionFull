using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace comission
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible == false)
                bunifuTransition1.ShowSync(menuPanel);
            else if (menuPanel.Visible == true)
                bunifuTransition1.HideSync(menuPanel);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addNewUser1.Visible = true;
            attestatInfo1.Visible = false;
            studentInfo1.Visible = false;
            allStudents1.Visible = false;
            helpForm1.Visible = false;
            sidePanel.Height = addButton.Height;
            sidePanel.Top = addButton.Top;
            bunifuTransition1.HideSync(menuPanel);
        }

        private void allStudents_Click(object sender, EventArgs e)
        {
            addNewUser1.Visible = false;
            studentInfo1.Visible = false;
            attestatInfo1.Visible = false;
            allStudents1.Visible = true;
            helpForm1.Visible = false;
            sidePanel.Height = allStudents.Height;
            sidePanel.Top = allStudents.Top;
            bunifuTransition1.HideSync(menuPanel);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"readme\index.html");
            studentInfo1.Visible = false;
            addNewUser1.Visible = false;
            allStudents1.Visible = false;
            attestatInfo1.Visible = false;
            helpForm1.Visible = true;
            sidePanel.Height = helpButton.Height;
            sidePanel.Top = helpButton.Top;
            bunifuTransition1.HideSync(menuPanel);
        }

        private void dataButton_Click(object sender, EventArgs e)
        {
            attestatInfo1.Visible = false;
            addNewUser1.Visible = false;
            allStudents1.Visible = false;
            helpForm1.Visible = false;
            studentInfo1.Visible = true;
            sidePanel.Height = dataButton.Height;
            sidePanel.Top = dataButton.Top;
            bunifuTransition1.HideSync(menuPanel);
        }

        private void attbutton_Click(object sender, EventArgs e)
        {
            addNewUser1.Visible = false;
            allStudents1.Visible = false;
            helpForm1.Visible = false;
            studentInfo1.Visible = false;
            attestatInfo1.Visible = true;
            sidePanel.Height = attbutton.Height;
            sidePanel.Top = attbutton.Top;
            bunifuTransition1.HideSync(menuPanel);
        }
    }
}
