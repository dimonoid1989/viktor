using System;
using System.IO;
using System.Collections.Generic;

namespace ClassLibraryGiniyIdiot
{
    public class Game
    {
        public const string questionFileName = "Questions.txt";
        public const string statisticsFileName = "Statistics.txt";
        public int questionNumber = 0;
        List<Question> questions;
        Random random = new Random();
        public User user;
        Question currentQuestion;
        int beginCountQuestions;

        public Game(User user)
        {
            this.user = user;
            Initialization();
            ReadQuestions();
        }
        public void Initialization()
        {
            var questions = Question.ListToQuestions();
            if (!FileSystem.IsExist(questionFileName))
            {
                FileSystem.CreateFile(questionFileName);
                foreach (Question question in questions)
                {
                    var questionSave = question.Text + '$' + question.Answer;
                    FileSystem.SaveString(questionSave, questionFileName);
                }
            }
            if (!FileSystem.IsExist(statisticsFileName))
            {
                FileSystem.CreateFile(statisticsFileName);
            }
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
            beginCountQuestions = questions.Count;
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
            return questions.Count == 0;
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
        public Statistics[] ReadStatistics()
        {
            var result = FileSystem.GetString(statisticsFileName);
            string[] delimeter = new string[1];
            delimeter[0] = "\r\n";
            var splitedStrings = result.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
            var mass = new Statistics[splitedStrings.Length];
            for (int i = 0; i < splitedStrings.Length; i++)
            {
                var splitedWord = splitedStrings[i].Split('$');
                var statistics = new Statistics(splitedWord[0], splitedWord[1], splitedWord[2]);
                mass[i] = statistics;
            }
            return mass;
        }
        public void SaveQuestion(Question question)
        { FileSystem.SaveString(question.Text + '$' + question.Answer, questionFileName); }
    }
}
