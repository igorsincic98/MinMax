using System;
using Pieces;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    [Header("Pieces Visual")]
    public GameObject WhitePawnTile;
    public GameObject WhiteRookTile;
    public GameObject WhiteBishopTile;
    public GameObject WhiteKnightTile;
    public GameObject WhiteQueenTile;
    public GameObject WhiteKingTile;

    public GameObject BlackPawnTile;
    public GameObject BlackRookTile;
    public GameObject BlackBishopTile;
    public GameObject BlackKnightTile;
    public GameObject BlackQueenTile;
    public GameObject BlackKingTile;

    [Header("References")]
    
    [SerializeField] private Tilemap _boardTilemap;
    [SerializeField] private Tile _blackTile;
    [SerializeField] private Tile _whiteTile;

    [Header("Parameters")]
    
    [SerializeField] private int _size;
    private Vector3Int _position;

    [SerializeField] private Color _color1;
    [SerializeField] private Color _color2;

    private Piece[,] _pieces = new Piece[8, 8];
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        _position = new Vector3Int(30, -2, 0);
        _pieces = new Piece[,]
        {
            {
                new Rook(PieceColor.White), new Knight(PieceColor.White), new Bishop(PieceColor.White),
                new Queen(PieceColor.White), new King(PieceColor.White), new Bishop(PieceColor.White),
                new Knight(PieceColor.White), new Rook(PieceColor.White)
            },
            {
                new Pawn(PieceColor.White), new Pawn(PieceColor.White), new Pawn(PieceColor.White),
                new Pawn(PieceColor.White), new Pawn(PieceColor.White), new Pawn(PieceColor.White),
                new Pawn(PieceColor.White), new Pawn(PieceColor.White)
            },
            { null, null, null, null, null, null, null, null },
            { null, null, null, null, null, null, null, null },
            { null, null, null, null, null, null, null, null },
            { null, null, null, null, null, null, null, null },
            {
                new Pawn(PieceColor.Black), new Pawn(PieceColor.Black), new Pawn(PieceColor.Black),
                new Pawn(PieceColor.Black), new Pawn(PieceColor.Black), new Pawn(PieceColor.Black),
                new Pawn(PieceColor.Black), new Pawn(PieceColor.Black)
            },
            {
                new Rook(PieceColor.Black), new Knight(PieceColor.Black), new Bishop(PieceColor.Black),
                new Queen(PieceColor.Black), new King(PieceColor.Black), new Bishop(PieceColor.Black),
                new Knight(PieceColor.Black), new Rook(PieceColor.Black)
            }
        };

    }

    private void Start()
    {
        CreateBoard();
    }

    public void CreateBoard()
    {
        _boardTilemap.ClearAllTiles();
        _blackTile.color = Color.sandyBrown;
        _whiteTile.color = Color.saddleBrown;
        for (int j = 0; j < _size; j++)
        {
            _position += new Vector3Int(-32, 4, 0);
            for (int i = 0; i < _size; i++)
            {
                _position += new Vector3Int(4, 0, 0);
                Tile tile = (i + j) % 2 == 0 ? _whiteTile : _blackTile;
                _boardTilemap.SetTile(new Vector3Int(j,i,0), tile);
                Piece piece = _pieces[j, i];
                if (piece != null)
                {
                    GameObject newPiece = Instantiate (piece.GameObject, _position,
                        quaternion.identity, _boardTilemap.transform);
                    newPiece.AddComponent<BoxCollider2D>();
                    newPiece.AddComponent<CursorManager>();
                }
            }
        }
    }


    public void ResetBoard()
    {
        _boardTilemap.ClearAllTiles();
        _blackTile.color = Color.sandyBrown;
        _whiteTile.color = Color.saddleBrown;
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {
                Tile tile = (i + j) % 2 == 0 ? _whiteTile : _blackTile;
                _boardTilemap.SetTile(new Vector3Int(i, j, 0), tile);
            }
        }
    }

    public void UpdateBoard()
    {
        _boardTilemap.ClearAllTiles();
        _blackTile.color = _color1;
        _whiteTile.color = _color2;
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {
                Tile tile = (i + j) % 2 == 0 ? _whiteTile : _blackTile;
                _boardTilemap.SetTile(new Vector3Int(i, j, 0), tile);
            }
        }
    }

    public void DisplayPieceMovement(Piece piece)
    {
    }

    
}