using System;
using Builder.Scripts.Utils;
using UnityEngine;

namespace Builder.Scripts.Ui.TimerPanel
{
    public class TimerViewPresenter
    {
        private readonly TimerView _timerView;
        private readonly float _deltaSeconds;

        private Coroutine _timerCoroutine;
        private bool _timerEnabled;
        private Timer _timer;

        public TimerViewPresenter(TimerView timerView, float deltaSeconds)
        {
            _timerView = timerView;
            _deltaSeconds = deltaSeconds;

            _timerView.Enabled += OnEnable;
            _timerView.Disabled += OnDisable;
        }

        public void ShowView()
        {
            _timerView.Show();
        }

        public void HideView()
        {
            _timerView.Hide();
        }
        
        private void OnEnable()
        {
            _timer = new Timer(_deltaSeconds);
            _timerView.ButtonClicked += OnButtonClick;
            
            _timerEnabled = false;
            OnTimerTick(TimeSpan.Zero);
        }

        private void OnDisable()
        {
            _timerView.ButtonClicked -= OnButtonClick;
            
            if (_timerCoroutine != null)
                _timerView.StopCoroutine(_timerCoroutine);
            
            _timer = null;
        }

        private void OnButtonClick()
        {
            if (_timerEnabled)
            {
                _timerEnabled = false;
                
                _timerView.StopCoroutine(_timerCoroutine);
                _timer.Ticked -= OnTimerTick;
            }
            else
            {
                _timerEnabled = true;
                
                _timer.Ticked += OnTimerTick;
                _timerCoroutine = _timerView.StartCoroutine(_timer.Start());
            }
        }

        private void OnTimerTick(TimeSpan timeSpan)
        {
            _timerView.SetText($"{timeSpan:hh\\:mm\\:ss}");
        }
    }
}
