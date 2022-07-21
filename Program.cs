//Семинар 1
// 1я задача

int number;

Console.Write("Input a number: ");
number = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Your number is" + number);


// 2я задача

int num1, num2, quad;

Console.Write("Input a number: ");
num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a second: ");
num2 = Convert.ToInt32(Console.ReadLine()); 

quad=num2*num2;

    if(quad == num1) 
{
        Console.Write("First num is quad og second ");
}
    else
{
        Console.Write("Second num is quad og second ");
}


//Задача 3 Напишите программу, которая будет выдавать название дня недели по заданному номеру

int day;

Console.Write("Input a day number: ");

day = Convert.ToInt32(Console.ReadLine()); 

    if(day == 1)
{
    Console.WriteLine ("Mon");
    
}

    if(day == 2)

{
    Console.WriteLine ("Thu");
    
}

    if(day == 3)

{
    Console.WriteLine ("Wen");
    
}
    if(day == 4)

{
    Console.WriteLine ("Thu");
    
}
    if(day == 5)

{
    Console.WriteLine ("Fri");
    
}
    if(day == 6)

{
    Console.WriteLine ("Sat");
    
}
    if(day == 7)

{
    Console.WriteLine ("Sun");
    
}
    else
{
        Console.Write("Wrong number");
}

// Задача 4 Напишите программу, которая на вход принимает число и выдаёт его квадрат.

int num1, quad;

Console.Write("Input a number: ");
num1 = Convert.ToInt32(Console.ReadLine()); 

quad=num1*num1;

Console.Write("Your quad number " + quad);

// Задача 5 Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

int n, current;

Console.Write("input a num ");
n = Convert.ToInt32(Console.ReadLine());

current=n* (-1);

while(current <= n)
{
    Console.Write(current + " ");
    current++; //current = current + 1
}

//!Семинар 2
//Задача 1 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int CutNumber()
{
    int num = new Random().Next (100,1000);
    Console.WriteLine("Current random is" + num);

    int sotni = num/100; // ищем 1ю цифру
    int ed = num % 10;  // остаток от деления ищем 3ю

    int result = sotni * 10 + ed; // соединяем 1. и 3ю в одно число
    return result;
}
int number=CutNumber();
Console.WriteLine("Result " + number);

// Выполнили через void задачу №1

void CutNumberVoid()
{
    int num = new Random().Next (100,1000);
    Console.WriteLine("Current random is" + num);

    int sotni = num/100; // ищем 1ю цифру
    int ed = num % 10;  // остаток от деления ищем 3ю

    int result = sotni * 10 + ed; // соединяем 1. и 3ю в одно число
    Console.WriteLine("Result" + result);
}
CutNumberVoid();



// Задача 2  Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.


int MaxNumber()
{
     int num = new Random().Next (10,100);
     Console.WriteLine("Current random is" + num);

    int des = num/10;
    int ed = num % 10;
     
    if (des>ed)
    {
        return des;
    }
    else 
    {
        return ed;
    }
}    
int number=MaxNumber();
Console.WriteLine("Result " + number);


//Задача3 Напишите программу, которая принимает на вход число и проверяет,кратно ли оно одновременно 7 и 23

int num;
    Console.WriteLine("Insert num"  );
    num = Convert.ToInt32(Console.ReadLine());

void CutNumberVoid()
{
    if (num%7==0)
    {
        if (num%23==0)
        {
        Console.WriteLine("Number кратно 7 и 23 ")        ;
        }
    }
    else 
    {
        Console.WriteLine("Number not multiple 7 и 23 ")    ;
    } 
    
    
   //  Второй вариант решения в одном условии 
    // if (num%7==0&num%23==0)
    // {
    //    Console.WriteLine("Number кратно 7 и 23 ")        ;
    // }
    // else 
    // {
    //     Console.WriteLine("Number not multiple 7 и 23 ")    ;
    // } 
}
CutNumberVoid();

// Задача4 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

int num1, num2;

    Console.WriteLine("Insert num1"  );
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insert num2"  );
    num2= Convert.ToInt32(Console.ReadLine());

