int GetFactorial(int number)
{
    if (number == 0)
    {
        return 1;
    }
    if (number < 0)
    {
        return ;
    }
    if(number > 0)
    {
        return number * GetFactorial(number - 1); 
    }
}
try
{
    int number;
    Console.WriteLine("Введите факториал: ");
    number = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Факториал равен {GetFactorial(number)}");
}
catch (Exception)
{
    Console.WriteLine("faild");
}
