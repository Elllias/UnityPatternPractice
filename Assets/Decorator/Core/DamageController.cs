using System;
using System.Collections.Generic;
using Decorator.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;


namespace Decorator.Core
{
    public class DamageController : MonoBehaviour
    {
        private const int ABILITY_DAMAGE = 10;
        private const int ADDITIONAL_ABILITY_DAMAGE = 5;
        
        [SerializeField] private List<Enemy> _livedEnemies;
        [SerializeField] private Button _button;

        private IAbility _ability;

        private void Awake()
        {
            _ability = new Ability(ABILITY_DAMAGE);
            _ability = new UltraAbility(_ability, ADDITIONAL_ABILITY_DAMAGE);
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(TakeDamageDamageables);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(TakeDamageDamageables);
        }

        private void TakeDamageDamageables()
        {
            for (var i = 0; i < _livedEnemies.Count; i++)
            {
                if (_livedEnemies[i].IsLived())
                    _ability.Damage(_livedEnemies[i]);
                else
                    _livedEnemies.RemoveAt(i);
            }
        }
    }
}
