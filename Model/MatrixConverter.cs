namespace InstrumentsGameTheory.Model
{
    internal class MatrixConverter
    {
        private static int[,] _matrix;

        public int[,] Matrix => _matrix;
        public int[] AIndexes
        {
            get
            {
                int[] result = { -1, -1};
                int counter = 0;
                for (int i = 0; i < _matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < _matrix.GetLength(1); j++)
                    {
                        if (_matrix[i, j] != 0 && result.Contains(i) == false)
                        {
                            result[counter++] = i;
                        }
                    }
                }

                return result;
            }
        }

        public int[] BIndexes
        {
            get
            {
                int[] result = { -1, -1 };
                int counter = 0;
                for (int i = 0; i < _matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < _matrix.GetLength(1); j++)
                    {
                        if (_matrix[i, j] != 0 && result.Contains(j) == false)
                        {
                            result[counter++] = j;
                        }
                    }
                }

                return result;
            }
        }
        
        public int[] Values
        {
            get
            {
                int[] result = new int[4];

                int counter = 0;
                for (int i = 0; i < _matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < _matrix.GetLength(1); j++)
                    {
                        if (_matrix[i, j] != 0)
                        {
                            result[counter++] = _matrix[i, j];
                        }
                    }
                }

                return result;
            }
        }

        public void Work(DataGridView dataGridView)
        {
            Set(dataGridView);
            CalculateSimple();
        }

        private void Set(DataGridView dataGridView)
        {
            _matrix = new int[dataGridView.Columns.Count, dataGridView.Rows.Count];
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    _matrix[i, j] = Convert.ToInt32(dataGridView[j, i].Value);
                }
            }
        }

        private void CalculateSimple()
        {
            int rows = _matrix.GetLength(0);
            int columns = _matrix.GetLength(1);

            while (rows > 2 && columns > 2)
            {
                if (rows > 2)
                {
                    DeleteRows(ref rows);
                }
                if (columns > 2)
                {
                    DeleteColumns(ref columns);
                }
            }
        }

        private static void DeleteRows(ref int rows)
        {
            bool isStopped = false;
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(0); j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (CheckRow(i, j))
                    {
                        SetZeroRow(i);
                        rows--;
                        isStopped = true;
                        break;
                    }
                }
                if (isStopped)
                {
                    break;
                }
            }
        }

        private static bool CheckRow(int firstRow, int secondRow)
        {

            if (IsZeroRow(firstRow) || IsZeroRow(secondRow))
            {
                return false;
            }

            for (int i = 0; i < _matrix.GetLength(1); i++)
            {
                if (_matrix[firstRow, i] > _matrix[secondRow, i])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsZeroRow(int firstRow)
        {
            for (int i = 0; i < _matrix.GetLength(1); i++)
            {
                if (_matrix[firstRow, i] != 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void SetZeroRow(int rowIndex)
        {
            for (int i = 0; i < _matrix.GetLength(1); i++)
            {
                _matrix[rowIndex, i] = 0;
            }
        }

        private static void DeleteColumns(ref int columns)
        {
            bool isStopped = false;
            for (int i = 0; i < _matrix.GetLength(1); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (CheckColumn(i, j))
                    {
                        SetZeroColumn(i);
                        columns--;
                        isStopped = true;
                        break;
                    }
                }
                if (isStopped)
                {
                    break;
                }
            }
        }

        private static bool CheckColumn(int firstColumn, int secondColumn)
        {
            if (IsZeroColumn(firstColumn) || IsZeroColumn(secondColumn))
            {
                return false;
            }

            for (int i = 0; i < _matrix.GetLength(1); i++)
            {
                if (_matrix[i, firstColumn] > _matrix[i, secondColumn])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsZeroColumn(int firstColumn)
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                if (_matrix[i, firstColumn] != 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void SetZeroColumn(int columnIndex)
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                _matrix[i, columnIndex] = 0;
            }
        }
    }
}
