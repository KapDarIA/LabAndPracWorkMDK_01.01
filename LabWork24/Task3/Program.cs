namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер месяца:");
            int month = Convert.ToInt32(Console.ReadLine());

            DaysCount daysCount = new DaysCount();
            Console.WriteLine(daysCount.GetDaysCount(month, year));
        }
    }
}
