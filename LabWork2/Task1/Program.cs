namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int item = 0;

            Console.Write($"{SearchItem(item)}");
        }

        private static int SearchItem(int searchValue)
        {
            int[] array = new int[] { 1, 8, 4, 24, 66, 34 };

            int i = 0;

            while (i < array.Length)
            {
                if (i > array.Length)
                {
                    break;
                }
                if (array[i] == searchValue)
                {
                    return i;
                }

                i++;
            }
            return -1;
        }
    }
}
