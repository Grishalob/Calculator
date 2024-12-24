
public class DataTyping
{
    public static double firstValue;
    public static double secondValue;
    public static char sign;
    public static void FirstNumber()
    {
        while (true)
        {
            Console.WriteLine("Введите число");
            var IfRight = Double.TryParse(Console.ReadLine(), out firstValue);
            if (IfRight == false)
            {
                Console.Clear();
                Console.WriteLine("Введено неверное значение");
            }
            else break;
        }
    }
    public static void Sign()
    {
        while (true)
        {
            Console.WriteLine("Введите знак");
            var IfRight = Char.TryParse(Console.ReadLine(), out sign);
            if (IfRight == false)
            {
                Console.Clear();
                Console.WriteLine("Введен неверный знак \nДоступные знаки(+,-,*,/,^,s,b)");
            }
            else break;
        }
    }
    public static void SecondNumber()
    {
        while(true)
        {
            Console.WriteLine("Введите число");
            var IfRight = Double.TryParse(Console.ReadLine(), out secondValue);
            if (IfRight == false)
            {
                Console.Clear();
                Console.WriteLine("Введено неверное значение");
            }
            else break;
        }
    }
}

