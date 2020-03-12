using System;
using System.Collections.Generic;



namespace PrototypeGeniyIdiotConsoleApp
{
    class Diagnose
    {
        public string Name;
        

        public Diagnose(string text)
        {
            Name = text;
            
        }
        public static Diagnose  CalculateDiagnose(User user)
        {

            double percentRightAnswers = user.RightAnswers / (double)Program.GetQuestions().Count * 100;
            int result = Convert.ToInt32(percentRightAnswers / 20);
            return Program.DiscoverDiagnoses()[result];
            

        }
        
    }
}
