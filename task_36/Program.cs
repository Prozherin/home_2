// // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12]-> 19
// // [-4, -6, 89, 6]-> 0


List<int> numbers = new List<int>();
numbers.Add(3);
numbers.Add(7);
numbers.Add(23);
numbers.Add(12);

int sumOfOddElements = 0;

for (int i = 1; i <= numbers.Count - 1; i += 2)
{
    sumOfOddElements += numbers[i];
}

Console.Write("Сумма элементов на нечетных позициях: ");
Console.WriteLine(sumOfOddElements);