//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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



void SortArray(int[,] inArray) 
{ 
    for (int i = 0; i < inArray.GetLength(0); i++) 
    { 
        for (int j = 0; j < inArray.GetLength(1); j++) 
        { 
             for (int n = 0; n < inArray.GetLength(1)-1; n++)
            {                
                if (inArray[i,n] < inArray[i,n+1]) 
                { 
                    int num = inArray[i,n+1]; 
                    inArray[i,n+1] = inArray[i,n]; 
                    inArray[i,n] = num; 
                } 
            }
            
        } 
    } 
}  

void PrintArray(int[,] inArray) 
{ 
    for (int i = 0; i < inArray.GetLength(0); i++) 
    { 
        for (int j = 0; j < inArray.GetLength(1); j++) 
        { 
            Console.Write($"{inArray[i, j]} "); 
        } 
        Console.WriteLine(); 
    } 
} 

int[,] array = new int[rows, columens];
GetArray(array);  
Console.WriteLine();
Console.WriteLine($"Заданный двумерный массив : ");
PrintArray(array); 
SortArray(array); 
Console.WriteLine();
Console.WriteLine($"Двумерный массив с упорядоченными по убыванию элементами каждой строки : ");
PrintArray(array);



