using ClassLibraryGiniyIdiot;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class QuestionsForm : Form
    {
        string text;
        int answer;
        int difficulty;
        Game game;
        public QuestionsForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }
        public void questionFormbutton_Click(object sender, EventArgs e)
        {
            if (questionTextBox.Text == "" || answerTextBox.Text =="" || difficultyComboBox.Text =="")
            {
                MessageBox.Show("Заполните поля\"вопрос-ответ\"!");
                return;
            }
            text = questionTextBox.Text;
            answer = Convert.ToInt32(answerTextBox.Text);
            difficulty = Convert.ToInt32(difficultyComboBox.SelectedItem);
            game.SaveQuestion(new Question(text,answer,difficulty));
            MessageBox.Show("Вопрос добавлен и сохранен!");
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
