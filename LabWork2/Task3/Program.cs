namespace Task3
{
    internal class Program
    {
        public static void Main()
        {
            int[] numbers = { 0, 1, 1, 2, 3, 5, 8};

            Array.Sort(numbers);

            int item = 1;

            int index = jumpSearch(numbers, item);

            Console.Write($"Число {item} с индексом {index}");
        }
        public static int jumpSearch(int[] numbers, int x)
        {
            int size = numbers.Length;

            int step = (int)Math.Sqrt(size);

            int prev = 0;

            for (int minStep = Math.Min(step, size) - 1; numbers[minStep] < x; minStep = Math.Min(step, size) - 1)
            {
                prev = step;
                step += (int)Math.Sqrt(size);

                if (prev >= size)
                {
                    return -1;
                }
            }

            while (numbers[prev] < x)
            {
                prev++;

                if (prev == Math.Min(step, size))
                {
                    return -1;
                }   
            }

            if (numbers[prev] == x)
            {
                return prev;
            }

            return -1;
        }


    }
}
