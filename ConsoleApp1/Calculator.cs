
    class Calculator 
    {
    static double result;
    public Calculator(double firstValue)
    {
        result = firstValue;
    }
        public static double Summary(double secondValue)
        {
                result = result + secondValue;
                return result; 
        }
        public static double Subtraction(double secondValue)
        {
                result = result - secondValue;
                return result;
        }
        public static double Multiplication(double secondValue)
        {
                result = result * secondValue;
                return result;
        }
        public static double Division(double secondValue)
        {
                result = result / secondValue;
                return result;
        }
        public static double Power(double secondValue)
        { 
                result = Math.Pow(result,secondValue);
                return result;
        }
        public static double Sqrt(double secondValue)
        {
                result = Math.Pow(result, 1 / secondValue);
                return result;

        }
    public static double Clean()
        {
            Console.Clear();
            result = 0;
            return result;
        }
}


