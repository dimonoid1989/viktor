

namespace ClassLibraryGiniyIdiot
{
    public class Statistics
    {
        public string Name { get; set; }
        public int RightAnswers { get; set; }
        public string Diagnose { get; set; }

        public Statistics(string name, int rightAnswers, string diagnose)
        {
            Name = name;
            RightAnswers = rightAnswers;
            Diagnose = diagnose;
        }
        public Statistics()
        { }
    }
}
