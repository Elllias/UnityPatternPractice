using System.Collections;
using UnityEngine;

namespace EntryPoint.Scripts.Systems
{
    public class MovementSystem
    {
        public IEnumerator StartSystem()
        {
            // There must be some logic here
            yield return new WaitForSeconds(1f);
            
            Debug.Log("MovementSystem is started.");
        }
    }
}
