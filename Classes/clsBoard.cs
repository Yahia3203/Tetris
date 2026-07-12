using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame1.Classes
{
	public class clsBoard
	{
		public const int Columns = 10;
		public const int Rows = 20;

		protected readonly int[,] grid = new int[Rows, Columns];
		public int this[int row, int col] => grid[row, col];
		public int width { get; private set; }
		public int height { get; private set; }

		public clsBoard()
		{
		}
		public clsBoard(int width, int height)
		{
			this.width = width;
			this.height = height;
		}


		public bool IsInsideBounds(int row, int col)
		{
			if (row >= 0 && row < Rows && col >= 0 && col < Columns) { return true; }
			else { return false; }
		}

		public bool GetOccupiedCells(int row, int col)
		{
			if (!IsInsideBounds(row, col))
				return true;

			return grid[row, col] != 0;
		}

		//will improve this later to check if the piece can be placed in the board
		public bool CanPlacePiece(clsPiece piece, int row, int col)
		{
			int cellsOccupied = 0;
			foreach (var cell in piece.GetOccupiedCells(row,col))
			{
				cellsOccupied++;
			}

			if (IsInsideBounds(row, col) && GetOccupiedCells(row, col) == false)
			{
				return true;
			}
			else
			{
				return false;
			}



		}

		public void LockPiece(clsPiece pieces, int row, int col)
		{
			if (CanPlacePiece(pieces, row, col))
			{
				foreach (var cell in pieces.GetOccupiedCells())
				{
					grid[row, col] = 1; // Mark the cell as occupied
				}
			}
			else
			{
				throw new InvalidOperationException("Cannot lock piece at the specified position.");
			}
		}

		public void ClearLine(int row)
		{
			for (int col = 0; col < Columns; col++)
			{
				grid[row, col] = 0; // Clear the line by setting all cells to 0
			}
			// Move all rows above down by one
			for (int r = row; r > 0; r--)
			{
				for (int c = 0; c < Columns; c++)
				{
					grid[r, c] = grid[r - 1, c];
				}
			}
			// Clear the top row
			for (int c = 0; c < Columns; c++)
			{
				grid[0, c] = 0;
			}
		}
		public int ClearCompletedLines()
		{
			int linesCleared = 0;
			for (int row = 0; row < Rows; row++)
			{
				bool isLineComplete = true;
				for (int col = 0; col < Columns; col++)
				{
					if (grid[row, col] == 0)
					{
						isLineComplete = false;
						break;
					}
				}
				if (isLineComplete)
				{
					linesCleared++;
					ClearLine(row);
				}
			}
			return linesCleared;
		}

		public void ClearBoard()
		{
			for (int row = 0; row < Rows; row++)
			{
				for (int col = 0; col < Columns; col++)
				{
					grid[row, col] = 0; 
				}
			}
		}



	}
}

