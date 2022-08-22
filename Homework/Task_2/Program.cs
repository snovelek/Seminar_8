// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int [,] FillMatrix (int r, int c){
    int [,]arr= new int [r,c];
    for (int i=0;i<r;i++){
        for (int j=0;j<c;j++){
            arr[i,j] = new Random().Next(1,20);
            Console.Write($" {arr[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return arr;
}

void PrintArray(int [,]arr3){
    for (int i = 0; i < arr3.GetLength(0); i++){
                for (int j = 0; j < arr3.GetLength(1); j++){
                    Console.Write($" {arr3[i,j]} ");
                }
                Console.WriteLine();
    }
}

void MinArrayRow (int [,]arr1){
    int [] arr2=new int[arr1.GetLength(0)];
    int RowCount=0;
    for (int i=0;i<arr1.GetLength(0);i++){
        for (int j=0;j<arr1.GetLength(1);j++){
            RowCount=RowCount+arr1[i,j];
        }
        arr2[i]=RowCount;
        Console.WriteLine($"Сумма по {i+1} строке - {RowCount}");
        RowCount=0;
    }
    int MinCount=arr2[0];
    int MinCountIndex=0;
    for (int i = 1; i < arr2.Length; i++){
        if (arr2[i]<MinCount){
            MinCount=arr2[i];
            MinCountIndex=i;
            }
    }
    System.Console.WriteLine($"Строка - {MinCountIndex+1}, содержит минимальную сумму элементов");
}

System.Console.Write("Ведите m - ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите n - ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] mas= FillMatrix(m,n);
MinArrayRow(mas);
