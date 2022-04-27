namespace InstrumentsGameTheory.Model
{
    internal class SimpleTable
    {
        private int[] _values;
        private int[] AIndexes;
        private int[] BIndexes;

        private DataGridView _target;

        public SimpleTable(int[] values, int[] aIndexes, int[] bIndexes, DataGridView target)
        {
            _values = values;
            AIndexes = aIndexes;
            BIndexes = bIndexes;
            _target = target;
        }

        public void Work()
        {
            Size size = new Size(_target);
            size.SetRows(AIndexes);
            size.SetColumns(BIndexes);
            FillValues();
        }

        private void FillValues()
        {
            int counter = 0;
            for (int i = 0; i < _target.Rows.Count; i++)
            {
                for (int j = 0; j < _target.Columns.Count; j++)
                {
                    _target[j, i].Value = _values[counter++].ToString();
                }
            }
        }
    }
}