void IsQad ()
{
    int quad1 =num1*num1;
    int quad2 =num2*num2;

    if (num1==quad2)
     {
        Console.WriteLine("yes");
     }
     else
        if (num2==quad1)
        {
            Console.WriteLine("yes");
        }
        else 
        {
            Console.WriteLine("no");
        }
}
IsQad();


void ShowArea(int quart)
{
    if (quart>=1 && quart <=4)
{
    if (quart == 1) Console.WriteLine("In this quart x >0 and y>0");
    if (quart == 2) Console.WriteLine("In this quart x <0 and y>0");
    if (quart == 3) Console.WriteLine("In this quart x <0 and y<0");
    if (quart == 4) Console.WriteLine("In this quart x <0 and y<0");
}
else
    Console.WriteLine("number incorrect");
}

Console.Write("input number of quart: ");
int numQuart = Convert.ToInt32(Console.ReadLine());

ShowArea(numQuart);


// Задача Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int NumQuad(int x, int y)
{
    int chet=-1;
    if (x==0 || y==0) return 0;
    if (x>0 && y>0)  chet=1;
    if (x<0 && y>0)  chet=2; 
    if (x<0 && y<0)  chet=3; 
    if (x>0 && y<0)  chet=4 ;    
    return chet;
}

Console.WriteLine("Insert x "  );
int x0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert y "  );
int y0 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumQuad(x0,y0));
//int number=NumQuad(x0,y0); // вернули x,y
//Console.WriteLine("Result " + number); это вариант более большой


// Задача Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N

void QuadN(int n)
{
    int current=1;
    
    while (n>=current)        
        {
           Console.WriteLine(current*current);
           current++; 
        }
} 

Console.WriteLine("Insert n "  );
int num = Convert.ToInt32(Console.ReadLine());

QuadN(num);

// !Семинар 3
// !Задача Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int FindSum(int a)
{
    int sum=0;

    for (int current=1; current<=a; current++)
        sum +=current;
    
    return sum;
}

Console.WriteLine("Insert n "  );
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Result  " + FindSum(num) ); // переписать с $

// !задача Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. через for 

int Kolich(int n)
    {
     int current=0;
     for (; n>=current; current++)
        {
            n=n/10;
            //Console.WriteLine(current);
            //Console.WriteLine(n);
        }
         

        return current;
   }
   
//! Через while 

// int Kolich(int n)
//     {
//         int current=0;
//         if (current<=n)
//         {
//             while (n>0)
//             {
//                 n=n/10;  
//                 current++;   
//                 Console.WriteLine(current);
//             }
//         }
//         //Console.WriteLine(current);    
//         return current;
//     }

// ! Через while но наоборот 


int Kolich(int num) 
{ 
    int result = 1; 
    int i = 1; 
    while(num / i > 10) 
    { 
        i = i * 10; 
        result++; 
    } 
    return result; 
} 
Console.WriteLine("Insert n "  );
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (Kolich(n)); 

// !задача Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//n!=1*2*3*4*n

