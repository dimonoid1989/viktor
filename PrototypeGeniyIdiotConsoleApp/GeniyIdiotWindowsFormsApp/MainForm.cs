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
            questionTimer.Start();
            
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
            questionTimer.Stop();
            PrintNextQuestion();
            questionTimerView.Value = 0;
            questionTimer.Start();
        }
        void PrintNextQuestion()
        {
            questionNumber.Text = game.GetQuestionNumber();
            questionTextLabel.Text = game.GetQuestion().Print();
            questionAnswerTextBox.Text = "";
            questionTimer.Start();
        }
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Application.Restart();
            game.ReadQuestions();
            game.questionNumber = 0;
            game.user.RightAnswers = 0;
            PrintNextQuestion();
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
            FileSystem.CleanFile(Game.statisticsFileName);
            MessageBox.Show("Информация о предыдущих играх удалена");
        }
        private void открытьФайлСтатистикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(FileSystem.docPath, Game.statisticsFileName));
        }
        private void FinishGame()
        {
            nextQuestionButton.Enabled = false;
            questionTimer.Stop();
            var result = game.RightAnswersResult() + " \n " + game.DiagnoseResult();
            MessageBox.Show(result);
            game.SaveResultInMyDocuments();
        }

        private void questionTimer_Tick(object sender, EventArgs e)
        {
            questionTimer.Stop();
            questionTimerView.Enabled = false;
            MessageBox.Show("К сожалению, время на ответ вышло");
            PrintNextQuestion();
            game.beginCountQuestions++;
            questionTimerView.Value = 0;
            questionTimer.Start();
        }
        public void ProgressTimer()
        {
            questionTimerView.Value = 0;
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            void timer_Tick(object sender, EventArgs e)
            {
               questionTimerView.PerformStep();
            }
        }
    }
}
