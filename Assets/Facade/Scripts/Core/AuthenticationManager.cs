using UnityEngine;

namespace Facade.Scripts.Core
{
    public class AuthenticationManager : MonoBehaviour
    {
        private LoginService _loginService;
        private RegisterService _registerService;

        private void Awake()
        {
            _loginService = new LoginService();
            _registerService = new RegisterService();
        }

        public void LoginUser(User user)
        {
            _loginService.LoginUser(user);
        }

        public void RegisterUser(User user)
        {
            _registerService.RegisterUser(user);
        }
    }
}