namespace Facade.Scripts.Core
{
    public class User
    {
        private readonly string _login;
        private readonly string _password;

        public User(string login, string password)
        {
            _login = login;
            _password = password;
        }

        public string GetLogin()
        {
            return _login;
        }

        public string GetPassword()
        {
            return _password;
        }
    }
}