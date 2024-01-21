using System;
using Builder.Scripts.Ui.TimerPanel;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Builder.Scripts.Builders
{
    public class TimerPanelBuilder
    {
        private float _deltaSeconds;
        private Transform _spawnTransform;
        private TimerView _timerViewPrefab;

        public TimerPanelBuilder WithDeltaSeconds(float deltaSeconds)
        {
            _deltaSeconds = deltaSeconds;

            return this;
        }

        public TimerPanelBuilder WithSpawnTransform(Transform spawnTransform)
        {
            _spawnTransform = spawnTransform;

            return this;
        }

        public TimerPanelBuilder WithTimerViewPrefab(TimerView timerViewPrefab)
        {
            _timerViewPrefab = timerViewPrefab;

            return this;
        }

        public TimerViewPresenter Build()
        {
            if (_deltaSeconds <= 0)
                throw new NullReferenceException("deltaSeconds is invalid");

            if (_timerViewPrefab == null)
                throw new NullReferenceException("timerViewPrefab is null");

            if (_spawnTransform == null)
                throw new NullReferenceException("spawnTransform is null");
            
            var timerView = Object.Instantiate(_timerViewPrefab, _spawnTransform);
            
            timerView.SetParentPosition(_spawnTransform.position);

            return new TimerViewPresenter(timerView, _deltaSeconds);
        }
    }
}
