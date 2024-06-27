using System.ComponentModel;
using Task2;

User user = new() { Login = "misha", Password = "12345" };

user.Notify += User_Notify;

void User_Notify(string login)
{
    throw new NotImplementedException();
}

Console.Write("Поменяте логин:");
user.Login = Console.ReadLine();
Console.Write("Поменяте пароль:");
user.Password = Console.ReadLine();

void User_PropertyChanged(object? sender, PropertyChangedEventArgs e)
{
    Console.WriteLine($"{e.PropertyName} изменено");
}

