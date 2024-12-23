
public class DataTyping
{
    public static double firstValue;
    public static double secondValue;
    public static char sign;
    public static void FirstNumber()
    {
        Console.WriteLine("Введите число");
        firstValue = Convert.ToDouble(Console.ReadLine());
    }
    public static void Sign()
    {
        Console.WriteLine("Введите знак арифметической операции \n(+,-,*,/,^,s)");
        sign = Convert.ToChar(Console.ReadLine());
    }
    public static void SecondNumber()
    {
        Console.WriteLine("Введите число");
        secondValue = Convert.ToDouble(Console.ReadLine());
    }
}

