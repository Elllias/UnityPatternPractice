using UnityEngine;

namespace Facade.Scripts.Core
{
    public class LoginService
    {
        public void LoginUser(User user)
        {
            // Some login process
            Debug.LogWarning($"User login: \nl: {user.GetLogin()} \np: {user.GetPassword()}");
        }
    }
}
