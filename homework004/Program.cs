// Задача со звездочкой: Заполнить массив четной длины таким образом, чтобы значение элемента массива повторялось ровно 2 раза.
int Prompt(string msg)
{
    Console.Write(msg);
    bool count = int.TryParse(Console.ReadLine(), out int number);
    if (count)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}
int[] Array(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i += 2)
    {
        array[i] = new Random().Next(1, 100);
        int j = i + 1;
        array[j] = array[i];
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
void Check(int count)
{
    if (count % 2 == 0)
    {
        int[] array = Array(count);
        SetOutput(array);
    }
    else
    {
        System.Console.WriteLine("Вы ввели нечетное число");
    }
}
int count = Prompt("Введите размер массива (четное число) -> ");
Check(count);