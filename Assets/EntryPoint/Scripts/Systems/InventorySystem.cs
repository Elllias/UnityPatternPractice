using System.Collections;
using UnityEngine;

namespace EntryPoint.Scripts.Systems
{
    public class InventorySystem
    {
        public IEnumerator StartSystem()
        {
            // There must be some logic here
            yield return new WaitForSeconds(2f);
            
            Debug.Log("InventorySystem is started.");
        }
    }
}
