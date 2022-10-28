using UnityEngine;

namespace TKOU.SimAI.Levels
{
    /// <summary>
    /// Data of a single building.
    /// </summary>
    [CreateAssetMenu(fileName =nameof(BuildingData), menuName = nameof(SimAI)+"/"+nameof(SimAI.Levels)+"/"+nameof(BuildingData))]
    public class BuildingData : ScriptableObject, IAmData
    {
        [field: SerializeField]
        public Sprite BuildingSprite { get; private set; }

        [field: SerializeField]
        public BuildingEntity BuildingEntityPrefab { get; private set; }

        [field:SerializeField]
        public string BuildingName { get; private set; }

        [field: SerializeField]
        public int BuildingPrice = 0;

        Sprite IAmData.DataIcon => BuildingSprite;

        string IAmData.DataName => BuildingName;

        int IAmData.DataPrice => BuildingPrice;

        IAmEntity IAmData.EntityPrefab => BuildingEntityPrefab;
    }
}
