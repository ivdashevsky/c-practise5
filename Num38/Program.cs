﻿//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] fillMassive(int N, double min, double max)
{
    double [] arr = new double [N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = Math.Round(max + new Random().NextDouble() * (max - min),2, MidpointRounding.AwayFromZero);
    }
    return arr;
}

void printMas(double [] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]}|");
    }
}

double [] arr = fillMassive(6, -10, 10);

printMas(arr);

double max = arr[1];
double min = arr[1];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max) {max = arr[i];}
    if (arr[i] < min) {min = arr[i];}
}

Console.WriteLine();
Console.WriteLine($"Максимальное число = {max}, минимальное = {min}");
Console.WriteLine($"Разница между max и min = {max - min}");