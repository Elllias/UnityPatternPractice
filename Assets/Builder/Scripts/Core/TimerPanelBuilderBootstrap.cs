using System;
using Builder.Scripts.Builders;
using Builder.Scripts.Ui.TimerPanel;
using UnityEngine;
using UnityEngine.Serialization;

namespace Builder.Scripts.Core
{
    public class TimerPanelBuilderBootstrap : MonoBehaviour
    {
        [SerializeField] private TimerView _timerView;
        [SerializeField] private Transform _spawnTransform;
        [SerializeField] private float _deltaSeconds;
        
        private void Start()
        {
            var timePanelBuilder = new TimerPanelBuilder();

            var timerViewPresenter = timePanelBuilder
                .WithSpawnTransform(_spawnTransform)
                .WithTimerViewPrefab(_timerView)
                .WithDeltaSeconds(_deltaSeconds)
                .Build();
            
            timerViewPresenter.ShowView(); 
        }
    }
}
