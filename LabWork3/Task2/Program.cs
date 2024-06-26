float GetPower(float number, int degree)
{
    if (degree == 0) return 1;
    else if (degree > 0) return number * GetPower(number, degree - 1);
    else return (1 / number) * GetPower(number, degree + 1);
}
Console.WriteLine("Введите число и его степень: ");
float number = Convert.ToInt32(Console.ReadLine());
int degree = Convert.ToInt32(Console.ReadLine());
Console.Write($"Возведение числа в степень равняется {GetPower(number, degree)}");