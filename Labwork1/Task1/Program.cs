Console.WriteLine("Сортировка методом простого выбора");

int[] array = { 7, 0, -4, 3, 1, -2, 5 };
int min, temp;

for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}\t");
Console.WriteLine();

for (int i = 0; i < array.Length - 1; i++)
{
    min = i;

    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[min])
            min = j;
    }

    temp = array[i];
    array[i] = array[min];
    array[min] = temp;

    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]}\t");
    }
    Console.WriteLine();
}

