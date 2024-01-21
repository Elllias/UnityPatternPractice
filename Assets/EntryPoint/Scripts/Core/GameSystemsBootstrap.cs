using System.Collections;
using EntryPoint.Scripts.Systems;
using UnityEngine;

namespace EntryPoint.Scripts.Core
{
    public class GameSystemsBootstrap : MonoBehaviour
    {
        private AISystem _aiSystem;
        private MovementSystem _movementSystem;
        private InventorySystem _inventorySystem;

        private void Awake()
        {
            _aiSystem = new AISystem();
            _movementSystem = new MovementSystem();
            _inventorySystem = new InventorySystem();
        }

        private IEnumerator Start()
        {
            yield return _aiSystem.StartSystem();
            yield return _movementSystem.StartSystem();
            yield return _inventorySystem.StartSystem();
        }
    }
}
