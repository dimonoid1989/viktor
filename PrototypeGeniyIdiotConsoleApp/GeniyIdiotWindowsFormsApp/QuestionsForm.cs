using ClassLibraryGiniyIdiot;
using System;
using System.Drawing;
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
            if (questionTextBox.Text == "" || answerTextBox.Text =="" || difficulty == 0)
            {
                MessageBox.Show("Заполните поля\"вопрос-ответ-сложность\"!");
                return;
            }
            text = questionTextBox.Text;
            answer = Convert.ToInt32(answerTextBox.Text);
            game.SaveQuestion(new Question(text,answer,difficulty));
            MessageBox.Show("Вопрос добавлен и сохранен!");
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            pictureBox1.Image = new Bitmap(Properties.Resources.quality_500950_960_720);
            pictureBox2.Image = null;
            pictureBox3.Image = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            difficulty = 3;
            pictureBox2.Image = new Bitmap(Properties.Resources.quality_500950_960_720);
            pictureBox1.Image = null;
            pictureBox3.Image = null;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            difficulty = 5;
            pictureBox3.Image = new Bitmap(Properties.Resources.quality_500950_960_720);
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }
    }
}
