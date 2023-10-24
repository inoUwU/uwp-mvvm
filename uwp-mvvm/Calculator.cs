namespace uwp_mvvm
{
    public class Calculator
    {
        private int value1 = 0;
        private int value2 = 0;

        public Calculator(int val1, int val2)
        {
            this.value1 = val1;
            this.value2 = val2;
        }

        public int Add()
        {
            return value1 + value2;
        }

        public int Sub()
        {
            return value1 - value2;
        }

        public int Mul()
        {
            return value1 * value2;
        }

        public int Div()
        {
            return value1 / value2;
        }
    }
}