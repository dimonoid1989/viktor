using System;
using System.Collections.Generic;



namespace ClassLibraryGiniyIdiot
{
    public class Diagnose
    {
        public string Name;

        public Diagnose(string text)
        {
            Name = text;
        }

        public static Diagnose CalculateDiagnose(User user, int countQuestions, int countDifficulty)
        {
            var percentRightAnswers = user.RightAnswers * 100.0 / countQuestions;
            var percentDifficultyRightAnswers = user.RightAnswersDifficulty * 100.0 / countDifficulty;
            var percentResult = (percentRightAnswers + percentDifficultyRightAnswers) / 2.0;
            var result = Convert.ToInt32(percentResult / 20);
            return GetDiagnoses()[result];
        }

        public static List<Diagnose> GetDiagnoses()
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
    }
}
