using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Pieces
{
    public class Knight : Piece
    {
        public override GameObject GameObject => Color == PieceColor.White ? GameManager.Instance.WhiteKnightTile : GameManager.Instance.BlackKnightTile;
        public override List<Vector2Int> GetMovements(Piece[,] pieces)
        {
            List<Vector2Int> movements = new List<Vector2Int>();

            /*movements.Add(new Vector2Int(-2, 1));
            movements.Add(new Vector2Int(-2, -1));
            movements.Add(new Vector2Int(-1, -2));
            movements.Add(new Vector2Int(-1, 2));
            movements.Add(new Vector2Int(1, 2));
            movements.Add(new Vector2Int(1, -2));
            movements.Add(new Vector2Int(2, -1));
            movements.Add(new Vector2Int(2, 1));*/

            for (int i = Position.x - 2; i < 3; i++)
            {
                for (int j = Position.y - 2; j < 3; j++)
                {
                    Piece otherPiece = pieces[i, j];
                    if (otherPiece != null && otherPiece.Color == Color) continue;
                    if (i - j == 3 || i - j == 1 || i - j == -1 || i - j == -3)
                    {
                        movements.Add(new Vector2Int(i, j));
                    }
                    if (otherPiece != null && otherPiece.Color == Color) continue;
                }
            }


            return movements;

        }

        public Knight(PieceColor color) : base(color) { }
    }
}