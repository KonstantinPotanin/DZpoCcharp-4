﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
//2, 4 -> 16

int GetNumber(string message)
{
    int result = 0;
    
    while (true)
    {
        Console.WriteLine(message);
    
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return result;
}

void  GetDegree (int a, int b)
{
   int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    Console.WriteLine(result);
}
int a = GetNumber("Введите число A");
int b = GetNumber("Введите число B");
GetDegree (a, b);
