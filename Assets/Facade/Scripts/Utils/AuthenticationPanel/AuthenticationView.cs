using System;
using Facade.Scripts.Core;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Facade.Scripts.Utils.AuthenticationPanel
{
    public class AuthenticationView : MonoBehaviour
    {
        [SerializeField] private TMP_InputField _loginField;
        [SerializeField] private TMP_InputField _passwordField;

        public string GetLoginText()
        {
            return _loginField.text;
        }

        public string GetPasswordText()
        {
            return _passwordField.text;
        }
    }
}