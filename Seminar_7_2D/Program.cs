
int [,] CreateRandom2Array(int rows, int columns)
{
    int [,] newArray =new int[rows, columns];

    for (int i = 0; i<rows; i++) // цикл 1
        for (int j=0; j<columns; j++ ) // цикл 2
        newArray[i,j] = new Random().Next(0,10);

        return newArray;
}

void Show2Array (int [,] array)
{
    for (int i =0; i<array.GetLength(0); i++) // 0??
    {
        for (int j=0; j<array.GetLength(1); j++) //??
        Console.Write(array[i,j] + " ");

        Console.WriteLine(); // ставиться только во внутри 2 цикла
    }    
}

//!Задача 
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

    // int [,] ChangeString (int [,] array)
    // {
    //      for (int j=0; j<array.GetLength(0)-1 ; j++) 
            
    //          {
    //              int temp = array[0,j];
    //              array[0,j] = array [0,j-1];
    //              array [0,j-1] =temp;
    //          }
    //          return array;
    // }

int[,] ChangeString (int[,] array)
{
    for(int j = 0; j < array.GetLength(0); j++)
    {
            int temp = array [0,j];
    array[0,j] = array[array.GetLength(0) - 1,j];
    array[array.GetLength(0) - 1,j] = temp;    
    }
    return array;
}
    // 1 2 3
    // 5 6 7    
    // 8 9 0 j

    int m = 5;
    int n = 5;

    int [,] myArray = CreateRandom2Array (m,n);
    Show2Array (myArray);
    Console.WriteLine();
    Show2Array (ChangeString(myArray));



    

//!Задача 
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

    // int [,] Revers2DArray (int [,] array)
    // {
    //     if (array.GetLength(0)!=array.GetLength(1))
    //     {
    //         Console.WriteLine("Не работает, ушла на обед! "); 
    //         return array; // возвращаем массив если не сработало условие
    //     }
        
    //     for (int i =0; i<array.GetLength(0) -1 ; i++) // -1 не проверяем последнюю цифру в массиве
    
    //         for (int j=i+1; j<array.GetLength(1); j++) // j=i+1 замена индексов  
    //         {
    //             int temp = array[i,j];
    //             array[i,j] = array [j,i];
    //             array[i,j] =temp;
    //         }
    // }
/*
    Console.WriteLine(" input rows");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" input columns");
    int n = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine(" input min");
    // int min = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine(" input max");
    // int max = Convert.ToInt32(Console.ReadLine());

    int [,] myArray = CreateRandom2Array (m,n,min,max);
    Show2Array (myArray);
    Show2Array (Revers2DArray(myArray)); //????????
/*/


//!Задача 
//Из двумерного массива целых чисел удалить строку и столбец(присваивать 0), на пересечении которых расположен наименьший элемент.
/*
    int [,] Cut2DArray (int [,] array)
    {
        int iMin =0, jMin=0;

        for (int i =0; i<array.GetLength(0) ; i++) 
    
            for (int j=1; j<array.GetLength(1); j++) 
            {
                if (array[i,j] < array [iMin,jMin]);
                    iMin=i;
                    jMin=j;
            }
        for (int j=0; j<array.GetLength(1);j++)
        array [iMin,j] =0;          // за 0 ли строки
        for (int i=0; i<array.GetLength(0);i++)
        array [i,jMin] =0;             // за 0ли столбцы

        return array;
    }



    
    int m = 5;
    int n = 5; Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine(" input min");
    // int min = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine(" input max");
    // int max = Convert.ToInt32(Console.ReadLine());

    int [,] myArray = CreateRandom2Array (m,n);
    Show2Array (myArray);
    Show2Array (Cut2DArray(myArray)); 
    /*/