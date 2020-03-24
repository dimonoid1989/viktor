using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PrototypeGeniyIdiotConsoleApp;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<Question> questions;
        
        Random random = new Random();
        int randomQuestionIndex;
        decimal questionNumberCounter = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            GetUserName();
            questions = Question.ListToQuestions();
            PrintNextQuestion();
        }
        private void GetUserName()
        {
            var newForm = new GetNameFromUser();
            newForm.ShowDialog();
            userName.Text = newForm.writeUserName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = GetNameFromUser.user;
            var userAnswer = int.Parse(questionAnswerTextBox.Text);
            var rightAnswer = questions[randomQuestionIndex].Answer;
            if (userAnswer == rightAnswer)
            {
                 user.RightAnswers++;
            }
            questions.Remove(questions[randomQuestionIndex]);
            PrintNextQuestion();
        }

        void PrintNextQuestion()
        {
            randomQuestionIndex = random.Next(questions.Count);
            questionNum.Text = "Вопрос №" + questionNumberCounter;
            questionTextLabel.Text = questions[randomQuestionIndex].Print();
            questionNumberCounter = questionNumberCounter + 1;
        }

        private void questionTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void questionAnswerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void questionNum_Click(object sender, EventArgs e)
        {

        }

        private void questionAnswerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
