using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Pieces
{
    public class Rook : Piece
    {

        public override Tile Tile => Color == PieceColor.White ? GameManager.Instance.WhiteRookTile : GameManager.Instance.BlackRookTile;
        public Rook(PieceColor color) : base(color) { }
        public override List<Vector2Int> GetMovements(Piece[,] pieces)
        {
            List<Vector2Int> movements = new List<Vector2Int>();

            // Right Movements
            
            for (int i = Position.x + 1; i < 8; i++)
            {
                Vector2Int movement = new Vector2Int(i, Position.y);
                Piece otherPiece = pieces[movement.x, movement.y];
                if (otherPiece != null && otherPiece.Color == Color)
                    break;
                movements.Add(movement);
                if (otherPiece != null && otherPiece.Color != Color) break;
            }
            // Left Movements
            for (int i = Position.x - 1; i >= 0; i--)
            {
                Vector2Int movement = new Vector2Int(i, Position.y);
                Piece otherPiece = pieces[movement.x, movement.y];
                if (otherPiece != null && otherPiece.Color == Color)
                    break;
                movements.Add(movement);
                if (otherPiece != null && otherPiece.Color != Color) break;
            }
            //Down Movements
            for (int i = Position.y - 1; i >= 0; i--)
            {
                Vector2Int movement = new Vector2Int(Position.x, i);
                Piece otherPiece = pieces[movement.x, movement.y];
                if (otherPiece != null && otherPiece.Color == Color)
                    break;
                movements.Add(movement);
                if (otherPiece != null && otherPiece.Color != Color) break;
            }
            //Up Movements
            for (int i = Position.y + 1; i < 8; i++)
            {
                Vector2Int movement = new Vector2Int(Position.x, i);
                Piece otherPiece = pieces[movement.x, movement.y];
                if (otherPiece != null && otherPiece.Color == Color)
                    break;
                movements.Add(movement);
                if (otherPiece != null && otherPiece.Color != Color) break;
            }

            return movements;
        }

    }
}