// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int Print (string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
int[] RandomNum(int Length, int minValue, int maxValue)
{
    int [] array = new int [Length];
    Random rand = new Random();
    for (int i =0; i<Length; i++ )
    {
        array [i] = rand.Next (minValue,maxValue + 1);
    }
    return array;
}

void PrintArray(int [] array ) 
{
    System.Console.Write("[");
    for (int i = 0; i<array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("]");
}

int length = Print ("введите длину массива: ");
int min =Print ("Введите минимальное значение: ");
int max =Print ("Введите максимальное значение: ");
int[] array = RandomNum(length, min, max);
PrintArray(array);