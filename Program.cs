
void TwoDimensionalArray(int a, int b)
{
    double[,] array = new double[a, b];
    for (int i = 0; i < a; i++)
        for (int q = 0; q < b; q++) array[i, q] = new Random().Next(-100, 101) + Math.Round(new Random().NextDouble(), 1);
    for (int i = 0; i < a; i++)
    {
        for (int q = 0; q < b; q++) Console.Write($"{array[i, q]} ");
    Console.WriteLine();     
    }  
}
int m = 3;
int n = 4;
TwoDimensionalArray(m, n);
