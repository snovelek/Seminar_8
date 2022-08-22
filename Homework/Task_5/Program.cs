// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


int [] mas = new int [8];
int randnum;
mas[0]=new Random().Next(10,18);
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
int sum=0;
for (int i =0;i<mas.Length;i++){
    Console.Write($"  {mas[i]}");
    sum+=mas[i];}
    Console.Write($" сумма элементов  -{sum} ");


    System.Console.WriteLine($"FIRTS ---{mas[0]}");




// while (f==false){
//     for (int j=0;j<i;j++){
//         //if (randnum==mas[j]){

//         }
//     }
    

