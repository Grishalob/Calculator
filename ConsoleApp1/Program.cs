﻿using System;
Execute();
void Execute() 
{
    Console.WriteLine("Доступные знаки \n(+) - Сложение \n(-) - Разность\n(*) - Умножение \n(/) - Деление \n(^) - Возведение в степень \n(s) - Корень \n0 - обнулить все значения \nПри выборе знака - введите 'b', чтобы вернуться назад ");
    while (true)
    {
        DataTyping.FirstNumber();
        Calculator StartValue = new Calculator(DataTyping.firstValue);
        while (true)
        {
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
        }
    }
}












