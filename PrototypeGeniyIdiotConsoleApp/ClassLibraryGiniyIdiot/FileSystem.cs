using System;
using System.IO;
using System.Collections.Generic;


namespace ClassLibraryGiniyIdiot
{
    public class FileSystem
    {
         public static string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        
        public static void SaveString(string value, string fileName)
        {
            using (StreamWriter outputFile = File.AppendText(Path.Combine(docPath, fileName)))
            { outputFile.WriteLine(value); }
        }
        public static string GetString(string fileName)
        {
            using (StreamReader outputFile = new StreamReader(Path.Combine(docPath, fileName)))
            { return outputFile.ReadToEnd(); }
        }
        public static bool InitializeQuestionsAndStatistics()
        {
            bool isNeedWriteQuestions = false;
            if (!File.Exists(Path.Combine(docPath, Game.statisticsFileName)))
            {
                using (File.Create(Path.Combine(docPath, Game.statisticsFileName)))
                { }
            }
            if (!File.Exists(Path.Combine(docPath, Game.questionFileName)))
            {
                using (File.Create(Path.Combine(docPath, Game.questionFileName)))
                { }
                isNeedWriteQuestions = true;
            }
            return isNeedWriteQuestions;
        }
    }
}
