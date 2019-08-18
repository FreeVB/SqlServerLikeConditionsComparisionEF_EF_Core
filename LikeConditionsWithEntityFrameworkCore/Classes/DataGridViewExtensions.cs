using System.Windows.Forms;

namespace LikeConditionsWithEntityFrameworkCore.Classes
{
    public static class DataGridViewExtensions
    {
        public static void ExpandColumns(this DataGridView sender)
        {
            foreach (DataGridViewColumn column in sender.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
