using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Pieces
{
    public class Knight : Piece
    {
        public override Tile Tile => Color == PieceColor.White ? GameManager.Instance.WhiteKnightTile : GameManager.Instance.BlackKnightTile;
        public override List<Vector2Int> GetMovements(Piece[,] pieces)
        {
            List<Vector2Int> movements = new List<Vector2Int>();

            movements.Add(new Vector2Int(-2, 1));
            movements.Add(new Vector2Int(-2, -1));
            movements.Add(new Vector2Int(-1, -2));
            movements.Add(new Vector2Int(-1, 2));
            movements.Add(new Vector2Int(1, 2));
            movements.Add(new Vector2Int(1, -2));
            movements.Add(new Vector2Int(2, -1));
            movements.Add(new Vector2Int(2, 1));


            return movements;

        }

        public Knight(PieceColor color) : base(color) { }
    }
}