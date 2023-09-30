using UnityEngine;

namespace Game.Scripts.ScriptableObjects.GridSystem
{
    [CreateAssetMenu(fileName = "GridData", menuName = "ScriptableObjects/General/GridSystem/GridData", order = 0)]
    public class GridData : ScriptableObject
    {
        [Header("General Grid Size Options")]
        [Space(4)]
        
        [SerializeField] private int gridWidth;
        [SerializeField] private int gridHeight;
        
        [Header("General Card Spacing Options")]
        [Space(4)]
        
        [SerializeField] private float cardSpaceX;
        [SerializeField] private float cardSpaceY;

        public int GridWidth => gridWidth;
        public int GridHeight => gridHeight;

        public float CardSpaceX => cardSpaceX;
        public float CardSpaceY => cardSpaceY;
        
    }
}