using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibraryGiniyIdiot;
using System.Diagnostics;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class MainForm : Form
    {
        static Game game;
        public MainForm()
        {
            InitializeComponent();
        }
        public void MainForm_Load(object sender, EventArgs e)
        {
            GetUserName();
            game = new Game(GetNameFromUser.user);
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
            if (!int.TryParse(questionAnswerTextBox.Text, out int userAnswer))
            {
                MessageBox.Show("Введите ответ!");
                return;
            }
            game.CheckAnswer(userAnswer);
            if (game.IsEnd())
            {
                FinishGame();
                return;
            }
            PrintNextQuestion();
        }
        void PrintNextQuestion()
        {
            questionNum.Text = game.GetQuestionNumber();
            questionTextLabel.Text = game.GetQuestion().Print();
            questionAnswerTextBox.Text = "";
        }
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void показатьСтатистикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new StatisticsForm(game);
            newForm.ShowDialog();
        }
        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questionForm = new QuestionsForm(game);
            questionForm.ShowDialog();
        }
        private void удалитьПользовательскиеВопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete(Path.Combine(FileSystem.docPath, Game.questionFileName));
            MessageBox.Show("Приложение будет перезапущенно!");
            Application.Restart();
        }
        private void открытьФайлВопросовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new QuestionViewForm(game);
            newForm.ShowDialog();
        }
        private void очиститьСтатистикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete(Path.Combine(FileSystem.docPath, Game.statisticsFileName));
            MessageBox.Show("Приложение будет перезапущенно!");
            Application.Restart();
        }
        private void открытьФайлСтатистикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(FileSystem.docPath, Game.statisticsFileName));
        }
        private void FinishGame()
        {
            nextQuestionButton.Enabled = false;
            var result = game.RightAnswersResult() + " \n " + game.DiagnoseResult();
            MessageBox.Show(result);
            game.SaveResultInMyDocuments();
        }
    }
}
