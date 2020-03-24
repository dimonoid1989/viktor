using PrototypeGeniyIdiotConsoleApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void writeUserName_TextChanged(object sender, EventArgs e)
        {

        }

        public void enterName_Click(object sender, EventArgs e)
        {
            var sendToOtherForm = writeUserName.Text;
            user = new User(sendToOtherForm);
            var fm = new MainForm();
            fm.userName.Text = user.Name; 
            Close();
        }
        
    }
}
