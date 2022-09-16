// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int Prompt(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
double[] Array(int len)
{
    double[] array = new double[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 30;
    }
    return array;
}
void SetOutput(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}
double DifferenceMaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) 
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    return max-min;
}
int size = Prompt("Введите размер массива -> ");
double[] array = Array(size);
SetOutput(array);
System.Console.WriteLine();
System.Console.WriteLine($"Разность максимального и минимального элементов = {DifferenceMaxAndMin(array)}");
