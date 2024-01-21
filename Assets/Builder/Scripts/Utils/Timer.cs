using System;
using System.Collections;
using UnityEngine;

namespace Builder.Scripts.Utils
{
    public class Timer
    {
        public event Action<TimeSpan> Ticked;

        private readonly float _deltaSeconds;
        private TimeSpan _timeSpan;

        public Timer(float deltaSeconds)
        {
            _deltaSeconds = deltaSeconds;
        }

        public IEnumerator Start()
        {
            while (true)
            {
                yield return new WaitForSeconds(_deltaSeconds);

                _timeSpan += TimeSpan.FromSeconds(_deltaSeconds);
                Ticked?.Invoke(_timeSpan);
            }
        }
    }
}
