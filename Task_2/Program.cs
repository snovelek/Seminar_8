// // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int [,] FillMatrix (int r, int c){
    int [,]arr= new int [r,c];
    for (int i=0;i<r;i++){
        for (int j=0;j<c;j++){
            arr[i,j] = new Random().Next(1,10);
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
int [,] mas2= ConvertRowToColumn(mas);

for (int i=0;i<mas2.GetLength(0);i++){
        for (int j=0;j<mas2.GetLength(1);j++){
            Console.Write($" {mas2[i,j]} ");
        }
        Console.WriteLine();
}


int [,] ConvertRowToColumn(int [,] arr1){
    //if ()
    int [,] arr2= new int [arr1.GetLength(1),arr1.GetLength(0)];
    for (int i = 0; i < arr1.GetLength(1); i++){
        for (int j = 0; j < arr1.GetLength(0); j++){
            //int t = arr1[j,i];
            arr2[i,j]=arr1[j,i];
            //Console.Write($" {arr2[i,j]} ");
            //arr2[i,j]=t;
        }
        //Console.WriteLine();
        
    }
    return arr2;
}

