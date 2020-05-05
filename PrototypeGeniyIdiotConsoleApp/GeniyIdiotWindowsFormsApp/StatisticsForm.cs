using System.Windows.Forms;
using ClassLibraryGiniyIdiot;
using System.ComponentModel;

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

        private void buttonSort_Click(object sender, System.EventArgs e)
        {

        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 1)
            {
                return;
            }
            if (dataGridView1.SortOrder == SortOrder.Ascending)
            { dataGridView1.Sort(Column2, ListSortDirection.Ascending); }
            else
            { dataGridView1.Sort(Column2, ListSortDirection.Descending); }

        }

        private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 1)
            {
                var value1 = double.Parse(e.CellValue1.ToString());
                var value2 = double.Parse(e.CellValue2.ToString());
                e.SortResult = value1.CompareTo(value2);
                e.Handled = true;
            }
        }
    }
}
