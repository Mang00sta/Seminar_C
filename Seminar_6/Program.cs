//!Задача 
//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int [,] CreateRandom2Array(int rows, int columns, int min, int max)
{
    int [,] newArray =new int[rows, columns];

    for (int i = 0; i<rows; i++) // цикл 1
        for (int j=0; j<columns; j++ ) // цикл 2
        newArray[i,j] = new Random().Next(min,max +1);

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

int FindDigSumm (int [,] array)
{
    int sum = 0;

     if (array.GetLength(0)== array.GetLength(1)) // проверяем если массив квадратный
    {
         for (int i =0; i<array.GetLength(0); i++) // 0??
            sum+= array[i,i];
    }
    return sum;



    // if (array.GetLength(0)== array.GetLength(1))
    // {
    //      for (int i =0; i<array.GetLength(0); i++) // 0??
    //     {
    //         for (int j=0; j<array.GetLength(1); j++) //??

    //         if (i==j) sum+= array [i,j];

    //     }
    // }
    // return sum;

}

/*
Console.WriteLine(" input");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" input");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" input");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" input");
    int max = Convert.ToInt32(Console.ReadLine());

    int [,] myArray = CreateRandom2Array (m,n,min,max);
    Show2Array (myArray);
/*/

//!Задача
//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] CreateRandom2DArray1(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
            newArray[i,j] = i + j;

    return newArray;     

}
/*/


//!Задача
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] FindEvenChange(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
        for(int j=0; j < array.GetLength(1); j++)
            if(i % 2 == 0 && j % 2 == 0)
                array[i,j] = array[i,j] * array[i,j];

    return array;
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray123 = CreateRandom2DArray(m,n,min,max);
Show2Array(myArray123);
Console.WriteLine();
myArray123 = FindEvenChange(myArray123);
Show2Array(myArray123);
/*/
//!Задача
//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//*
Console.WriteLine(" input");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" input");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" input");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" input");
    int max = Convert.ToInt32(Console.ReadLine());

    int [,] myArray = CreateRandom2Array (m,n,min,max);
    Show2Array (myArray);
    Console.WriteLine(" Sum " + FindDigSumm(myArray));
//*/