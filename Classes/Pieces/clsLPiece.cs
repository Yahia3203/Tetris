using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame.Classes.Pieces
{
	public class clsLPiece : clsPiece
	{
		public clsLPiece()
		{
			this.GridPieceOrientation = new bool[4, 4]
			{
			{ false , false,  true, false },
			{ false , false,  true, false },
			{ false , false,  true, false },
			{ false , false , true, true  }
				};

			this.Type = PieceType.LPiece;
			this.RotationState = 0;
		}

		
	}
}
