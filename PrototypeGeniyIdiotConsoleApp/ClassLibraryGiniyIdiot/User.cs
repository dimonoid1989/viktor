namespace ClassLibraryGiniyIdiot
{
    public class User
    {
        public string Name;
        public int RightAnswers;
        public Diagnose Diagnose;

        public User(string name)
        {
            Name = name;
            RightAnswers = 0;
        }
    }
}
