using System.Windows.Forms;
using ClassLibraryGiniyIdiot;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class StatisticsForm : Form
    {
        Game game; 
        public StatisticsForm(Game game)
        {
            InitializeComponent();
            this.game = game;
            ShowStatistics();
        }

        private void ShowStatistics()
        {
            var SplitedStrings = game.ReadStatistics();
            for (int i = 0; i < SplitedStrings.Length; i++)
            {
                var splitedWord = SplitedStrings[i].Split('$');
                dataGridView1.Rows.Add(splitedWord[0], splitedWord[1], splitedWord[2]);
            }
        }
    }
}
