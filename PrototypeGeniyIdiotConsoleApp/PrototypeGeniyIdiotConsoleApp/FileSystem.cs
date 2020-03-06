using System;
using System.IO;


namespace PrototypeGeniyIdiotConsoleApp
{
    class FileSystem
    {
         public static string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static void SaveString(string value)
        {
            using (StreamWriter outputFile = File.AppendText(Path.Combine(docPath, "WriteLines.txt")))
            { outputFile.WriteLine(value); }
        }
        public static string GetString()
        {
            using (StreamReader outputFile = new StreamReader(Path.Combine(docPath, "WriteLines.txt")))
            { return outputFile.ReadToEnd(); }

        }
    }
}
