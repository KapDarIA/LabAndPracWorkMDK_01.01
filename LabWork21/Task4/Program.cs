int GetDaysCount(int month, int year)
{
    int[] monthArray = { 31, (year % 400 == 0 || year % 100 != 0 && year % 4 == 0) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    if (month > 1 && month < 13)
        return monthArray[month - 1];
    else return -1;
}

Console.Write("Введите год:");
int year = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер месяца:");
int month = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetDaysCount(month, year));

