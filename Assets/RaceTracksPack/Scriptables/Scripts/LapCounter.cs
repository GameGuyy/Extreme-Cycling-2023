using UnityEngine;

namespace ExtremeCycling.Scriptables.Scripts
{
    [CreateAssetMenu(fileName = "Laps", menuName = "ScriptableObjects/LapCounter", order = 1)]
    public class LapCounter : ScriptableObject
    {
        public int lapsCounter = 1;
    }
}
