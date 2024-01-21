using System.Collections;
using UnityEngine;

namespace EntryPoint.Scripts.Systems
{
    public class AISystem
    {
        public IEnumerator StartSystem()
        {
            // There must be some logic here
            yield return new WaitForSeconds(3f);
            
            Debug.Log("AISystem is started.");
        }
    }
}
