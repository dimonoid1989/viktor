﻿using System;
using System.IO;
using System.Collections.Generic;

namespace ClassLibraryGiniyIdiot
{
    public class Game
    {
        public const string questionFileName = "Questions.txt";
        public const string statisticsFileName = "Statistics.txt";
        int questionNumber = 0;
        List<Question> questions;
        Random random = new Random();
        User user;
        Question currentQuestion;
        int beginCountQuestions;

        public Game(User user)
        {
            this.user = user;
            Initialization();

        }
        public void Initialization()
        {
            var questions = Question.ListToQuestions();
            FileSystem.InitializeQuestionsAndStatistics();
            foreach (Question question in questions)
            {
                var questionSave = question.Text + '$' + question.Answer;
                FileSystem.SaveString(questionSave, questionFileName);
            }
            beginCountQuestions = questions.Count;
        }
        public List<Question> ReadQuestions()
        {
            questions = new List<Question> { };
            var result = FileSystem.GetString(questionFileName);
            var separator = new[] { "\r\n" };
            var splitedStrings = result.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splitedStrings.Length; i++)
            {
                var splitedWord = splitedStrings[i].Split('$');
                var text = splitedWord[0];
                var answer = Convert.ToInt32(splitedWord[1]);
                var question = new Question(text, answer);
                questions.Add(question);
            }
            return questions;
        }
        public Question GetQuestion()
        {
            var randomQuestionIndex = random.Next(questions.Count);
            currentQuestion = questions[randomQuestionIndex];
            questions.Remove(questions[randomQuestionIndex]);
            return currentQuestion;
        }
        public string GetQuestionNumber()
        {
            questionNumber++;
            return "Вопрос №" + questionNumber;
        }
        public void CheckAnswer(int userAnswer)
        {
            if (userAnswer == currentQuestion.Answer)
            {
                user.RightAnswers++;
            }
        }
        public bool IsEnd()
        {
            return questions.Count > 0;
        }
        public string RightAnswersResult()
        {
            return $"Число правильных ответов: {user.RightAnswers}";
        }
        public string DiagnoseResult()
        {
            var resultDiagnose = Diagnose.CalculateDiagnose(user, beginCountQuestions);
            user.Diagnose = resultDiagnose;
            return $"{user.Name}, Ваш диагноз: {user.Diagnose.Name}";
        }
        public void SaveResultInMyDocuments()
        {
            FileSystem.SaveString(user.Name + '$' + user.RightAnswers + '$' + user.Diagnose.Name, statisticsFileName);
        }
        public string[] ReadStatistics()
        {
            var result = FileSystem.GetString(statisticsFileName);
            string[] delimeter = new string[1];
            delimeter[0] = "\r\n";
            return result.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
        }
        public void SaveQuestion(Question question)
        { FileSystem.SaveString(question.Text + '$' + question.Answer, questionFileName); }
    }
}
