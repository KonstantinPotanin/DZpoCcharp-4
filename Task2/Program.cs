// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

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

int GetSumDigit (int num)
{
    int sumDigitNum = 0;
    while (num > 0)
    {
        sumDigitNum = sumDigitNum + num % 10;
        num = num / 10;
    }
    return sumDigitNum;
}
int num = GetNumber("Введите целое число");
int sumDigitNumber = GetSumDigit(num);
Console.WriteLine($"Сумма цифр в цисле {num} - {sumDigitNumber}");
