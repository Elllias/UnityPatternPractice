using UnityEngine;

namespace Facade.Scripts.Core
{
    public class RegisterService
    {
        public void RegisterUser(User user)
        {
            // Some register process
            Debug.LogWarning($"User register: \nl: {user.GetLogin()} \np: {user.GetPassword()}");
        }
    }
}