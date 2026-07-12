using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame.Classes
{
	public class clsBoard
	{
		public const int Columns = 10;
		public const int Rows = 20;

		private bool[,] grid = new bool[Rows, Columns];
		
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

		public bool IsCellOccupied(int row, int col)
		{
			if (!IsInsideBounds(row, col))
				return true;

			return grid[row, col] != false;
		}

        //will improve this later to check if the piece can be placed in the board
        public bool CanPlacePiece(clsPiece piece)
        {
            int boardRow = (int)piece.positiononboard.Y;
            int boardCol = (int)piece.positiononboard.X;

            for (int pieceRow = 0; pieceRow < 4; pieceRow++)
            {
                for (int pieceCol = 0; pieceCol < 4; pieceCol++)
                {
                    if (!piece.GridPieceOrientation[pieceRow, pieceCol])
                        continue;

                    int row = boardRow + pieceRow;
                    int col = boardCol + pieceCol;

                    if (row < 0 || row >= Rows ||
                        col < 0 || col >= Columns)
                    {
                        return false;
                    }

                    if (IsCellOccupied(row, col))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

		public bool LockPiece(clsPiece piece)
		{
			if (CanPlacePiece(piece))
			{
				int boardRow = (int)piece.positiononboard.Y;
				int boardCol = (int)piece.positiononboard.X;
				for (int pieceRow = 0; pieceRow < 4; pieceRow++)
				{
					for (int pieceCol = 0; pieceCol < 4; pieceCol++)
					{
						if (!piece.GridPieceOrientation[pieceRow, pieceCol])
							continue;

						int row = boardRow + pieceRow;
						int col = boardCol + pieceCol;
						grid[row,col] = true;						
					}
					return true;

				}

			}
			return false;
		}

		public void ClearLine(int row)
		{ 
			for (int col = 0; col < Columns; col++)
			{
				grid[row, col] = false; // Clear the line by setting all cells to 0
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
				grid[0, c] = false;
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
					if (grid[row, col] == false){

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
					grid[row, col] = false; 
				}
			}
		}



	}
}

