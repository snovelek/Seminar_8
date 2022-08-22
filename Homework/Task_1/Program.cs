// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void SortRowsArray(int [,] arr1){
    for (int i = 0; i < arr1.GetLength(0); i++){
        BubbleSort(arr1,i);        
    }
}


int [,] BubbleSort(int [,]m,int ROW){
    for (int j=1;j<m.GetLength(1);j++){
        for(int i=0;i<m.GetLength(1)-j;i++){
            if (m[ROW,i]>m[ROW,i+1]){ 
            SwapVariable(m,i,ROW);        
            }        
        }
    }
    return m;
}
void SwapVariable (int [,] m,int i,int ROW1){
    int t=m[ROW1,i];
    m[ROW1,i]=m[ROW1,i+1];
    m[ROW1,i+1]=t;
}

System.Console.Write("Ведите m - ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите n - ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] mas= FillMatrix(m,n);
SortRowsArray(mas);
PrintArray(mas);