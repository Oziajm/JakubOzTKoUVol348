using UnityEngine;

namespace TKOU.SimAI.Levels

{
    [CreateAssetMenu(fileName = nameof(Player), menuName = nameof(SimAI) + "/" + nameof(Player))]
    public class Player : ScriptableObject
    {
        public int cash = 200;

        public int ownedBuildings = 0;

        public string playerName;
    }
}
