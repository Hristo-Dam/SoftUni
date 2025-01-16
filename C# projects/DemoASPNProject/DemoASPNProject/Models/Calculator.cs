using System.ComponentModel.DataAnnotations;

namespace DemoASPNProject.Models
{
    public class Calculator
    {
        public Calculator()
        {
            this.Result = 0;
        }

        public decimal LeftOperand { get; set; }
        public decimal RightOperand { get; set; }
        public string Operatr { get; set; } = null;
        public decimal Result { get; set; }
    }
}
