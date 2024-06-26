using Task1;
using Task2;

AirFlight airFlight1 = new AirFlight();
airFlight1.Print();

AirFlight airFlight2 = new AirFlight("Нью-Йорк", 1, 50);
airFlight2.Print();

Console.WriteLine(airFlight1["Пункт назначения"]);
Console.WriteLine(airFlight1["Вместимость"]);
Console.WriteLine(airFlight1[0]);


Console.WriteLine($"Площадь квадрата:{Operations.Square(2)}");
var y = Operations.Square(3,2);
Console.WriteLine($"Площадь прямоугольника:{y}");