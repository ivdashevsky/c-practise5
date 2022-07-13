//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве

int [] fillMassive(int N)
{
    int [] arr = new int [N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    return arr;
}

void printMas(int [] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]}|");
    }
}

int [] mas = fillMassive(4);

printMas(mas);

int count = 0;

for (int i = 0; i < mas.Length; i++)
{
    if (mas[i]%2 == 0) {count++;}

}

Console.WriteLine($"Кол-во чётных чисел {count}");