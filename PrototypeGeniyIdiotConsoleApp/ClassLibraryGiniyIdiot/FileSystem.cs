using System;
using System.IO;


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
        public static bool IsExist(string fileName)
        {
           return File.Exists(Path.Combine(docPath, fileName));
        }
        public static void CreateFile(string fileName)
        {
            using (File.Create(Path.Combine(docPath, fileName)))
            { }
        }

    }
}
