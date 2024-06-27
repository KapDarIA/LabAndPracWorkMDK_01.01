double GetPower(double x, int n)
{
    if (n == 0)
        return 1;
    if (n % 2 == 0)
        return x * x * GetPower(x, n - 2);
    if (n % 2 == 1)
        return x * GetPower(x, n - 1);
    return -1;
}
Console.WriteLine(GetPower(2, 5));