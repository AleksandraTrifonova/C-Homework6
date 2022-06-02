// Показать двумерный массив размером m×n заполненный вещественными числами
void FillArray(double[,] matr)
{
    Random random = new Random();
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = random.NextDouble() * 10; 
        }  
    }
} 
void PrintArray(double[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();    
    }
} 

Console.WriteLine("Введите количество строк (m): ");
int m = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите количество столбцов (n): ");
int n = int.Parse(Console.ReadLine()??"0");

double[,] matrix = new double [m,n];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
