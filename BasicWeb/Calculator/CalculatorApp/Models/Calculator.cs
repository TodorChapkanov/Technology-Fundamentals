namespace CalculatorApp.Models
{
    public class Calculator
    {
        public Calculator()
        {
            this.Result = 0;
        }
        public decimal LeftNumber { get; set; }

        public decimal RightNumber { get; set; }

        public string Operator { get; set; }

        public decimal Result { get; set; }

        public void CalculateResult()
        {
            switch (Operator)
            {
                case "+":
                    this.Result = this.LeftNumber + this.RightNumber;
                    break;
                case "-":
                    this.Result = this.LeftNumber - this.RightNumber;
                    break;
                case "*":
                    this.Result = this.LeftNumber * this.RightNumber;
                    break;
                case "/":
                    this.Result = this.LeftNumber / this.RightNumber;
                    break;
                
            }
        }
    }
}
