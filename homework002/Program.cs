// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int Prompt(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
int[] Array(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
void SetOutput(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}
int Summ(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        count = count + array[i];
    }
    return count;
}

int size = Prompt("Введите размер массива -> ");
int[] array = Array(size);
SetOutput(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {Summ(array)}");