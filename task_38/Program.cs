// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

float[] array = new float[5];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    // double array = random.NextDouble() * 99;
    array[i] = random.NextSingle() * 99;
}

float maxValue = array.Max();
float minValue = array.Min();

double difference = maxValue - minValue;

Console.WriteLine(String.Join(" ", array));
Console.WriteLine($" {array.Max()} - {array.Min()} = " + difference);