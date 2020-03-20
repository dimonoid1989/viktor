using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PrototypeGeniyIdiotConsoleApp;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<Question> questions;
        User user;
        Random random = new Random();
        int randomQuestionIndex;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            user = new User("sdfsdf");
            questions = Question.ListToQuestions();
            PrintNextQuestion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            //Console.WriteLine("Вопрос №" + questionNumberCounter);
            questionTextLabel.Text = questions[randomQuestionIndex].Print();
        }
    }
}
