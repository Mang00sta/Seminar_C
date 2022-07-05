
//Задача 1 
//Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.
/*
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
*/

// Выполнили через void задачу №1
/*
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
/*/


// Задача 2
// Напишите программу, которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.

/*
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
/*/

//Задача3
/* Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.*/

/* 
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
    
    //* Второй вариант решения в одном условии 
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
/*/


// Задача4
/* Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.*/
/*/
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
/*/


/*
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
/*/

// Задача
/* Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/
/*
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

/*/

// Задача
/*Напишите программу, которая принимает на вход число (N) и 
выдаёт квадраты чисел от 1 до N.*/

/*
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
//*/


// !Семинар 3
// !Задача
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
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
*/

// !задача 
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//! через for 
/*
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
*/
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

/* 
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
*/ 

// !задача 
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//n!=1*2*3*4*n
/* 
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
*/ 

// !Задача 
//Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
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
*/