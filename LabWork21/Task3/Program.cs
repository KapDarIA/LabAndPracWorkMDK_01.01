Console.WriteLine(GetSize(1));
Console.WriteLine(GetSize(1024));
Console.WriteLine(GetSize(1048576));
Console.WriteLine(GetSize(1024*1024*1024));

string GetSize(int bytes)
{
    if (bytes < Math.Pow(2,10))
        return $"{bytes} Б";
    if (bytes < Math.Pow(2, 20))
        return $"{bytes >> 10} КБ";
    if (bytes < Math.Pow(2, 30))
        return $"{bytes >> 20} МБ";
    if (bytes < Math.Pow(2, 40))
        return $"{bytes >> 30} ГБ";
    return ("Очень большое значение");
}