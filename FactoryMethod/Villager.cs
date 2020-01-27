using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Villager : INPC
    {
        public void Speak()
        {
            Debug.Log("Villager: I'm here!");
        }
    }
}