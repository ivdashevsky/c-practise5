//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int [] fillMassive(int N)
{
    int [] arr = new int [N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(-100,100);
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

int [] mas = fillMassive(6);

printMas(mas);

int count = 0;

for (int i = 0; i < mas.Length; i++)
{
    if (i%2 != 0) {count = count + mas[i];}

}

Console.WriteLine($"Сумма {count}");