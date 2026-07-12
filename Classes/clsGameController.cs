using System;
using System.Collections.Generic;
using System.Text;
using TetrisGame.Classes.Pieces;

namespace TetrisGame.Classes
{
	public class clsGameController
	{
		public enum GameState
		{
			PLAYING,
			PAUSED,
			GAME_FINISHED
		}
		public GameState state {  get; set; }
		public clsPiece CurrentPiece { get; set;}
		public clsPiece NextPiece { get; set; }
        static clsBoard board = new clsBoard();
        public clsGameController() { 
			
			state = GameState.PLAYING;
			CurrentPiece = GenerateRandomPiece();
			NextPiece = GenerateRandomPiece();

		}

		public clsPiece GenerateRandomPiece()
		{
			Random r = new Random();
			int number = r.Next(1,8);
			switch (number)
			{
				case 1:
					return new clsIPiece();break;
				case 2:
					return new clsJPiece();break;
				case 3:
					return new clsLPiece();break;
                case 4:
					return new clsOPiece();break;
				case 5:
					return new clsSPiece();break;
				case 6:
					return new clsTPiece();break;
				case 7:
					return new clsZPiece();break;

			}
			return new clsIPiece();
			
		}
		public void Tick()
		{
			if (state == GameState.PLAYING)
			{
				if (CurrentPiece.TryMove())
				{
					CurrentPiece.Move();
				}
				else
				{
					board.LockPiece(CurrentPiece);
					CurrentPiece = NextPiece;
					NextPiece = GenerateRandomPiece();
				}
			}
			else if (state == GameState.)
		}

	}
}
