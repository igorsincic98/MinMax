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

        public override List<Vector2Int> GetMovements(Piece[,] pieces)
        {
            List<Vector2Int> movements = new List<Vector2Int>();
            //Right/Up Movements
            for (int i = Position.x + 1; i < 8; i++)
            {
                for (int y = Position.y + 1; y < 8; y++)
                {
                    Vector2Int movement = new Vector2Int(i, y);
                    Piece otherPiece = pieces[movement.x, movement.y];
                    if (otherPiece != null && otherPiece.Color == Color)
                        break;
                    movements.Add(movement);
                    if (otherPiece != null && otherPiece.Color != Color) break;
                }
            }
            //Right/Down Movements
            for (int i = Position.x + 1; i < 8; i++)
            {
                for (int y = Position.y - 1; y >= 0; y--)
                {
                    Vector2Int movement = new Vector2Int(i, y);
                    Piece otherPiece = pieces[movement.x, movement.y];
                    if (otherPiece != null && otherPiece.Color == Color)
                        break;
                    movements.Add(movement);
                    if (otherPiece != null && otherPiece.Color != Color) break;
                }
            }
            //Left/Up Movements
            for (int i = Position.x - 1; i >= 0; i--)
            {
                for (int y = Position.y + 1; y < 8; y++)
                {
                    Vector2Int movement = new Vector2Int(i, y);
                    Piece otherPiece = pieces[movement.x, movement.y];
                    if (otherPiece != null && otherPiece.Color == Color)
                        break;
                    movements.Add(movement);
                    if (otherPiece != null && otherPiece.Color != Color) break;
                }
            }
            //Left/Down Movement
            for (int i = Position.x - 1; i >= 0; i--)
            {
                for (int y = Position.y - 1; y >= 0; y--)
                {
                    Vector2Int movement = new Vector2Int(i, y);
                    Piece otherPiece = pieces[movement.x, movement.y];
                    if (otherPiece != null && otherPiece.Color == Color)
                        break;
                    movements.Add(movement);
                    if (otherPiece != null && otherPiece.Color != Color) break;
                }
            }

            




            return movements;
                
        }

        public Bishop(PieceColor color) : base(color) { }

    }
}