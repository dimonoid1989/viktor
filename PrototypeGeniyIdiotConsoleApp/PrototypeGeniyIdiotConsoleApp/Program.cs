using System;
using System.Collections.Generic;
using System.IO;


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
                User user = new User(name);
                List<Question> questions = GetQuestions();
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
                        user.RightAnswers++;
                    }
                    questionNumberCounter++;
                    questions.Remove(questions[randomQuestionIndex]);
                }

                var resultDiagnose = Diagnose.CalculateDiagnose(user);
                user.Diagnose = resultDiagnose;


                string countRightAnswerText = $"Число правильных ответов: {user.RightAnswers}";
                string diagnoseText = $"{user.Name}, Ваш диагноз: {user.Diagnose}";

                Console.WriteLine(countRightAnswerText);
                Console.WriteLine(diagnoseText);

                SaveResultInMyDocuments(user);

                Console.WriteLine("Вывести статистику игр? (введите: да/нет)");
                GetStatistics(Console.ReadLine());
                Console.WriteLine("Хотите сыграть еще? (введите: да/нет)");
                newGame = Restart(Console.ReadLine());


            }
            while (newGame == true);

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

        public static List<Diagnose> DiscoverDiagnoses()
        {
            var diagnoses = new List<Diagnose>
            {
                new Diagnose("Идиот"),
                new Diagnose("Кретин"),
                new Diagnose("Дурак"),
                new Diagnose("Нормальный"),
                new Diagnose("Талант"),
                new Diagnose("Гений")
            };


            return diagnoses;
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
        public static void SaveResultInMyDocuments(User user)
        {
            FileSystem.SaveString(user.Name + '$' + user.RightAnswers + '$' + user.Diagnose.Name);
        }

        public static void GetStatistics(string answer)
        {
            if (answer == "да" || answer == "Да" || answer == "ДА")

            {
                Console.WriteLine("{0,-20}{1,-40}{2,-15}", "Имя:", "Кол-во правильных ответов:", "Диагноз:");
                Console.WriteLine("___________________________________________________");
                var result = FileSystem.GetString();
                string[] c = new string[1];
                c[0] = "\r\n";
                var a = result.Split(c, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < a.Length; i++)
                {
                    var g = a[i].Split('$');

                    Console.WriteLine("{0,-30}{1,-40}{2,-15}", g[0], g[1], g[2]);
                }


            }
        }


    }

}
