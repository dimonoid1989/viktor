using System;
using System.IO;


namespace PrototypeGeniyIdiotConsoleApp
{
    class FileSystem
    {
        public static void SaveResultInMyDocuments(string name, int countRightAnswer, string resultDiagnose)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = File.AppendText(Path.Combine(docPath, "WriteLines.txt")))
            {
                outputFile.WriteLine("{0, -10}\t  {1, 7}\t  {2 , 13}", name, countRightAnswer, resultDiagnose.ToString());

            }
        }

        public static void GetStatistics(string answer)
        {
            if (answer == "да" || answer == "Да" || answer == "ДА")
            {

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                StreamReader outputFile = new StreamReader(Path.Combine(docPath, "WriteLines.txt"));

                Console.WriteLine("Имя:\t Кол-во правильных ответов:\t  Диагноз:");
                Console.WriteLine("________________________________________________");
                while (outputFile.Peek() >= 0)
                {
                    Console.WriteLine(outputFile.ReadLine());
                    Console.WriteLine();

                }
                outputFile.Close();

            }
        }
    }
}
