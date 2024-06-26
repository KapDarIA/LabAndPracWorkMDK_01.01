namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int item = 9;

            Console.Write(BinarySerching(item));

        }

        private static int BinarySerching(int item)
        {
            int[] numbers = new int[] { 1, 2, 3, 5, 6, 7 };

            Array.Sort(numbers);

            int middle;
            int left = 0, right = numbers.Length - 1;

            do
            {
                middle = (right + left) / 2;

                if (item == numbers[middle])
                {
                    return middle;
                }
                else if (item < numbers[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            } while (right >= left);

            return -1;
        }
    }
}
