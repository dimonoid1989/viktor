using ClassLibraryGiniyIdiot;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class QuestionsForm : Form
    {
        string question;
        string answer;
        public QuestionsForm()
        {
            InitializeComponent();
        }
        public void questionFormbutton_Click(object sender, EventArgs e)
        {
            if (questionTextBox.Text == "" || answeTextBox.Text =="")
            {
                MessageBox.Show("Заполните поля\"вопрос-ответ\"!");
                return;
            }
            question = questionTextBox.Text;
            answer = answeTextBox.Text;
            FileSystem.SaveString(question + '$' + answer, "Questions.txt");
            MessageBox.Show("Вопрос доавлен и сохранен!");
            Close();
        }
    }
}
