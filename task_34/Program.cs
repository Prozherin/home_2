﻿// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234]-> 2

Random rand = new Random();
int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
}

System.Diagnostics.Debug.Assert(array.Length > 0);

int evenCount = 0;
foreach (int number in array)
{
    if (number % 2 == 0)
    {
        evenCount++;
    }
}

Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");