﻿using System;
using System.Windows.Forms;
using ClassLibraryGiniyIdiot;
using System.Collections.Generic;
using System.IO;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class QuestionViewForm : Form
    {
        Game game;
        List <Question> questions;
        public QuestionViewForm(Game game)
        {
            InitializeComponent();
            this.game = game;
            ShowQuestions();
        }

        private void ShowQuestions()
        {
            questions = game.ReadQuestions();
            foreach (var question in questions)
            {
                questionView.Rows.Add(question.Text, question.Answer);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = questionView.CurrentRow.Index;
            questions.RemoveAt(rowIndex);
            questionView.Rows.Remove(questionView.Rows[rowIndex]);
            FileSystem.CleanFile(Game.questionFileName);
            foreach (var question in questions)
            {
                FileSystem.SaveString(question.Text + '$' + question.Answer, Game.questionFileName);
            }
        }

        private void QuestionViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Для обработки изменений приложение будет принудительно перезапущенно", "Внимание!");
            Application.Restart();
        }
    }
}
