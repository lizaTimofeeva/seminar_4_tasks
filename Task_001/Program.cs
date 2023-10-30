// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Print (string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Degree (int A, int B)
{
    int sum = 0;
    for (int i = 0; i<B; i++)
    {
        sum *= A;
    }
    return sum;
}

bool ValidateB (int B)
{
    if (B<0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false
    }
    return true
}

int A = Print("Введите первое число: ");
int B = Print("введите второе число: ");
if (ValidateB(B))
{
    System.Console.WriteLine($"Число {A} в степени {B} равно {Degree (int A, int B)}");
}