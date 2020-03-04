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
                List<Question> questions = GetQuestions();
                List<Diagnoses> diagnoses = DiscoverDiagnoses();
                int questionNumberCounter = 1;
                while (questions.Count > 0)
                {
                    Random random = new Random();
                    int randomQuestionIndex = random.Next(questions.Count);
                    Console.WriteLine("Вопрос №" + questionNumberCounter);
                    Console.WriteLine(questions[randomQuestionIndex].Print());
                    int userAnswer = TryGetUserAnswer();
                    int rightAnswer = questions[randomQuestionIndex].Answer;
                    if (userAnswer == rightAnswer)
                    {
                        countRightAnswer++;
                    }
                    questionNumberCounter++;
                    questions.Remove(questions[randomQuestionIndex]);
                }

                string resultDiagnose = diagnoses[Diagnoses.CalculateDiagnose(countRightAnswer)].Print();
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
        public static List<Question> GetQuestions()
        {
            var questions = new List<Question>
            {
                new Question("Сколько будет два плюс два  умноженное на два?", 6),
                new Question("Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?", 9),
                new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                new Question("Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?", 60),
                new Question("Пять свечей горело, две  потухли. Сколько свечей  осталось?", 2)
            };


            return questions; 
        }
        
        public static List<Diagnoses> DiscoverDiagnoses()
        {
            var diagnoses = new List<Diagnoses>
            {
                new Diagnoses("Идиот"),
                new Diagnoses("Кретин"),
                new Diagnoses("Дурак"),
                new Diagnoses("Нормальный"),
                new Diagnoses("Талант"),
                new Diagnoses("Гений")
            };


            return diagnoses; 
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
