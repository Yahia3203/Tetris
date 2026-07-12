using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace TetrisGame1.Classes
{
	public abstract class clsPiece : clsBoard
	{
		public enum PieceType
		{
			IPiece, JPiece, LPiece, OPiece, SPiece, TPiece, ZPiece
		}
		public PieceType Type { get; protected set; }
		public bool[,] Grid_Piece_Orientation { get; protected set; }
		public int Rotation_State { get; protected set; }

		Vector2 position_onboard = new Vector2(0, 0);
		public int Row { get; protected set; }
		public int Col { get; protected set; }

		public clsPiece() { }
		public clsPiece(PieceType type, int startRow, int startCol)
		{
			Type = type;
			Row = startRow;
			Col = startCol;
			Rotation_State = 0;
			position_onboard = new Vector2(0, 0);
		}
		private clsPiece(PieceType type, int row, int col, int rotation)
		{
			Type = type;
			Row = row;
			Col = col;
			Rotation_State = rotation;
			position_onboard = new Vector2(0, 0);


		}
		//returns the actual occupied cells for the current position and rotation
		public void Getcells(Vector2 position_onboard, int Rotation_State)
		{
			int Occipied_Cells = 0;
			for (int i = 0; i <	Col; i++)
			{
			for (int j = 0; j < Row; j++)
			{


			}

		}

	}

		//this function rotates the matrix of each piece by 90 degrees from starting position
		public void RotatePiece(int Rotation_State)
		{
			int n = 4;
			// Transpose
			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					int temp = grid[i, j];
					grid[i, j] = grid[j, i];
					grid[j, i] = temp;
				}
			}
			Rotation_State++;


			// Reverse each row
			/*for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n / 2; j++)
				{
					int temp = grid[i, j];
					grid[i, j] = grid[i, n - 1 - j];
					grid[i, n - 1 - j] = temp;
				}
			}*/
		}

		//this function tries a move on a copy of the piece first and only apply it if Board.CanPlace says it's legal
		public void TryMove(Vector2 position_onboard)
		{

		}

		// move a piece
		public void Move(Vector2 position_onboard)
		{


		}





	}
}
