using System;
using System.Windows.Forms;
using ClassLibraryGiniyIdiot;
using System.Collections.Generic;
using System.IO;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class QuestionViewForm : Form
    {
        Game game;
        List <Question> questionsObjectMassive;
        public QuestionViewForm(Game game)
        {
            InitializeComponent();
            this.game = game;
            ShowQuestions();
        }

        private void ShowQuestions()
        {
            questionsObjectMassive = game.ReadQuestions();
            foreach (var question in questionsObjectMassive)
            {
                questionView.Rows.Add(question.Text, question.Answer);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = questionView.CurrentRow.Index;
            questionsObjectMassive.RemoveAt(rowIndex);
            questionView.Rows.Remove(questionView.Rows[rowIndex]);
            StreamWriter writer = new StreamWriter(Path.Combine(FileSystem.docPath, Game.questionFileName), false);
            foreach (var question in questionsObjectMassive)
            {
                writer.WriteLine(question.Text + '$' + question.Answer);
            }
            writer.Close();
        }
    }
}
