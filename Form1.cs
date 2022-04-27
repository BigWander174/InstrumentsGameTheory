using model = InstrumentsGameTheory.Model;

namespace InstrumentsGameTheory
{
    public partial class Form1 : Form
    {
        private model.Size _size;
        private model.MatrixConverter _converter;
        private model.SimpleTable _simpleTable;
        private model.Calculator _calculator;
        public Form1()
        {
            InitializeComponent();
            _size = new model.Size(mainView);
            _converter = new model.MatrixConverter();
            _calculator = new model.Calculator();
        }

        private void ANumerics_ValueChanged(object sender, EventArgs e)
        {
            var value = (int) ((NumericUpDown)sender).Value;
            _size.SetRows(value);
        }

        private void BNumerics_ValueChanged(object sender, EventArgs e)
        {
            var value = (int)((NumericUpDown)sender).Value;
            _size.SetColumns(value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _converter.Work(mainView);
            _simpleTable = new model.SimpleTable(_converter.Values, _converter.AIndexes, _converter.BIndexes, simpleView);
            _simpleTable.Work();
            _calculator.Work(_converter.Matrix, _converter.Values, _converter.AIndexes, _converter.BIndexes);

            textBoxA.Text = _calculator.AInfo;
            textBoxB.Text = _calculator.BInfo;
        }
    }
}