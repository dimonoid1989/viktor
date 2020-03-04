using System;
using System.IO;
using System.Collections.Generic;


namespace PrototypeGeniyIdiotConsoleApp
{
    class Diagnoses
    {
        public string Text;
        

        public Diagnoses(string text)
        {
            Text = text;
            
        }
        public static int CalculateDiagnose(int countRightAnswer)
        {

            double percentRightAnswers = countRightAnswer / (double)Program.GetQuestions().Count * 100;
            int result = Convert.ToInt32(percentRightAnswers / 20);
            return result;

        }
        public string Print()
        {
            return Text;
        }
    }
}
