using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Pieces
{
    public abstract class Piece
    {
        public PieceColor Color;
        public abstract Tile Tile { get; }

        public Vector2Int Position;
        protected Piece(PieceColor color)
        {
            this.Color = color;
        }
        public abstract List<Vector2Int> GetMovements(Piece[,] pieces);

        public void PieceCheck (List<Vector2Int> movements, Vector2Int movement, Piece[,] pieces)
        {
            Piece otherPiece = pieces[movement.x, movement.y];
            if (otherPiece != null && otherPiece.Color == Color) return;
            movements.Add(movement);
            if (otherPiece != null && otherPiece.Color != Color) return;
            
        }
    }
}