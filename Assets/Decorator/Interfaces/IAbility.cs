using UnityEngine;

namespace Decorator.Interfaces
{
    public interface IAbility
    {
        void Damage(IDamageable damageable);
        int GetDamage();
    }
}
