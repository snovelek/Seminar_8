// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раза
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

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
FindAmountElementArray(mas);

void FindAmountElementArray (int [,] arr1){
    //for (int k=0;k<arr1.GetLength(0)*arr1.GetLength(1);k++){
    for (int k=0;k<10;k++){
        int number =k;
        int count=0;
        for (int i = 0; i < arr1.GetLength(0); i++){
            for (int j = 0; j < arr1.GetLength(1); j++){
                //int number=arr1[i,j];
                if (arr1[i,j]==number){
                    count++;
                }

            }
        }
        if (count!=0)
        Console.WriteLine($"{k} встречается {count} раза");
    }
}