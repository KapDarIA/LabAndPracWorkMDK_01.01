//3.2
namespace Task2
{
    internal class Program
    {
        delegate void Function(int a, int b);

        static void Main(string[] args)
        {
            Function function = (int a, int b) => Console.WriteLine($"a+b={a + b}");
            function += (int a, int b) => Console.WriteLine($"a-b={a - b}");
            function += (int a, int b) => Console.WriteLine($"a*b={a * b}");
            function += (int a, int b) => Console.WriteLine($"a/b={a / b}");
            function(6,2);
        }
    }
}
