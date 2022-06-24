// 1я задача
/*
int number;

Console.Write("Input a number: ");
number = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Your number is" + number);
*/

// 2я задача
/*
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
*/

//Задача 3
// Напишите программу, которая будет выдавать название дня недели по заданному номеру
/*
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
*/
// Задача 4
// Напишите программу, которая на вход принимает число и выдаёт его квадрат.
/*
int num1, quad;

Console.Write("Input a number: ");
num1 = Convert.ToInt32(Console.ReadLine()); 

quad=num1*num1;

Console.Write("Your quad number " + quad);
*/

// Задача 5
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
int n, current;

Console.Write("input a num ");
n = Convert.ToInt32(Console.ReadLine());

current=n* (-1);

while(current <= n)
{
    Console.Write(current + " ");
    current++; //current = current + 1
}
*/