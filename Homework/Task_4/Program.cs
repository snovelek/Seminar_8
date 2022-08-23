// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)


int [,,] FillMatrix (int [] mass ,int r=2, int c=2,int d=2){
    int [,,]arr= new int [r,c,d];
   // int lastnum=-1;
    int randnum;
    int o = 0;
    //arr[0,0,0]=new Random().Next(10,18); 
    for (int i=0;i<r;i++){
        for (int j=0;j<c;j++){                
             for (int k=0;k<d;k++){
                arr[i,j,k]=mass[o];
                o++;
            //{
            //     randnum=new Random().Next(10,12);
            //     System.Console.WriteLine($"randnum- {randnum} [{i},{j},{k}]");
            //         for (int q = 0; q < i; q++)
            //         {
            //             for (int w = 0; w < j; w++)
            //             {
            //                 for (int e = 0; e < k; e++)
            //                 {
            //                     if (randnum==arr[q,w,e]){
            //                         System.Console.WriteLine("dsa");
            //                         randnum=new Random().Next(10,18);
            //                         e=-1;
                                      

            //                     }
            //                     else{
                                    
            //                         if (q==i-1 || w==j-1 || e==k-1){
            //                         System.Console.WriteLine($"ddddd {q},{w},{e}");
            //                             arr[q,w,e]=randnum;
            //                     }
            // }
            //                 }
            //             }
            //         }
                         }
        }
    }

            Console.WriteLine();
    return arr;
}

void PrintArray(int [,,] arr3){
    for (int i = 0; i < arr3.GetLength(0); i++){
        for (int j = 0; j < arr3.GetLength(1); j++){
            for (int k = 0; k < arr3.GetLength(2); k++){
            Console.Write($" {arr3[i,j,k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
        
    }
}

int [] ArrayRand(){ // создаёт массив из 8 неповторяющихся элементов
    int [] mas = new int [8];
    int randnum;
    mas[0]=new Random().Next(10,18); // Такой промежуток выбрал для наглядности того, что точно будут созданы неповторяющиеся элементы)
    for (int i = 1; i < mas.GetLength(0); i++){
        randnum=new Random().Next(10,18);
            for (int j=0;j<i;j++){
                if (randnum==mas[j]){
                    randnum=new Random().Next(10,18);
                    j=-1;    
                }
                else{
                    if (j==i-1){
                    mas[i]=randnum;
                    }
                }
            }
        }
        return mas;
}


int []masRand=ArrayRand();

int [,,]mas = FillMatrix(masRand);
PrintArray(mas);

Console.WriteLine(String.Join(", ",masRand));

