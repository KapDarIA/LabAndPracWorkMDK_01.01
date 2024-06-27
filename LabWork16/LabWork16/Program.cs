using LabWork16;
using System.ComponentModel;

User user = new() { Login = "misha", Password = "12345" };

user.PropertyChanged += User_PropertyChanged;

Console.Write("Поменяте логин:");
user.Login = Console.ReadLine();
Console.Write("Поменяте пароль:");
user.Password = Console.ReadLine();

 void User_PropertyChanged(object? sender, PropertyChangedEventArgs e)
{
    Console.WriteLine($"{e.PropertyName} изменено");
}

