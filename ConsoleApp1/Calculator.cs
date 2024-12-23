
    class Calculator 
    {
    static double result;
    public Calculator(double firstValue)
    {
        result = firstValue;
    }
        public static double Summary(double secondValue, double firstValue)
        {
                result = result + secondValue;
                return result; 
        }
        public static double Subtraction(double secondValue, double firstValue)
        {
                result = result - secondValue;
                return result;
        }
        public static double Multiplication(double secondValue, double firstValue)
        {
                result = result * secondValue;
                return result;
        }
        public static double Division(double secondValue, double firstValue)
        {
                result = result / secondValue;
                return result;
        }
        public static double Power(double secondValue, double firstValue)
        { 
                result = Math.Pow(result,secondValue);
                return result;
        }
        public static double Sqrt(double secondValue, double firstValue)
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


