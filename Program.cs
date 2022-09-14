// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*******************************
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// try
// {
//     Console.WriteLine("Please input m and n");
//     int m = Convert.ToInt32(Console.ReadLine());
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine();
//     int[,] Array = new int[m, n];
//     int[] ArrayOneLine = new int[m * n];

//     void PrintArray()
//     {
//         for (int i = 0; i < Array.GetLength(0); i++)
//         {
//             for (int j = 0; j < Array.GetLength(1); j++)
//             {
//                 Console.Write(Array[i, j]);
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }

//     void FillArray()
//     {
//         for (int i = 0; i < Array.GetLength(0); i++)
//         {
//             for (int j = 0; j < Array.GetLength(1); j++)
//             {
//                 Array[i, j] = new Random().Next(1, 10);
//             }
//         }

//     }

//     void FillOneLineArray()
//     {
//         int k = 0;
//         for (int i = 0; i < Array.GetLength(0); i++)
//         {
//             for (int j = 0; j < Array.GetLength(1); j++)
//             {
//                 ArrayOneLine[k] = Array[i, j];
//                 k += 1;
//             }
//         }
//     }

//     void BubbleSort(int[] Array)
//     {
//         for (int i = 0; i < ArrayOneLine.Length; i++)
//         {
//             for (int j = 0; j < ArrayOneLine.Length - 1; j++)
//             {
//                 if (ArrayOneLine[j] < ArrayOneLine[j + 1])
//                 {
//                     int temp = ArrayOneLine[j];
//                     ArrayOneLine[j] = ArrayOneLine[j + 1];
//                     ArrayOneLine[j + 1] = temp;
//                 }
//             }
//         }
//     }

//     void FillSortArray(int[,] Array)
//     {
//         int k = 0;
//         for (int i = 0; i < Array.GetLength(0); i++)
//         {
//             for (int j = 0; j < Array.GetLength(1); j++)
//             {
//                 Array[i, j] = ArrayOneLine[k];
//                 k++;
//             }
//         }
//     }

//     FillArray();
//     PrintArray();
//     FillOneLineArray();
//     BubbleSort(ArrayOneLine);
//     FillSortArray(Array);
//     PrintArray();
// }
// catch
// {
//     Console.WriteLine("Please input correctly");
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// try
// {
//     Console.WriteLine("Please input m and n");
//     int m = Convert.ToInt32(Console.ReadLine());
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine();
//     int[,] Array = new int[m, n];

//     void PrintArray()
//     {
//         for (int i = 0; i < Array.GetLength(0); i++)
//         {
//             for (int j = 0; j < Array.GetLength(1); j++)
//             {
//                 Console.Write($"{Array[i, j]} ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }

//     void FillArray()
//     {
//         for (int i = 0; i < Array.GetLength(0); i++)
//         {
//             for (int j = 0; j < Array.GetLength(1); j++)
//             {
//                 Array[i, j] = new Random().Next(1, 10);
//             }
//         }

//     }

//     int MinRow()
//     {
//         int SumRowMin = 999999999;
//         int SumRow = 0;
//         int MinRowI = 0;
//         for (int i = 0; i < Array.GetLength(0); i++)
//         {
//             for (int j = 0; j < Array.GetLength(1); j++)
//             {
//                 SumRow += Array[i, j];
//             }

//             if (SumRow < SumRowMin)
//             {
//                 SumRowMin = SumRow;
//                 MinRowI = i;
//             }
//             SumRow = 0;
//         }
//         Console.WriteLine($"MinRowIndex = {MinRowI}");
//         return MinRowI;
//     }

//     FillArray();
//     PrintArray();
//     MinRow();
// }
// catch
// {
//     Console.WriteLine("Please input correctly");
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] Array1 =
// {
//     {2,4},
//     {3,2}
// };

// int[,] Array2 =
// {
//     {3,4},
//     {3,3}
// };

// int[,] ArrayResault =
// {
//     {0,0},
//     {0,0}
// };

// void MatrixResault()
// {
//     int i = 0, j = 0;
//     ArrayResault[i, j] = (Array1[i, j] + Array1[i, j + 1]) * Array2[i, j];
//     ArrayResault[i, j + 1] = (Array1[i + 1, j] + Array1[i + 1, j + 1]) * Array2[i, j + 1];
//     ArrayResault[i + 1, j] = (Array1[i + 1, j] + Array1[i + 1, j + 1]) * Array2[i + 1, j];
//     ArrayResault[i + 1, j + 1] = (Array1[i + 1, j] * Array1[i + 1, j + 1]) * Array2[i + 1, j + 1];
// }

// void PrintMatrixResault()
// {
//     for (int i = 0; i < ArrayResault.GetLength(0); i++)
//     {
//         for (int j = 0; j < ArrayResault.GetLength(1); j++)
//         {
//             if (i == ArrayResault.GetLength(0) - 1 && j == ArrayResault.GetLength(1) - 1) Console.Write($"{ArrayResault[i, j]}.");
//             else Console.Write($"{ArrayResault[i, j]},  ");
//         }
//         Console.WriteLine();
//     }
// }

// MatrixResault();
// PrintMatrixResault();

// // //********************************************************************************************************************
//  Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// // построчно выводить массив, добавляя индексы каждого элемента.
// // // Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// // 34(1,0,0) 41(1,1,0)
// // 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)


// int[,,] Array = new int[2, 2, 2];
// int[] ArrayRandom = new int[8];

// void PrintArray()
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             for (int k = 0; k < Array.GetLength(2); k++)
//             {
//                 Console.Write($"{Array[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//     }
//     Console.WriteLine();
// }

// void FillArray()
// {
//     int l = 0;
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             for (int k = 0; k < Array.GetLength(2); k++)
//             {
//                 Array[i, j, k] = ArrayRandom[l];
//                 l++;
//             }
//         }
//     }
// }

// void CreateUniqueNubers()
// {
//     for (int i = 0; i < ArrayRandom.Length; i++)
//     {
//         int n = new Random().Next(10, 100);
//         if (ArrayRandom.Contains(n))
//         {
//             n = new Random().Next(10, 99);
//             i--;
//         }
//         else ArrayRandom[i] = n; 
//     }

//     Console.WriteLine();
// }

// CreateUniqueNubers();
// FillArray();
// PrintArray();

// *********************************************************************************************************************************************************************************
// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07
int m = 4, n = 4;
int LastNuber = m * n;
int[,] Array = new int[m, n];

void PrintArray()
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] < 10) Console.Write($"0{Array[i, j]} ");
            else Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SpiralArray()
{
    int x = 1;  // первое число в массиве
    int i = 0;  
    int j = 0;
    int L = -1; // Левая граница массива
    int U = 0;  // Верхняя граница массива

    while (x < LastNuber + 1)
    {
        for (j = j; j < n; j++)   // пошли вправо
        {
            Array[i, j] = x;
            x++;
        }
        j--;
        i++;
        for (i = i; i < m; i++) // пошли вниз
        {
            Array[i, j] = x;
            x++;
        }
        j--;
        i--;
        for (j = j; j > L; j--) // пошли влево и идем до L = (-1)
        {
            Array[i, j] = x;
            x++;
        } 
        j++;
        i--;
        for (i = i; i > U; i--) // пошли вверх до U = 0
        {
            Array[i, j] = x;
            x++;
        }
        L++; //  L, U, m, n - сужаем границы для следущего круга
        U++;
        i++;
        j++;
        m--; 
        n--; 
    }
}

SpiralArray();
PrintArray();

