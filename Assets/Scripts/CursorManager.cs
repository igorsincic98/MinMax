using System;
using Pieces;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    private float _pieceDisplayScale = 0.5f;
    private Color _initialBlackTile = Color.sandyBrown;
    private Color _initialWhiteTile = Color.saddleBrown;
    private Rook _rook;
    private Bishop _bishop;
    private Knight _knight;
    private Pawn _pawn;
    private King _king;
    private Queen _queen;
    private Piece[,] _piece;
    public string _type;

    private void Start()
    {
        _piece = GetComponent<Piece[,]>();
    }

    private void OnMouseEnter()
    {
        Debug.Log("Mouse Enter");
        GetComponent<Transform>().transform.localScale += new Vector3(_pieceDisplayScale, _pieceDisplayScale, 0);
    }

    private void OnMouseExit()
    {
        Debug.Log("Mouse Exit");
        GetComponent<Transform>().transform.localScale -= new Vector3(_pieceDisplayScale,_pieceDisplayScale, 0);
        
    }
}