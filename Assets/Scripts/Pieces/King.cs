using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Pieces
{
    public class King : Piece
    {
        public override GameObject GameObject => Color == PieceColor.White ? GameManager.Instance.WhiteKingTile : GameManager.Instance.BlackKingTile;
        public override List<Vector2Int> GetMovements(Piece[,] pieces)
        {
            List<Vector2Int> movements = new List<Vector2Int>();

            for (int i = Position.x - 1; i < 2; i++)
            {
                for (int j = Position.y - 1; j < 2; j++)
                {
                    Vector2Int movement = new Vector2Int(i, j);
                    Piece otherPiece = pieces[movement.x, movement.y];
                    if (otherPiece != null && otherPiece.Color == Color) break;
                    movements.Add(movement);
                    if (otherPiece != null && otherPiece.Color != Color) break;
                }
            }

            return movements;
        }

        public King(PieceColor color) : base(color) { }
    }
}