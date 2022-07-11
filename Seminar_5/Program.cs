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
/*
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
/*/
/*
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
/*/
/*
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
/*/


/*
int [] myArray = {3,5,1,8,2,9,4};
myArray=ReverseArray(myArray);
ShowArray(myArray);
/*/
//! Задача Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
18/2 - 9 0
9/2 -  4 1
4/2    2 0
2/2    1 0
1/2    0 1
/*/
/*
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
/*/

//! Задача Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

//a=b+c 3 числа
 /*
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
/*/

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


//! Задача Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// каждое последуещее число = сумме предыдущих 0 1 1 2 3 5 8 13 21 34 55
/*
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
/*/
