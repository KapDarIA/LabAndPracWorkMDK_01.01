int GetPower(int number, int degree)
{
    if (degree == 0) return 1;
    else if (degree % 2 == 1) return number * GetPower(number, degree - 1);
    else return number * number * GetPower(number, degree - 2);
}
Console.WriteLine("Введите число и его степень: ");
int number = Convert.ToInt32(Console.ReadLine());
int degree = Convert.ToInt32(Console.ReadLine());
Console.Write($"Возведение числа в степень равняется {GetPower(number, degree)}");