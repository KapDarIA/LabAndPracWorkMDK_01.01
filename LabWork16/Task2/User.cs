namespace Task2
{
    internal class User
    {
        public delegate void EventHandler(string login);
        public event EventHandler? Notify;

        private string _login;
        private string _password;



        public string Login
        {
            get => _login;
            set
            {
                if (_login != value && !string.IsNullOrWhiteSpace(value))
                {
                    _login = value;
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value && !string.IsNullOrWhiteSpace(value))
                {
                    _password = value;
                }
            }
        }
        public void Change(string login, string password)
        {
            if (login != _login && password != _password)
                Notify?.Invoke($"Изменены данные пользователя со следующим логином:{login}{password})");
            else if (login == _login && password != _password)
                Console.WriteLine("Вы поменяли пароль");
            else if (login != _login && password == _password)
                Console.WriteLine("Вы поменяли логин");
            else
                Console.WriteLine("Вы ничего не поменяли:(");
        }

    }
}