int Proisv(int N) 
{ 
    int result = 1; 
    for(int i = 1; i <= N; i++) 
        result = result * i; 
    return result; 
} 
Console.Write("Введите число "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(Proisv(n));  

// !Задача Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Step(int a, int b) 
{ 
    int result = 1; 
    for(int i = 1; i <= b; i++) 
        result = result * a; 
    return result; 
} 
Console.Write("Введите первое число "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число "); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(Step(n, m));

//Семинар 4
// !Задача Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму положительных элементов массива.


int [] CreateRandomArray (int size, int minValue, int maxValue) // метод который генерирует случайные числа от заданных чисел
{
    int[] NewArray = new int [size];

    for (int i=0; i<size; i++)
    NewArray[i] = new Random().Next(minValue, maxValue +1);

    return NewArray;    
}

int [] CreateArray (int size) // создание массива с помошью введения числа пользхователем
{
    int[] NewArray = new int [size];

    Console.WriteLine("creating array: ");
    for (int i=0; i<size; i++)
    {
        {
            Console.WriteLine($"input {i+1} element: "); // {i+1} запрос по индексу поэтому i+1 
            NewArray[i] = Convert.ToInt32(Console.ReadLine());   
        }
    }
    Console.WriteLine();
    return NewArray;
}

void ShowArray (int[] array) // метод подбора
{
    for (int i=0; i<array.Length; i++) //если начинаем поиск с i+1, тогда мы должны 1 единицу отнять i<Array.Length -1
    Console.WriteLine(array[i] + " ");
    
}

int FindPositivSum(int[] array)
{
    int sum=0;

    for (int i=0; i<array.Length; i++)
        if (array[i]>0) sum+=array[i];

    return sum;
}

Console.WriteLine("input");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("min");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("max");
int max=Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray (size, min, max);
ShowArray(array);
int sumofPositiv=FindPositivSum(array);
Console.WriteLine("sum positiv " + sumofPositiv);

// !Задача Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] CreateRandomArray(int size, int minValue, int maxValue) 
{ 
    int[] newArray = new int[size];  
 
    for(int i = 0; i < size; i++) 
        newArray[i] = new Random().Next(minValue, maxValue+1); 
 
    return newArray; 
} 
 
int[] Otric(int[] newArray) 
{ 
    for(int i = 0; i < newArray.Length; i++) 
    newArray[i] = newArray[i] * -1; 
 
    return newArray; 
} 
 
void ShowArray(int[] array) 
{ 
    for(int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
} 
 
Console.Write("Input size of array: "); 
int size = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input min possible value of elements: "); 
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input max possible value of elements: "); 
int max = Convert.ToInt32(Console.ReadLine()); 
 
int[] array = CreateRandomArray(size, min, max); 
ShowArray(array); 
int[] otric2 = Otric(array); 
ShowArray(otric2);

//!наш вариант решения

int [] CreateRandomArray (int size, int minValue, int maxValue) // метод который генерирует случайные числа от заданных чисел
{
    int[] NewArray = new int [size];

    for (int i=0; i<size; i++)
    NewArray[i] = new Random().Next(minValue, maxValue +1);

    return NewArray;    
}

void ShowArray (int[] array) // метод подбора
{
    for (int i=0; i<array.Length; i++) //если начинаем поиск с i+1, тогда мы должны 1 единицу отнять i<Array.Length -1
    Console.WriteLine(array[i] + " ");
    
}

int [] Find (int [] array)
{
    
    for (int i=0; i<array.Length; i++)
         if (array[i]>0)
         {
            array[i]=array[i]*-1;
         } 
         else 
         {
          array[i]=array[i]*-1;
         }
            

    return array;
}


Console.Write("input");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("min");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("max");
int max=Convert.ToInt32(Console.ReadLine());

int [] Array1 = CreateRandomArray (size, min, max);
ShowArray(Array1);
int [] Array2 = Find(Array1);
ShowArray(Array2);


// !Задача Задайте одномерный массив из 20 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int [] CreateRandomArray (int size, int minValue, int maxValue) // метод который генерирует случайные числа от заданных чисел
{
    int[] NewArray = new int [size];

    for (int i=0; i<size; i++)
    NewArray[i] = new Random().Next(minValue, maxValue +1);

    return NewArray;    
}

void ShowArray (int[] array) // метод подбора
{
    for (int i=0; i<array.Length; i++) //если начинаем поиск с i+1, тогда мы должны 1 единицу отнять i<Array.Length -1
    Console.WriteLine(array[i] + " ");
    
}

int [] Find (int [] Array)
{
    int count=0;
    for (int i=0; i<Array.Length; i++)        
        if (Array[i]>10 && Array[i]<99)
        {
            count++;    
        }
        return count;

}

int size=20;
Console.Write("min");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("max");
int max=Convert.ToInt32(Console.ReadLine());

int [] Array = CreateRandomArray (size, min, max);
ShowArray(Array);
int [] Array2 = Console.WriteLine(" Count" + Find(array));

//!Семинар 5

int [] ReverseArray(int[] array)
{
    for (int i=0, j=array.Length -1; i<j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] =temp;
    }
    return array;
}
void ShowArray (int[] array) // метод печати на экран
{
    for (int i=0; i<array.Length; i++) //если начинаем поиск с i+1, тогда мы должны 1 единицу отнять i<Array.Length -1
    Console.Write(array[i] + " ");
    
}

//! Задача 1 Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int [] ReverseArray(int[] array)
{
    int LastIndex=array.Length-1;
    for (int i=0; i<array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[lastIndex -i];
        array[lastIndex -1 -i] =temp;
    }
    return array;
}

int [] ReverseArray(int[] array)
{
    for (int i=0, j=array.Length -1; i<j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] =temp;
    }
    return array;
}

int [] ReverseArray(int[] array)
{
    int i=0, j=array.Length -1;
    while(i<j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] =temp;

        i++;
        j--;

    }
    return array;
}

