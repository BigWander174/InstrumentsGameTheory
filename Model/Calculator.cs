namespace InstrumentsGameTheory.Model
{
    internal class Calculator
    {
        private double _x1;
        private double _x2;
        private double _v;

        private int[] _values;
        private int[] _aIndexes;
        private int[] _bIndexes;

        private int[] _lengths;

        public string AInfo
        {
            get
            {
                double[] values = new double[_lengths[0]];

                values[_aIndexes[0]] = _x1;
                values[_aIndexes[1]] = _x2;

                return $"({string.Join(';', values)}), {_v}";
            }
        }

        public string BInfo
        {
            get
            {
                double[] values = new double[_lengths[1]];

                values[_bIndexes[0]] = _x1;
                values[_bIndexes[1]] = _x2;

                return $"({string.Join(';', values)}), {_v}";
            }
        }

        public void Work(int[,] matrix, int[] values, int[] aIndexes, int[] bIndexes)
        {
            Set(matrix, values, aIndexes, bIndexes);
            Calculate();
        }

        private void Set(int[,] matrix, int[] values, int[] aIndexes, int[] bIndexes)
        {
            _lengths = new int[2];

            _lengths[0] = matrix.GetLength(0);
            _lengths[1] = matrix.GetLength(1);

            _values = values;
            _aIndexes = aIndexes;
            _bIndexes = bIndexes;
        }

        private void Calculate()
        {
            _x1 = Math.Round((double)(-_values[1] + _values[3]) / (_values[0] - _values[1] + _values[3] - _values[2]), 5);

            _x2 = 1 - _x1;

            _v = _values[0] * _x1 + _values[1] * _x2;
        }
    }
}
