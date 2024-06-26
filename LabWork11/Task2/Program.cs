Dictionary<string, int> users = new Dictionary<string, int>()
{
    {"login123",3 },
    {"XXX_Tolyan228_XXX2019",5 },
    {"MasterOfBeer",40 }
};

Console.Write("Введите количество пользователей, которых хотите добавить:");
int usersCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

for (int i = 0; i < usersCount; i++)
{
    Console.Write("Введите логин пользователя:");
    string login = Console.ReadLine();

    Console.Write("Введите возраст пользователя:");
    int age = Convert.ToInt32(Console.ReadLine());

    users.TryAdd(login, age);
}

Console.WriteLine();

foreach (var user in users)
{ 
    Console.WriteLine($"Логин:{user.Key} - Возраст:{user.Value}");
}

Console.WriteLine();

Console.WriteLine($"Количество элементов в словаре:{users.Count}");

Console.WriteLine();

Console.Write("Введите ключ, который нужно найти:");
string key = Console.ReadLine();

if (users.ContainsKey(key))
{
    Console.WriteLine($"Пользователь найден. Информация о нём: Логин:{key} - Возраст:{users[key]}");
}
else
{
    Console.WriteLine("Ключ не найден");
}

Console.WriteLine();

Console.Write("Введите возраст, у которого хотите найти количество совпадений:");
int searchAge = Convert.ToInt32(Console.ReadLine());

int count = 0;
foreach (var user in users)
{
    if (user.Value == searchAge)
    {
        count++;
    }
}
Console.WriteLine($"Количество совпадений: {count}");

Console.WriteLine();

Console.Write("Введите логин элемента, который хотите удалить:");
string deleteUser = Console.ReadLine();

Console.WriteLine();

if (users.ContainsKey(deleteUser))
{
    users.Remove(deleteUser);
    Console.WriteLine("Пользователь удалён");
}

Console.WriteLine();
foreach (var user in users) Console.WriteLine($"Логин:{user.Key} - Возраст:{user.Value}");