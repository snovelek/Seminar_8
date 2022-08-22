// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)


int [,,] FillMatrix (int r=2, int c=2,int d=2){
    int [,,]arr= new int [r,c,d];
   // int lastnum=-1;
    int randnum;
    arr[0,0,0]=new Random().Next(10,17);
    for (int i=0;i<r;i++){
        for (int j=0;j<c;j++){                
            for (int k=0;k<d;k++){
                randnum=new Random().Next(10,17);
                arr[i,j,k]=srav(arr,i,j,k,randnum);
            //     randnum=new Random().Next(10,18);
            //     if (randnum==lastnum){
            //         arr[i,j,k] = new Random().Next(10,100);
            //     }else{
            // arr[i,j,k]=randnum;
            // lastnum=randnum;
            //     }


            //Console.Write($" {arr[i,j]} ");
        }
        //Console.WriteLine();
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

int srav (int [,,]arr4,int a,int b,int c,int rand){
    int newnumber=10;
    for (int i = 0; i <= a; i++){
        for (int j = 0; j <= b; j++){
            for (int k = 0; k <= c; k++){
               if (arr4[i,j,k]==rand){
                rand = new Random().Next(10,17);               
               }
            }
        }
    }
    return rand;
}



//int[,,] mas = new int [2,2,2];
int [,,]mas = FillMatrix();
PrintArray(mas);

