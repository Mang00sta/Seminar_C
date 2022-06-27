//Задача 1 
//Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.
/*
int CutNumber();
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
*/


// Задача 2
// Напишите программу, которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.

/*
int CutNumber()
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

/int number=CutNumber();
Console.WriteLine("Result " + number);
*/

//Задача3
// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

/* 
int number, krat7, krat23;


Console.WriteLine("Insert num" );

10 

 krat7 = number % 7; 
 krat23 = number % 23;

if (number==krat7)
{
    krat7 = number % 7;
}
*/






/*
Console.WriteLine("Result " + number)

// Задача4
// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

void IsQad (int num, int num2)
{
    int quad =num2*num2;
    int quad =num1 * num1;

    if (num1==quad2)
     Console.WriteLine
}
*/

