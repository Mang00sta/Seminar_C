//!Семинар 4
// !Задача
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму положительных элементов массива.
//*
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

int FindPositivSum(int[] array);
{
    int sum=0;

    for (int i=0; i<array.Lenght; i++)
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



/*/

// !Задача Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
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
*/

//!наш вариант решения
/*
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
/*/

// !Задача Задайте одномерный массив из 20 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*
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
        
        if (Array[i]=>10 && Array[i]<=99) 
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
*/