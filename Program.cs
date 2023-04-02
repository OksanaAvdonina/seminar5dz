//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreateRandomArry(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int WriteArray(int[] array)
{
    int count = 0; // переменная для подсчета количества четных чисел
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) // если число четное
            count++; // увеличиваем счетчик на 1
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return (count);
}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");// минимальное значение элемента массова
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите максимальное значение элемента массива: "); //  значение элемента массова
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArry(length, min, max);
Console.WriteLine($"Количество чётных чисел в массиве  {WriteArray(myArray)}");
*/



//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] FillArray()
{
    int[] array = new int[10];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}

int SumElement(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}

int[]array = FillArray();
PrintArray(array);

int sum = SumElement(array);
System.Console.WriteLine($"Сумма элементов нечётных позиций = {sum}");// выводим результат
System.Console.WriteLine();


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76

/*
double[] CreateRandomArry(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round( new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 2);
    }
    return array;
}
void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double FindMaxNumber(double[] array)
{
    double max = array[0]; // переменная для хранения максимального элемента
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMinNumber(double[] array)
{
    double min = array[0]; // переменная для хранения минимального элемента
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
Console.Write("Input a length of array: ");// количество элементов массива
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");// минимальное значение элемента массова
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input a max possible value: ");// максимальное значение элемента массова
int max = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArry(length, min, max);
WriteArray(myArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами: {FindMaxNumber(myArray) - FindMinNumber(myArray)}"); // выводим результат
*/

