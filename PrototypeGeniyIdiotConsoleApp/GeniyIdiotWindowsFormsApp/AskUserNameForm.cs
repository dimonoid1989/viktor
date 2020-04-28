using ClassLibraryGiniyIdiot;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class GetNameFromUser : Form
    {
        public static User user;
        public GetNameFromUser()
        {
            InitializeComponent();
            askUserName.Text = "Как Вас зовут?";
            writeUserName.Text = "";
        }
        public void enterName_Click(object sender, EventArgs e)
        {
            if (writeUserName.Text == "")
            { MessageBox.Show("Пожалуйста, введите имя пользователя!");
                return;
            }
            user = new User(writeUserName.Text);
            Close();
        }

        private void GetNameFromUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
