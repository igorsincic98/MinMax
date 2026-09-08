using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
    [Header ("Piece")]

    [SerializeField] private Tilemap _tilemap;
    [SerializeField] private int _size;
    [SerializeField] private Tile _blackTile;
    [SerializeField] private Tile _whiteTile;

    [SerializeField] private Tile[,] _tiles;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        _tiles = new Tile[,]
        {
            { _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile },
            { _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile },
            { _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile },
            { _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile },
            { _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile },
            { _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile },
            { _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile },
            { _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile, _whiteTile, _blackTile }
        };

    }
    
    void DisplayPieces()
    {
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {
                Piece piece = _pieces[i, j];
                if (piece != null) _pieceTilemap.SetTile(new Vector3Int (i, j, 0), piece.Tile);
            }  
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}