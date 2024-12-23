using System;
Execute();
void Execute() 
{
    Console.WriteLine("0 - обнулить все значения \nПри выборе знака - введите 'b', чтобы вернуться назад ");
    while (true)
    {
        DataTyping.FirstNumber();
        Calculator StartValue = new Calculator(DataTyping.firstValue);
        while (true)
        {
            {
                try
                {
                    DataTyping.Sign();
                    DataTyping.SecondNumber();
                    if (DataTyping.secondValue == 0)
                    {
                        Calculator.Clean();
                        break;
                    }
                    else
                    {
                        Choice.SignChoice(DataTyping.sign, DataTyping.secondValue, DataTyping.firstValue);
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Введен недопустимый знак");
                }
            }
        }
    }
}












