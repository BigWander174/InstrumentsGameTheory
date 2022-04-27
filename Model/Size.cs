using System.Collections;

namespace InstrumentsGameTheory.Model
{
    internal class Size
    {
        private DataGridView _dataGridView;

        public Size(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
        }

        internal void SetRows(int value)
        {
            _dataGridView.RowCount = value;
            UpdateHeaders(_dataGridView.Rows);
        }

        private void UpdateHeaders(DataGridViewRowCollection rows)
        {
            for (int i = 0; i < rows.Count; i++)
            {
                rows[i].HeaderCell.Value = "A" + $"{i + 1}";
            }
        }

        internal void SetRows(int[] aIndexes)
        {
            _dataGridView.RowCount = 2;

            for (int i = 0; i < aIndexes.Length; i++)
            {
                _dataGridView.Rows[i].HeaderCell.Value = "A" + $"{aIndexes[i] + 1}";
            }
        }

        internal void SetColumns(int[] bIndexes)
        {
            _dataGridView.ColumnCount = 2;

            for (int i = 0; i < bIndexes.Length; i++)
            {
                _dataGridView.Columns[i].HeaderCell.Value = "B" + $"{bIndexes[i] + 1}";
            }
        }

        internal void SetColumns(int value)
        {
            _dataGridView.ColumnCount = value;
            UpdateHeaders(_dataGridView.Columns);
        }

        private void UpdateHeaders(DataGridViewColumnCollection columns)
        {
            for (int i = 0; i < columns.Count; i++)
            {
                columns[i].HeaderText = $"B{i + 1}";
            }
        }
    }
}
