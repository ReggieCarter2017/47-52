
void TwoDimensionalArray(int a, int b)
{
    int[,] array = new int[a, b];
    float arif = 0;
    for (int i = 0; i < a; i++)
    {
        for (int q = 0; q < b; q++) array[i, q] = new Random().Next(1, 101);
    }
    for (int i = 0; i < a; i++)
    {
        for (int q = 0; q < b; q++) Console.Write($"{array[i, q]} ");
    Console.WriteLine();     
    }
        for (int i = 0; i < b; i++)
    {
        arif = 0;
        for (int q = 0; q < a; q++)
        {
        arif += array[q, i];
        }
        Console.Write($"{arif / a} ");
    }        
 
}
int m = 5;
int n = 4;
TwoDimensionalArray(m, n);