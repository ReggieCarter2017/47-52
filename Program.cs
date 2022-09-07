
void TwoDimensionalArray(int a, int b, int pos)
{
    double[,] array = new double[a, b];
    for (int i = 0; i < a; i++)
        for (int q = 0; q < b; q++) array[i, q] = new Random().Next(-100, 101) + Math.Round(new Random().NextDouble(), 1);
    for (int i = 0; i < a; i++)
    {
        for (int q = 0; q < b; q++) Console.Write($"{array[i, q]} ");
    Console.WriteLine();     
    }
    Console.WriteLine();
    if (pos / 10 < a && pos % 10 < b && pos > -1) Console.Write(array[pos / 10, pos % 10]); // Решение 50-ой задачи
    else
    Console.Write("Такого индекса не существует в данном двумерном массиве.");
}
int m = 5;
int n = 5;
Console.WriteLine("Введите индекс элемента: ");
int.TryParse(Console.ReadLine(), out int a);
TwoDimensionalArray(m, n, a);
