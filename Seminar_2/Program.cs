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
