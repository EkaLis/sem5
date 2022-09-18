// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine ("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
FillArrRandomNumbers(numbers);
Console.WriteLine();
PrintArr(numbers);
int count = 0;

{
    for (int x = 0; x < numbers.Length; x++) 
    if (numbers [x] % 2 == 0)
    count++;
}    

Console.WriteLine ($"все числа {numbers.Length}, {count} четные числа");

void FillArrRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArr(int[] numbers)
{
    Console.Write("");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i] + "");
    } 
    Console.Write("");
    Console.WriteLine();
}
