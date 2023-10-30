// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Print (string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Sum (int number)
{
    int res =0;
    while (number >0)
    {
        res += number % 10;
        number = number / 10;
    }
    return res;
}

int number = Print ("Введите число: ");
System.Console.WriteLine(Sum(number));