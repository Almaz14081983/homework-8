//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SumRows(int[,] matrix, int i)
{
    int sum = matrix[i,0];
    for(int j = 1; j < matrix.GetLength(1); j ++)
    {    
        sum = sum + matrix[i,j];                   
    }     
    return sum; 
}

void SumMin(int[,] matrix)
{
    int minsum = 0; 
    int sum = SumRows(matrix, 0);
    for(int i = 1; i < matrix.GetLength(0); i ++)
    {       
        int tempsum = SumRows(matrix,i);   
        if (sum > tempsum)              
        {   
        sum = tempsum;
        minsum = i;    
        }    
    }
    Console.WriteLine($"строка с наименьшей суммой элементов: {minsum+1}");
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
