// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrRandomNumbers(numbers);
Console.WriteLine();
PrintArr(numbers);
int summa = 0;

{
    for(int x = 0; x < numbers.Length; x+=2)
    summa = summa + numbers[x];
}
Console.WriteLine ($"все числа {numbers.Length}, {summa} сумма на нечетных позициях");

void FillArrRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,10);
    }
}
void PrintArr(int[] numbers)
{
    Console.Write("");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "");
    }
    Console.Write("");
    Console.WriteLine();
}

