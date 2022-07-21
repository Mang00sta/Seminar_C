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

//! Задача
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.


void ShouNumbs (int n)
{
    if (n>1) 
        ShouNumbs (n-1);
    Console.WriteLine(n+ " ");    
}
//ShouNumbs(5);
//!Задача
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

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

//!Задача
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShouNum (int m, int n)
{
    
    if (n>m)
    {
        ShouNum (m,n-1);
          
    } 
        Console.Write(n + " ");  
    
}
//ShouNum(1,10);


//!Задача
//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
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