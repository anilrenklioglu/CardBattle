using UnityEngine;

namespace Game.Scripts.GridSystem
{
    public class GridTile : MonoBehaviour
    {
        private Vector2Int _tileGridPosition;
        
        public Vector2Int TileGridPosition => _tileGridPosition;

        public void SetGridPosition(Vector2Int tileGridPosition)
        {
            _tileGridPosition = tileGridPosition;
        }
        
        
    }
}