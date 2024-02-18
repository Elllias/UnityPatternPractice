using System;
using Facade.Scripts.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Facade.Scripts.Utils.AuthenticationPanel
{
    public class AuthenticationController : MonoBehaviour
    {
        [SerializeField] private Button _loginButton;
        [SerializeField] private Button _registerButton;

        [SerializeField] private AuthenticationView _authenticationView;
        [SerializeField] private AuthenticationManager _authenticationManager;

        private void OnEnable()
        {
            _loginButton.onClick.AddListener(OnLoginButtonClicked);
            _registerButton.onClick.AddListener(OnRegisterButtonClicked);
        }

        private void OnDisable()
        {
            _loginButton.onClick.RemoveListener(OnLoginButtonClicked);
            _registerButton.onClick.RemoveListener(OnRegisterButtonClicked);
        }

        private void OnLoginButtonClicked()
        {
            var user = GetUserCandidate();

            _authenticationManager.LoginUser(user);
        }

        private void OnRegisterButtonClicked()
        {
            var user = GetUserCandidate();

            _authenticationManager.RegisterUser(user);
        }

        private User GetUserCandidate()
        {
            var login = _authenticationView.GetLoginText();
            var password = _authenticationView.GetPasswordText();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Login or password is empty.");
            }

            return new User(login, password);
        }
    }
}