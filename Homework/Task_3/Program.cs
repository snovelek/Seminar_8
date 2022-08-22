// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int [,] FillMatrix (int r, int c){
    int [,]arr= new int [r,c];
    for (int i=0;i<r;i++){
        for (int j=0;j<c;j++){
            arr[i,j] = new Random().Next(1,10);
            //Console.Write($" {arr[i,j]} ");
        }
        //Console.WriteLine();
    }
    Console.WriteLine();
    return arr;
}

void PrintArray(int [,] arr3){
    for (int i = 0; i < arr3.GetLength(0); i++){
                for (int j = 0; j < arr3.GetLength(1); j++){
                    Console.Write($" {arr3[i,j]} ");
                }
                Console.WriteLine();
    }
}

int [,] MultiplicationMatrix (int [,] arr1, int [,] arr2){
    int [,] arr3=new int [arr1.GetLength(0),arr1.GetLength(1)];
        for (int i=0;i<arr1.GetLength(0);i++){
            for (int j=0;j<arr1.GetLength(1);j++){
                arr3[i,j]=arr1[i,j]*arr2[i,j];
            }
        }
    return arr3;
}


System.Console.Write("Ведите m - ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите n - ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] Matrix1=FillMatrix(row,column);
int [,] Matrix2=FillMatrix(row,column);

PrintArray(Matrix1);
Console.WriteLine();
PrintArray(Matrix2);
Console.WriteLine();
PrintArray(MultiplicationMatrix(Matrix1,Matrix2));
