using System;
using Game.Scripts.ScriptableObjects.GridSystem;
using Game.Scripts.Util;
using UnityEngine;

namespace Game.Scripts.GridSystem
{
    public class GridManager : MonoBehaviour
    {
        [Header("Grid System Data")]
        [Space(4)]

        [SerializeField] private GridData gameGridData;
        [SerializeField] private GridTile tile;

        [Header("References")]
        [Space(4)]

        [SerializeField] private Camera mainCamera;

        private void OnValidate()
        {
            gameGridData = Resources.Load<GridData>(ResourceDirectories.GRID_SYSTEM_DATA_DIRECTORY);
            tile = Resources.Load<GridTile>(ResourceDirectories.GRID_TILE_DIRECTORY);
        }

        private void Start()
        {
            CreateGrid();
        }

        private void CreateGrid()
        {
            int _count = 0;
            
            float gridCenterX = (gameGridData.GridWidth - 1) * gameGridData.CardSpaceX / 2.0f;
            float gridCenterY = (gameGridData.GridHeight - 1) * gameGridData.CardSpaceY / 2.0f;

            for (int x = 0; x < gameGridData.GridWidth; x++)
            {
                _count++;
                
                for (int y = 0; y < gameGridData.GridHeight; y++)
                {
                    float posX = x * gameGridData.CardSpaceX - gridCenterX;
                    float posY = y * gameGridData.CardSpaceY - gridCenterY;

                    var newTile = Instantiate(tile, new Vector3(posX, posY, 0), Quaternion.identity);
                    newTile.transform.SetParent(this.transform);
                    newTile.SetGridPosition(new Vector2Int(x, y));
                }
            }
            
            float offset = _count *4.025f;
            
            transform.position = new Vector3(transform.position.x, transform.position.y +offset, transform.position.z);
        }
    }
}