using Decorator.Interfaces;

namespace Decorator.Core
{
    public class Ability : IAbility
    {
        private readonly int _damage;

        public Ability(int damage)
        {
            _damage = damage;
        }
    
        public void Damage(IDamageable damageable)
        {
            damageable.TakeDamage(_damage);
        }

        public int GetDamage()
        {
            return _damage;
        }
    }
}
