using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Pieces
{
    public class Bishop : Piece
    {
        public override Tile Tile => Color == PieceColor.White
            ? GameManager.Instance.WhiteBishopTile
            : GameManager.Instance.BlackBishopTile;

        public override List<Vector2Int> GetMovements()
        {
            List<Vector2Int> movements = new List<Vector2Int>();

            movements.Add(new Vector2Int(1, 1));
            movements.Add(new Vector2Int(2, 2));
            movements.Add(new Vector2Int(3, 3));
            movements.Add(new Vector2Int(4, 4));
            movements.Add(new Vector2Int(5, 5));
            movements.Add(new Vector2Int(6, 6));
            movements.Add(new Vector2Int(7, 7));
            movements.Add(new Vector2Int(1, -1));
            movements.Add(new Vector2Int(2, -2));
            movements.Add(new Vector2Int(3, -3));
            movements.Add(new Vector2Int(4, -4));
            movements.Add(new Vector2Int(5, -5));
            movements.Add(new Vector2Int(6, -6));
            movements.Add(new Vector2Int(7, -7));
            movements.Add(new Vector2Int(-1, 1));
            movements.Add(new Vector2Int(-2, 2));
            movements.Add(new Vector2Int(-3, 3));
            movements.Add(new Vector2Int(-4, 4));
            movements.Add(new Vector2Int(-5, 5));
            movements.Add(new Vector2Int(-6, 6));
            movements.Add(new Vector2Int(-7, 7));
            movements.Add(new Vector2Int(-1, -1));
            movements.Add(new Vector2Int(-2, -2));
            movements.Add(new Vector2Int(-3, -3));
            movements.Add(new Vector2Int(-4, -4));
            movements.Add(new Vector2Int(-5, -5));
            movements.Add(new Vector2Int(-6, -6));
            movements.Add(new Vector2Int(-7, -7));




            return movements;
                
        }

        public Bishop(PieceColor color) : base(color) { }

    }
}