namespace Pieces
{
    public class Bishop : Piece
    {
        public override Tile Tile => Color == PieceColor.White
            ? GameManager.Instantiate.WhiteBishopTile
            : GameManager.Instantiate.BlackBishopTile;
        public Bishop(PieceColor color) : base(color){}

    }
}