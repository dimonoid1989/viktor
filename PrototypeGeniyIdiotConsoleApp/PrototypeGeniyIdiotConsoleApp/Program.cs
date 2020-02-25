using System;
using System.IO;
using System.Collections.Generic;


namespace PrototypeGeniyIdiotConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool newGame;

            do
            {

                Console.WriteLine("Как Вас зовут?");
                string name = Console.ReadLine();
                int countRightAnswer = 0;
                List<string> questions = GetQuestions();
                List<int> answers = GetAnswers();
                int questionNumberCounter = 1;
                while (questions.Count > 0)
                {
                    Random random = new Random();
                    int questionIndex = random.Next(questions.Count);
                    Console.WriteLine("Вопрос №" + questionNumberCounter);
                    Console.WriteLine(questions[questionIndex]);
                    questions.Remove(questions[questionIndex]);
                    int userAnswer = TryGetUserAnswer();
                    int rightAnswer = answers[questionIndex];
                    answers.Remove(answers[questionIndex]);
                    if (userAnswer == rightAnswer)
                    {
                        countRightAnswer++;
                    }
                    questionNumberCounter++;
                }

                string resultDiagnose = CalculateDiagnose(countRightAnswer);
                string countRightAnswerText = $"Число правильных ответов: {countRightAnswer}";
                string diagnoseText = $"{name}, Ваш диагноз: {resultDiagnose}";

                Console.WriteLine(countRightAnswerText);
                Console.WriteLine(diagnoseText);

                SaveResultInMyDocuments(name, countRightAnswer, resultDiagnose);

                Console.WriteLine("Вывести статистику игр? (введите: да/нет)");
                GetStatistics(Console.ReadLine());
                Console.WriteLine("Хотите сыграть еще? (введите: да/нет)");
                newGame = Restart(Console.ReadLine());

            }
            while (newGame == true);

        }
        static void SaveResultInMyDocuments(string name, int countRightAnswer, string resultDiagnose)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = File.AppendText(Path.Combine(docPath, "WriteLines.txt")))
            {
                outputFile.WriteLine("{0, -10}\t  {1, 7}\t  {2 , 13}", name, countRightAnswer, resultDiagnose.ToString());

            }
        }
        static int TryGetUserAnswer()
        {
            string answer = Console.ReadLine();
            if (!int.TryParse(answer, out int userAnswer))
            {
                Console.WriteLine("Введенный ответ не является числом");
            }
            return userAnswer;
        }
        static List<string> GetQuestions()
        {
            var questions = new List<string>();
            questions.Add("Сколько будет два плюс два  умноженное на два?");
            questions.Add("Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?");
            questions.Add("На двух руках 10 пальцев. Сколько пальцев на 5 руках?");
            questions.Add("Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?");
            questions.Add("Пять свечей горело, две  потухли. Сколько свечей  осталось?");


            return questions;
        }
        static List<int> GetAnswers()
        {
            var answers = new List<int> { 6, 9, 25, 60, 2 };
            return answers;
        }
        static string GetDiagnoses(int result)
        {
            var diagnoses = new List<string> { "Идиот", "Кретин", "Дурак", "Нормальный", "Талант", "Гений" };
            return diagnoses[result];
        }
        static string CalculateDiagnose(int countRightAnswer)
        {

            double percentRightAnswers = countRightAnswer / (double)GetQuestions().Count * 100;
            int result = 0;
            if (percentRightAnswers >= 20 && percentRightAnswers < 40)
            { result = 1; }
            else if (percentRightAnswers >= 40 && percentRightAnswers < 60)
            { result = 2; }
            else if (percentRightAnswers >= 60 && percentRightAnswers < 80)
            { result = 3; }
            else if (percentRightAnswers >= 80 && percentRightAnswers < 100)
            { result = 4; }
            else if (percentRightAnswers == 100)
            { result = 5; }
            return GetDiagnoses(result);

        }
        static void GetStatistics(string answer)
        {
            if (answer == "да" || answer == "Да" || answer == "ДА")
            {

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                StreamReader outputFile = new StreamReader(Path.Combine(docPath, "WriteLines.txt"));

                Console.WriteLine("Имя:\t Кол-во правильных ответов:\t  Диагноз:");
                Console.WriteLine("________________________________________________");
                while (outputFile.Peek() >= 0)
                {
                    Console.WriteLine(outputFile.ReadLine());
                    Console.WriteLine();

                }
                outputFile.Close();

            }
        }
        static bool Restart(string answer)
        {
            bool newGame;
            if (answer == "да" || answer == "Да" || answer == "ДА")
            {
                newGame = true;
            }
            else
            {
                newGame = false;
            }
            return newGame;
        }



    }

}
