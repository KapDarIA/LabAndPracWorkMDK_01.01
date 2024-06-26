Console.WriteLine("Сортировка вставками");

int[] array = { 7, 0, -4, 3, 1, -2, 5 };

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} \t");
}

Console.WriteLine();

for (int i = 1; i < array.Length; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (array[j] > array[i])
        {
            (array[j], array[i]) = (array[i], array[j]);
        }
    }

    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} \t");
    }

    Console.WriteLine();
}

