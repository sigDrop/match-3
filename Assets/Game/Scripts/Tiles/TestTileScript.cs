using UnityEngine;

public class TestTileScript : MonoBehaviour
{
    [SerializeField] private TileType tileType;
    
    [SerializeField] private int _xIndex;
    [SerializeField] private int _yIndex;

    public bool isMatched;
    private Vector2 _currentPos;
    private Vector2 _targetPos;

    public bool isMoving;

    public TestTileScript(int _x, int _y)
    {
        _xIndex = _x;
        _yIndex = _y;
    }
}

public enum TileType
{
    Tile1,
    Tile2,
    Tile3,
    Tile4,
    Tile5
}
