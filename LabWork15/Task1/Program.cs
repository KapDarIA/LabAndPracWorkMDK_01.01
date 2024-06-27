//3.1
namespace Task1
{
    internal class Program
    {
        delegate int Function(int x);

        static void Main(string[] args)
        {
            Function function = x => x * x;
            Console.WriteLine($"x*x={function(-3)}");
            function = GetFactorial;
            Console.WriteLine($"x!={function(-3)}");
            function = GetModule;
            Console.WriteLine($"|x|={function(-3)}");
        }

        public static int GetFactorial(int x)
        {
            int result = 1;
            if (x < 0)
                return -1;
            for (int i = 2; i < x; i++)
                result *= x;
            return result;
        }

        public static int GetModule(int x)
        {
            if (x < 0)
                return -x;
            return x;
        }
    }
}
