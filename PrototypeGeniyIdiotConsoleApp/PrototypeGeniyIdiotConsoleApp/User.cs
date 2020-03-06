using System;


namespace PrototypeGeniyIdiotConsoleApp
{
    class User
    {
        public string Name;
        public int RightAnswers;
        public Diagnose Diagnose;

        public User(string name)
        {
            Name = name;
            RightAnswers = 0;
            
        }
       
        public static int WriteHereRightAnswers()
        {
            int rightAnswers = 0;
            return rightAnswers;
        }

       
    }
}
