
public class Choice
{
    public static void SignChoice(char sign, double secondValue, double firstValue)
    {
        switch (sign)
        {
            case 'b':
                Calculator.Clean();
                break;
            case '+':
                Console.Clear();
                Console.WriteLine("Ответ: " + Calculator.Summary(secondValue));
                break;
            case '-':
                Console.Clear();
                Console.WriteLine("Ответ: " + Calculator.Subtraction(secondValue));
                break;
            case '*':
                Console.Clear();
                Console.WriteLine("Ответ: " + Calculator.Multiplication(secondValue));
                break;
            case '/':
                Console.Clear();
                Console.WriteLine("Ответ: " + Calculator.Division(secondValue));
                break;
            case '^':
                Console.Clear();
                Console.WriteLine("Ответ: " + Calculator.Power(secondValue));
                break;
            case 's':
                Console.Clear();
                Console.WriteLine("Ответ: " + Calculator.Sqrt(secondValue));
                break;
            default: break;
        }
    }
}

