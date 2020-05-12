using System;
using System.IO;
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
            ProgressTimer();
            StartCountTimers();
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
            StopCountTimers();
            PrintNextQuestion();
            questionTimerView.Value = 0;
            StartCountTimers();
        }
        void PrintNextQuestion()
        {
            questionNumber.Text = game.GetQuestionNumber();
            questionTextLabel.Text = game.GetQuestion().Print();
            questionAnswerTextBox.Text = "";
        }
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Application.Restart();
            StopCountTimers();
            game.ReadQuestions();
            game.questionNumber = 0;
            game.user.RightAnswers = 0;
            questionTimerView.Value = 0;
            PrintNextQuestion();
            StartCountTimers();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void показатьСтатистикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopCountTimers();
            var newForm = new StatisticsForm(game);
            newForm.ShowDialog();
            StartCountTimers();
        }
        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopCountTimers();
            var questionForm = new QuestionsForm(game);
            questionForm.ShowDialog();
            StartCountTimers();
        }
        private void удалитьПользовательскиеВопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete(Path.Combine(FileSystem.docPath, Game.questionFileName));
            MessageBox.Show("Приложение будет перезапущенно!");
            Application.Restart();
        }
        private void открытьФайлВопросовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopCountTimers();
            var newForm = new QuestionViewForm(game);
            newForm.ShowDialog();
            StartCountTimers();
        }
        private void очиститьСтатистикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopCountTimers();
            FileSystem.CleanFile(Game.statisticsFileName);
            MessageBox.Show("Информация о предыдущих играх удалена");
            StartCountTimers();
        }
        private void открытьФайлСтатистикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopCountTimers();
            Process.Start(Path.Combine(FileSystem.docPath, Game.statisticsFileName));
        }
        private void FinishGame()
        {
            StopCountTimers();
            var result = game.RightAnswersResult() + " \n " + game.DiagnoseResult();
            MessageBox.Show(result);
            game.SaveResultInMyDocuments();
        }
        public void ProgressTimer()
        {
            questionTimerView.Value = 0;
            timerProgressBar.Tick += timer_Tick;
            void timer_Tick(object sender, EventArgs e)
            {
               questionTimerView.PerformStep();
                if (questionTimerView.Value == 100)
                {
                    timerProgressBar.Stop();
                    MessageBox.Show("К сожалению, время на ответ вышло");
                    if (game.beginCountQuestions == game.questionNumber)
                    {
                        FinishGame();
                        return;
                    }
                    PrintNextQuestion();
                    game.beginCountQuestions++;
                    questionTimerView.Value = 0;
                    timerProgressBar.Start();
                }
            }
        }
        public void StopCountTimers()
        {
            timerProgressBar.Stop();
        }
        public void StartCountTimers()
        {
            timerProgressBar.Start();
        }
    }
}
