using Decorator.Interfaces;

namespace Decorator.Core
{
    public class UltraAbility : IAbility
    {
        private readonly IAbility _ability;
        private readonly int _additionalDamage;

        public UltraAbility(IAbility ability, int additionalDamage)
        {
            _ability = ability;
            _additionalDamage = additionalDamage;
        }
        
        public void Damage(IDamageable damageable)
        {
            damageable.TakeDamage(_ability.GetDamage() + _additionalDamage);
        }

        public int GetDamage()
        {
            return _additionalDamage + _ability.GetDamage();
        }
    }
}