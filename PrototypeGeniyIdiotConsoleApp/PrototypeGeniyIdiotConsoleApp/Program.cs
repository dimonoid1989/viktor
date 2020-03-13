using System;
using System.Collections.Generic;
using System.IO;


namespace PrototypeGeniyIdiotConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Начать новую игру? (введите: да/нет)");
            bool newGame = CheckAnswer(Console.ReadLine());

            do
            {


                if (newGame == true)
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
                    string diagnoseText = $"{user.Name}, Ваш диагноз: {user.Diagnose.Name}";

                    Console.WriteLine(countRightAnswerText);
                    Console.WriteLine(diagnoseText);

                    SaveResultInMyDocuments(user);
                }


                Console.WriteLine("Вывести статистику игр? (введите: да/нет)");
                GetStatistics(Console.ReadLine());
                Console.WriteLine("Хотите сыграть еще? (введите: да/нет)");
                if (CheckAnswer(Console.ReadLine()) == true)
                {
                    continue;

                }
                Console.WriteLine("Хотите добавить свой вопрос? (введите: да/нет)");
                newGame = AddQuestion(Console.ReadLine());


            } while (newGame == true);


        }

        static int TryGetUserAnswer()
        {
            bool answerType = false;
            int userAnswer = 0;
            while (answerType == false)
            {
                string answer = Console.ReadLine();
                if (!int.TryParse(answer, out userAnswer))
                {
                    Console.WriteLine("Введенный ответ не является числом");

                }
                else
                {
                    answerType = true;
                }
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
            var result = FileSystem.GetString("Class.txt");
            string[] delimeter = new string[1];
            delimeter[0] = "\r\n";
            var SplitedStrings = result.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < SplitedStrings.Length; i++)
            {
                var splitedWord = SplitedStrings[i].Split('$');
                int a = Convert.ToInt32(splitedWord[1]);
                Question question = new Question(splitedWord[0], a);
                questions.Add(question);
            }

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

        public static bool CheckAnswer(string answer)
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
            FileSystem.SaveString(user.Name + '$' + user.RightAnswers + '$' + user.Diagnose.Name, "WriteLines.txt");
        }

        public static void GetStatistics(string answer)
        {
            if (answer == "да" || answer == "Да" || answer == "ДА")

            {
                Console.WriteLine("{0,-20}{1,-40}{2,-15}", "Имя:", "Кол-во правильных ответов:", "Диагноз:");
                Console.WriteLine("____________________________________________________________________");
                var result = FileSystem.GetString("WriteLines.txt");
                string[] delimeter = new string[1];
                delimeter[0] = "\r\n";
                var SplitedStrings = result.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < SplitedStrings.Length; i++)
                {
                    var splitedWord = SplitedStrings[i].Split('$');

                    Console.WriteLine("{0,-30}{1,-30}{2,-12}", splitedWord[0], splitedWord[1], splitedWord[2]);
                    Console.WriteLine();
                }


            }
        }

        public static bool AddQuestion(string solution)
        {
            
            if (solution == "да" || solution == "Да" || solution == "ДА")
            {
                Console.WriteLine("Введите новый вопрос");
                string question = Console.ReadLine();
                Console.WriteLine("Введите ответ на вопрос");
                int answer = TryGetUserAnswer();
                FileSystem.SaveString(question + '$' + answer, "Class.txt");
                Console.WriteLine("Начать игру?");
                return CheckAnswer(Console.ReadLine());


            }
            else
            {
                bool newGame = false;
                return newGame;
            }
        }

    }

}
