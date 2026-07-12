using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace TetrisGame1.Classes
{
	public abstract class clsPiece
	{
		public enum PieceType
		{
			IPiece, JPiece, LPiece, OPiece, SPiece, TPiece, ZPiece
		}
		public PieceType Type { get; protected set; }
<<<<<<< Updated upstream
		public bool[,] GridPieceOrientation { get;  set;}
		public int RotationState{ get; protected set; }
		public Vector2 positiononboard = new Vector2(0,0);



		
		public  bool[,] GetOccupiedCells(){
			 
		}
		public abstract void RotatePiece();
=======
		public bool[,] GridPieceOrientation { get; protected set; }
		public int RotationState { get; protected set; }

		public Vector2 position_onboard = new Vector2(0, 0);
		public int Row { get; protected set; }
		public int Col { get; protected set; }

		public clsPiece() { }
		public clsPiece(PieceType type, int startRow, int startCol)
		{
			Type = type;
			Row = startRow;
			Col = startCol;
			RotationState = 0;
			position_onboard = new Vector2(0, 0);
		}
		private clsPiece(PieceType type, int row, int col, int rotation)
		{
			Type = type;
			Row = row;
			Col = col;
			RotationState = rotation;
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
		public void RotatePiece()
		{
			int n = 4;
			// Transpose
			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					bool temp = grid[i, j];
					grid[i, j] = grid[j, i];
					grid[j, i] = temp;
				}
			}
			
			// Reverse each row
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n / 2; j++)
				{
					bool temp = grid[i, j];
					grid[i, j] = grid[i, n - 1 - j];
					grid[i, n - 1 - j] = temp;
				}
			}
            RotationState = (RotationState + 1) % 4;
        }

		//this function tries a move on a copy of the piece first and only apply it if Board.CanPlace says it's legal
		public void TryMove(Vector2 position_onboard)
		{

		}

		// move a piece
		public void Move(Vector2 position_onboard)
		{


		}




>>>>>>> Stashed changes

	}
}
