using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Pieces
{
    public class King : Piece
    {
        public override Tile Tile => Color == PieceColor.White ? GameManager.Instance.WhiteKingTile : GameManager.Instance.BlackKingTile;
        public override List<Vector2Int> GetMovements()
        {
            List<Vector2Int> movements = new List<Vector2Int>();

            movements.Add(new Vector2Int(-1, -1));
            movements.Add(new Vector2Int(-1, 0));
            movements.Add(new Vector2Int(-1, 1));
            movements.Add(new Vector2Int(0, -1));
            movements.Add(new Vector2Int(0, 1));
            movements.Add(new Vector2Int(1, -1));
            movements.Add(new Vector2Int(1, 0));
            movements.Add(new Vector2Int(1, 1));

            return movements;
        }

        public King(PieceColor color) : base(color) { }
    }
}