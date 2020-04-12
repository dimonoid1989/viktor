using System;
using System.Windows.Forms;
using ClassLibraryGiniyIdiot;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            ShowStatistics();
        }

        private void ShowStatistics()
        {
            var result = FileSystem.GetString("Statistics.txt");
            string[] delimeter = new string[1];
            delimeter[0] = "\r\n";
            var SplitedStrings = result.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < SplitedStrings.Length; i++)
            {
                var splitedWord = SplitedStrings[i].Split('$');
                dataGridView1.Rows.Add(splitedWord[0], splitedWord[1], splitedWord[2]);
            }
        }
    }
}
