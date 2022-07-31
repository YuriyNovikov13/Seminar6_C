// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите количество чисел: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int[] FillArrey(int num, int min, int max)
{
    int[] array = new int[num];
    Random rand = new Random();
    for (int i = 0; i < num; i++)
    { array[i] = rand.Next(min, max + 1); }
    return array;
}
void Сounter(int[] arr)
{
    int count = 0;
    for (int i = 0; i <= arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count+=1;
        }
    }
    Console.WriteLine($" чисел больше 0 -> {count}");
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}
int[] array = FillArrey(num1, -10, 10);

PrintArray(array);
Console.WriteLine();
Сounter(array);
