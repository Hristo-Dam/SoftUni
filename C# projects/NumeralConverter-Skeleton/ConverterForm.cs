using System.Text;

namespace NumeralConverter
{
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            this.InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonDecimalToBinary_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonDecimalToHex_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonBinaryToDecimal_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonBinaryToHex_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonHexToDecimal_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonHexToBinary_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private string ConvertFromBaseTen(int number, int toBase)
        {
            throw new NotImplementedException();
        }

        private int ConvertToBaseTen(string number, int fromBase)
        {
            throw new NotImplementedException();
        }

        private string ConvertBinaryToHex(string binaryText)
        {
            throw new NotImplementedException();
        }

        private string ConvertHexToBinary(string hexText)
        {
            throw new NotImplementedException();
        }

        private void ShowErrorBox()
        {
            MessageBox.Show(
                "Text box cannot be empty",
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
