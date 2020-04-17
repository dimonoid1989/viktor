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
            var statisticObjectMassive = game.ReadStatistics();
            foreach (var statistics in statisticObjectMassive)
            {
                dataGridView1.Rows.Add(statistics.Name, statistics.RightAnswers, statistics.Diagnose);
            }
        }
    }
}
