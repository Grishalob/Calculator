
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
                Console.WriteLine("Ответ: " + Calculator.Summary(secondValue, firstValue));
                break;
            case '-':
                Console.Clear();
                Console.WriteLine("Ответ: " + Calculator.Subtraction(secondValue, firstValue));
                break;
            case '*':
                Console.Clear();
                Console.WriteLine("Ответ: " + Calculator.Multiplication(secondValue, firstValue));
                break;
            case '/':
                Console.Clear();
                Console.WriteLine("Ответ: " + Calculator.Division(secondValue, firstValue));
                break;
            case '^':
                Console.Clear();
                Console.WriteLine("Ответ: " + Calculator.Power(secondValue, firstValue));
                break;
            case 's':
                Console.Clear();
                Console.WriteLine("Ответ: " + Calculator.Sqrt(secondValue, firstValue));
                break;
            default: break;
        }
    }
}

