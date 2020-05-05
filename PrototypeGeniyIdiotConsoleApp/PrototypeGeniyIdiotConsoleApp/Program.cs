using System;
using ClassLibraryGiniyIdiot;

namespace PrototypeGeniyIdiotConsoleApp
{
    public class Program
    {
        static Game game;
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Начать новую игру? (введите: да/нет)");
                var yes = CheckAnswer(Console.ReadLine());
                if (yes)
                {
                    Console.WriteLine("Как Вас зовут?");
                    var user = new User(Console.ReadLine());
                    game = new Game(user);
                    while (!game.IsEnd())
                    {
                        Console.WriteLine(game.GetQuestionNumber());
                        Console.WriteLine(game.GetQuestion().Print());
                        var userAnswer = TryGetUserAnswer();
                        game.CheckAnswer(userAnswer);
                    }
                    Console.WriteLine(game.RightAnswersResult());
                    Console.WriteLine(game.DiagnoseResult());
                    game.SaveResultInMyDocuments();
                    if (PostGameFlow())
                    {
                        continue;
                    }
                    break;
                }
                else
                {
                    if (PostGameFlow())
                    {
                        continue;
                    }
                    break;
                }
            }
        }
        public static bool PostGameFlow()
        {
            Console.WriteLine("Вывести статистику игр? (введите: да/нет)");
            var yes = CheckAnswer(Console.ReadLine());
            if (yes)
            {
                GetStatistics();
                return true;
            }
            Console.WriteLine("Хотите добавить свой вопрос? (введите: да/нет)");
            yes = CheckAnswer(Console.ReadLine());
            if (yes)
            {
                game.SaveQuestion(AddQuestionFlow());
                return true;
            }
            return false;
        }
        static int TryGetUserAnswer()
        {
            int userAnswer;
            while (!int.TryParse(Console.ReadLine(), out userAnswer))
            {
                {
                    Console.WriteLine("Введенный ответ не является числом");
                }
            }
            return userAnswer;
        }
        public static bool CheckAnswer(string answer)
        {
            return answer == "да" || answer == "Да" || answer == "ДА";
        }
        public static void GetStatistics()
        {
            Console.WriteLine("{0,-20}{1,-40}{2,-15}", "Имя:", "Кол-во правильных ответов:", "Диагноз:");
            Console.WriteLine("____________________________________________________________________");
            var statisticObjectMassive = game.ReadStatistics();
            foreach (var statistics in statisticObjectMassive)
            {
                Console.WriteLine("{0,-30}{1,-30}{2,-12}", statistics.Name, statistics.RightAnswers, statistics.Diagnose);
                Console.WriteLine();
            }
        }
        public static Question AddQuestionFlow()
        {
            Console.WriteLine("Введите новый вопрос");
            var text = Console.ReadLine();
            Console.WriteLine("Введите ответ на вопрос");
            var answer = TryGetUserAnswer();
            Console.WriteLine("Введите сложность вопроса");
            var difficulty = TryGetUserAnswer();
            return new Question(text, answer, difficulty);
        }
    }
}
