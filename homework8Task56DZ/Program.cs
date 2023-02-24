Console.Clear();

Console.Write("Введите колличество строк массива  ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите колличество столбцов массива  ");
int columens = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное значение в массиве ");
int min = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное значение в массиве ");
int max = int.Parse(Console.ReadLine()!);


void GetArray(int[,] someArray) 
{ 
    for (int i = 0; i < someArray.GetLength(0); i++)
    { 
        for (int j = 0; j < someArray.GetLength(1); j++) 
        { 
            someArray[i, j] = new Random().Next(min, max + 1); 
        } 
     } 
}

void SumMin(int[,] matrix)
{
    int row = 0; 
    int minsum = 0;
    for(int i = 0; i < matrix.GetLength(1); i++)
    {    
        minsum = minsum + matrix[0,i];                   
    }     

    for(int i = 1; i < matrix.GetLength(0); i ++)
    {       
        int sum = 0;  
        for(int j = 1; j < matrix.GetLength(1); j ++)
        {
            sum = sum + matrix[i,j];
        }
        if (minsum > sum)              
        {   
        minsum = sum;
        row = i;    
        }    
    }
    Console.WriteLine($"строка с наименьшей суммой элементов: {row+1}");
}

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[rows, columens];
GetArray(array);  
PrintArray(array);
Console.WriteLine();
SumMin(array);