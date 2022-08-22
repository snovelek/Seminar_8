// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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


System.Console.Write("Ведите m - ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите n - ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] mas= FillMatrix(m,n);
int [,]mas2 =FindMinIndexInArray(mas);
PrintArray(mas2);


void PrintArray(int [,]arr3){
    for (int i = 0; i < arr3.GetLength(0); i++){
                for (int j = 0; j < arr3.GetLength(1); j++){
                    Console.Write($" {arr3[i,j]} ");
                }
                Console.WriteLine();
    }
}


int [,] FindMinIndexInArray(int [,] arr1){
    int min=arr1[0,0];
    int posi=0;
    int posj=0;
    for (int i = 0; i < arr1.GetLength(0); i++){
            for (int j = 0; j < arr1.GetLength(1); j++){
                
                if (arr1[i,j]<min){
                    min=arr1[i,j];
                    posi=i; posj=j;
                }
            }
        }
    int [,] arr2=new int [arr1.GetLength(0)-1,arr1.GetLength(1)-1];
    Console.WriteLine($"Наименьший элемент массива - {min} [{posi},{posj}]",'\n');
    for (int i = 0; i < arr1.GetLength(0)-1; i++){
            for (int j = 0; j < arr1.GetLength(1)-1; j++){

                    if (i<posi && j<posj){
                        arr2[i,j]=arr1[i,j];    
                    }else if (i>=posi && j>=posj){
                        arr2[i,j]=arr1[i+1,j+1];
                    }else if (j>=posj && j<arr1.GetLength(1)){
                        arr2[i,j]=arr1[i,j+1];
                    }else if (i>=posi && i<arr1.GetLength(0)){
                        arr2[i,j]=arr1[i+1,j];

            }
        }
    }return arr2;
}

