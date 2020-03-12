namespace PrototypeGeniyIdiotConsoleApp
{ 
    class Question 
    { 
        public string Text;
        public int Answer;

        public Question(string text, int answer)
        { 
            Text = text;
            Answer = answer;
        }

        public string Print()
        {
             return Text;
        }

    }
}
