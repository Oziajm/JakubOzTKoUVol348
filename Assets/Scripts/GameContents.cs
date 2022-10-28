using TKOU.SimAI.Levels;
using UnityEngine;

#if UNITY_EDITOR
using TKOU.SimAI.Editor;
#endif

namespace TKOU.SimAI
{
    /// <summary>
    /// Contains all game elements.
    /// </summary>
    [CreateAssetMenu(fileName =nameof(GameContents), menuName = nameof(SimAI) + "/" + nameof(GameContents))]
    public class GameContents : ScriptableObject
    {
        public TileData[] tiles;
        public BuildingData[] buildings;
        public Player player;

        [ContextMenu(nameof(LoadAll))]

#if UNITY_EDITOR

        public void LoadAll()
        {
            player.cash = 200;
            player.ownedBuildings = 0;
            player.spentMoney = 0;

            foreach(var building in buildings)
            {
                building.BuildingPrice = Random.Range(50, 150);
            }
        }
        #endif
    }
}