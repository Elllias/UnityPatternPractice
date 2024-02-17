using System;
using UnityEngine;
using Decorator.Interfaces;

namespace Decorator.Core
{
    [Serializable]
    public class Enemy : MonoBehaviour, IDamageable
    {
        [SerializeField] private int _healthPoints;

        private bool _isLived = true;

        private void OnEnable()
        {
            if (_healthPoints <= 0)
            {
                Debug.LogWarning($"{gameObject.name} is dead.");
                
                _healthPoints = 0;
                _isLived = false;
            }
        }

        public void TakeDamage(int damage)
        {
            _healthPoints -= damage;
            Debug.LogWarning($"{gameObject.name} damaged: {damage}. Current HP: {_healthPoints}");
            
            if (_healthPoints <= 0)
            {
                Debug.LogWarning($"{gameObject.name} is dead.");
                
                _healthPoints = 0;
                _isLived = false;
            }
        }

        public bool IsLived()
        {
            return _isLived;
        }
    }
}
