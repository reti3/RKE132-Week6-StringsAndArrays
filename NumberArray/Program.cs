﻿// suvaline massiv, 10 elementi

int[] numbers = new int[10];
Random rnd = new Random();
int sum = 0;

//populating the array = salvestatakse väärtused massiivi
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, numbers.Length + 1);
    sum = sum + numbers[1];
}

foreach (int number in numbers) //kuvame väärtused
{
    Console.WriteLine(number);
}
Console.WriteLine($"Total: {sum}");