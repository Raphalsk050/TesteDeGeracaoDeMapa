using UnityEngine;

namespace Code
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private Vector2Int mapSize;
        [SerializeField] private GameObject tile;
        [SerializeField] private GameObject parentTile;
        private GameObject[,] m_TilesInScene;
        
        private void Start()
        {
            m_TilesInScene = new GameObject[mapSize.x,mapSize.y];
            for (int i = 0; i < mapSize.x; i++)
            {
                for (int j = 0; j < mapSize.y; j++)
                {
                    var position = new Vector3(i, j,0);
                    m_TilesInScene[i, j] = Instantiate(tile, position, Quaternion.identity);
                    m_TilesInScene[i, j].transform.parent = parentTile.transform;
                }
            }
        }
    }
}