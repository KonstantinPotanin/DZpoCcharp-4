﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] GetArray (int length)
{
    int [] result = new int [length];
    for (int i = 0; i < length; i++)
    {
        result [i] = new Random().Next(0, 100);
    }
    return result;
}
int [] array = GetArray (8);
Console.WriteLine($"{String.Join(", ", array)}");