int [] myArray = {3,5,1,8,2,9,4};
myArray=ReverseArray(myArray);
ShowArray(myArray);

//! Задача Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 18/2 - 9 0
// 9/2 -  4 1
// 4/2    2 0
// 2/2    1 0
// 1/2    0 1


string ChangeGigitSystem (int num)
{
    string ResultNumber = string.Empty;   //начинаем с пустой строкой
    while (num>0)
    {
        ResultNumber=num%2+ResultNumber; // забираем последнюю цифру
        num/=2;
    }
    return ResultNumber;
    
}
Console.WriteLine(ChangeGigitSystem(18));


//! Задача Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//a=b+c 3 числа

void NumbersTri (int num1, int num2, int num3)
{
    if (num1>num2+num3||num2>num1+num3||num3>num2+num1) Console.Write("Невозможен: ");
    else Console.Write("Возможен: ");
    
}

Console.Write("Input array - A ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Input array - B ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("Input array - C ");
int c=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

NumbersTri (a,b,c);


bool NumbersTri (int num1, int num2, int num3)
{
    return num1>num2+num3&&num2>num1+num3&&num3>num2+num1; // вариант записи при bool
    
    
    //if (num1>num2+num3||num2>num1+num3||num3>num2+num1) return true;
    //else return false;
    
}

Console.Write("Input array - A ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Input array - B ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("Input array - C ");
int c=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(NumbersTri (a,b,c));

//! Задача Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. каждое последуещее число = сумме предыдущих 0 1 1 2 3 5 8 13 21 34 55

int [] CreateArray (int n) // создание массива с помошью введения числа пользователем
{
    int[] NewArray = new int [n];
    Console.WriteLine("creating array: ");
    NewArray[0]=0;
    NewArray[1]=1;
    for (int i=2; i<n; i++)
    {
        {
            NewArray[i]=NewArray[i-1] +NewArray[i-2];
        }
    }
    return NewArray;
}

Console.Write("Input array - A ");
int n=Convert.ToInt32(Console.ReadLine());
ShowArray(CreateArray(n));



//!Семинар 6
//!Задача Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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
    

//!Задача Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

int[,] CreateRandom2DArray1(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
            newArray[i,j] = i + j;

    return newArray;     

}



//!Задача Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

//!Задача Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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



            Console.Write("Введите строку:");
            int pos1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите столбец:");
            int pos2 = Convert.ToInt32(Console.ReadLine());
            int n = 5; // размер массива
            int m = 7; // размер массива
            Random random = new Random();
            int[,] arr = new int[n, m];
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(10, 99);
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
            {
                Console.WriteLine("Элемент не существует");
            }
            else
            {
                Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
            }
            Console.ReadLine();
 
        
//!Семинар 7

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

//!Задача Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

//!Задача Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
    
//!Задача Из двумерного массива целых чисел удалить строку и столбец(присваивать 0), на пересечении которых расположен наименьший элемент.

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

    //!Семинар 8 

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

//! Задача Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void ShouNumbs (int n)
{
    if (n>1) 
        ShouNumbs (n-1);
    Console.WriteLine(n+ " ");    
}
//ShouNumbs(5);

//!Задача Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumofDigi (int n)
{
    if (n>=10) 
    {
        return n%10 + SumofDigi (n/10);
        
    }
    else    return n;
      
}
// Console.WriteLine();  
// Console.WriteLine(SumofDigi(12345));  
// //ShouNumbs(5);

//!Задача Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShouNum (int m, int n)
{
    
    if (n>m)
    {
        ShouNum (m,n-1);
          
    } 
        Console.Write(n + " ");  
    
}
//ShouNum(1,10);

//!Задача Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//a*bn   

//a=2   b=3 2*2*2

int Vozvod (int a, int b)
{    
    if (b>1)
    {
      return a* Vozvod (a,b-1);        
    } 
    else return a;        
}

Console.WriteLine();  
Console.WriteLine(Vozvod(4,2));          