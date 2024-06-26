int GetFactorial(int number)
{
    if (number == 0) return 1;
    else if (number < 0) return 0;
    else return number * GetFactorial(number - 1);
}
int number;
Console.WriteLine("Введите факториал: ");
number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Факториал равен {GetFactorial(number)}");