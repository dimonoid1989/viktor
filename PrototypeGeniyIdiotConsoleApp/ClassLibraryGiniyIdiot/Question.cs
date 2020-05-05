using System.Collections.Generic;

namespace ClassLibraryGiniyIdiot
{
    public class Question
    {
        public string Text { get; set; }
        public int Answer { get; set; }
        public int Difficulty { get; set; }

        public Question(string text, int answer, int difficulty )
        {
            Text = text;
            Answer = answer;
            Difficulty = difficulty;
        }
        public Question()
        { }
        public string Print()
        {
            return Text;
        }
        public static List<Question> ListToQuestions()
        {
            var questions = new List<Question>
            {
                new Question("Сколько будет два плюс два  умноженное на два?", 6 , 1),
                new Question("Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?", 9, 1),
                new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25, 1),
                new Question("Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?", 60, 1),
                new Question("Пять свечей горело, две  потухли. Сколько свечей  осталось?", 2, 1)
            };
            return questions;
        }
    } 
}
