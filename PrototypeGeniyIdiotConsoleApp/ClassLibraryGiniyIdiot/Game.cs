using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace ClassLibraryGiniyIdiot
{
    public class Game
    {
        public const string questionFileName = "Questions.json";
        public const string statisticsFileName = "Statistics.json";
        public int questionNumber = 0;
        List<Question> questions;
        Random random = new Random();
        public User user;
        Question currentQuestion;
        public int beginCountQuestions;
        public int countDifficultySum = 0;

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
                var questionSave = FileSystem.Serialize(questions);
                FileSystem.SaveString(questionSave, questionFileName);
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
            questions = JsonSerializer.Deserialize<List<Question>>(result);
            beginCountQuestions = questions.Count;
            return questions;
        }
        public Question GetQuestion()
        {
            var randomQuestionIndex = random.Next(questions.Count);
            currentQuestion = questions[randomQuestionIndex];
            countDifficultySum += currentQuestion.Difficulty; 
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
                user.RightAnswersDifficulty += currentQuestion.Difficulty;
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
            var resultDiagnose = Diagnose.CalculateDiagnose(user, beginCountQuestions, countDifficultySum);
            user.Diagnose = resultDiagnose;
            return $"{user.Name}, Ваш диагноз: {user.Diagnose.Name}";
        }
        public void SaveResultInMyDocuments()
        {
            var stat = new Statistics(user.Name, user.RightAnswers, user.Diagnose.Name);
            var statistics = new List<Statistics> { stat };
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
            var statisticsJson = JsonSerializer.Serialize(statistics, options);
            FileSystem.SaveString(statisticsJson, statisticsFileName);
        }
        public List<Statistics> ReadStatistics()
        {
            var result = FileSystem.GetString(statisticsFileName);
            var mass = JsonSerializer.Deserialize<List<Statistics>>(result);
            return mass;
        }
        public void SaveQuestion(Question question)
        {
            var result = FileSystem.GetString(questionFileName);
            var questions = JsonSerializer.Deserialize<List<Question>>(result);
            questions.Add(question);
            var questionSave = FileSystem.Serialize(questions);
            FileSystem.SaveString(questionSave, questionFileName, false);
        }
    }
}
