using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Pieces
{
    public class Queen : Piece
    {
        public override Tile Tile => Color == PieceColor.White ? GameManager.Instance.WhiteQueenTile : GameManager.Instance.BlackQueenTile;
        public override List<Vector2Int> GetMovements()
        {
            List<Vector2Int> movements = new List<Vector2Int> ();

            movements.Add(new Vector2Int(-1, 0));
            movements.Add(new Vector2Int(-2, 0));
            movements.Add(new Vector2Int(-3, 0));
            movements.Add(new Vector2Int(-4, 0));
            movements.Add(new Vector2Int(-5, 0));
            movements.Add(new Vector2Int(-6, 0));
            movements.Add(new Vector2Int(-7, 0));
            movements.Add(new Vector2Int(0, -1));
            movements.Add(new Vector2Int(0, -2));
            movements.Add(new Vector2Int(0, -3));
            movements.Add(new Vector2Int(0, -4));
            movements.Add(new Vector2Int(0, -5));
            movements.Add(new Vector2Int(0, -6));
            movements.Add(new Vector2Int(0, -7));
            movements.Add(new Vector2Int(1, 0));
            movements.Add(new Vector2Int(2, 0));
            movements.Add(new Vector2Int(3, 0));
            movements.Add(new Vector2Int(4, 0));
            movements.Add(new Vector2Int(5, 0));
            movements.Add(new Vector2Int(6, 0));
            movements.Add(new Vector2Int(7, 0));
            movements.Add(new Vector2Int(0, 1));
            movements.Add(new Vector2Int(0, 2));
            movements.Add(new Vector2Int(0, 3));
            movements.Add(new Vector2Int(0, 4));
            movements.Add(new Vector2Int(0, 5));
            movements.Add(new Vector2Int(0, 6));
            movements.Add(new Vector2Int(0, 7));
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

        public Queen(PieceColor color) : base(color) { }
    }
}