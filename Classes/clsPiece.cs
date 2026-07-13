using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using TetrisGame.Classes.Pieces;

namespace TetrisGame.Classes
{
	public class clsPiece
	{
		public enum PieceType
		{
			IPiece, JPiece, LPiece, OPiece, SPiece, TPiece, ZPiece
		}
		public PieceType Type { get; protected set; }

		public bool[,] GridPieceOrientation { get; protected set; }
		public int RotationState { get; protected set; }

		public Vector2 positiononboard = new Vector2(0, 0);
		public int Row { get; protected set; }
		public int Col { get; protected set; }

		public clsPiece() { }
		public clsPiece(PieceType type, int startRow, int startCol)
		{
	
			Type = type;
			Row = startRow;
			Col = startCol;
			RotationState = 0;
			positiononboard = new Vector2(0, 0); // position on board will have to start from the middle of the boar
		}
		private clsPiece(PieceType type, int row, int col, int rotation)
		{
			Type = type;
			Row = row;
			Col = col;
			RotationState = rotation;
			positiononboard = new Vector2(0, 0); // position on board will have to start from the middle of the board 


		}	
	//this function rotates the matrix of each piece by 90 degrees from starting position
		public void RotatePiece()
		{
			int n = 4;
			// Transpose
			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					bool temp = GridPieceOrientation[i, j];
					GridPieceOrientation[i, j] = GridPieceOrientation[j, i];
					GridPieceOrientation[j, i] = temp;
				}
			}

			// Reverse each row
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n / 2; j++)
				{
					bool temp = GridPieceOrientation[i, j];
					GridPieceOrientation[i, j] = GridPieceOrientation[i, n - 1 - j];
					GridPieceOrientation[i, n - 1 - j] = temp;
				}
			}
			RotationState = (RotationState + 1) % 4;
		}

		//this function tries a move on a copy of the piece first
		public clsPiece TryMove()
		{
			return new clsPiece(Type, Row, Col, RotationState);
		}

		
		
		// move a piece (will be applied in another area)
		//left is Move(0, -1), right is Move(0, 1), soft drop is Move(1, 0).
		public void Move(int rowDelta, int colDelta)
		{
			Row += rowDelta;
			Col += colDelta;
		}




	}
}
