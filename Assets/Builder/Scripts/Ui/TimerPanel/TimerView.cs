using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Builder.Scripts.Ui.TimerPanel
{
    public class TimerView : MonoBehaviour
    {
        public event Action ButtonClicked;
        public event Action Enabled;
        public event Action Disabled;
        
        [SerializeField] private RectTransform _parentTransform;
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Button _button;

        private void OnEnable()
        {
            Enabled?.Invoke();
            _button.onClick.AddListener(OnButtonClick);
        }

        private void OnDisable()
        {
            Disabled?.Invoke();
            _button.onClick.RemoveListener(OnButtonClick);
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void SetParentPosition(Vector3 position)
        {
            _parentTransform.anchoredPosition = position;
        }

        public void SetText(string value)
        {
            _text.text = value;
        }

        private void OnButtonClick()
        {
            ButtonClicked?.Invoke();
        }
    }
}