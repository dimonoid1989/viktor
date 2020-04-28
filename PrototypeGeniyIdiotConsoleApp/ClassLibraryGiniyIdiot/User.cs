namespace ClassLibraryGiniyIdiot
{
    public class User
    {
        public string Name;
        public int RightAnswers;
        public Diagnose Diagnose;

        public User(string name = "Unnamed user")
        {
            Name = name;
            RightAnswers = 0;
        }
    }
}
