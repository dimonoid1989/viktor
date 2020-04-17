using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryGiniyIdiot
{
    public class Statistics
    {
        public string Name;
        public string RightAnswers;
        public string Diagnose;

        public Statistics(string name, string rightAnswers, string diagnose)
        {
            Name = name;
            RightAnswers = rightAnswers;
            Diagnose = diagnose;
        }
    }
}
