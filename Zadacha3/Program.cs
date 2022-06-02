// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] matr = new int [5,4];
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          
            if(i % 2 == 0 && j % 2 ==0)  matr[i,j] = matr[i,j] * matr[i,j];
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
