using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame1.Classes.Pieces
{
	public class clsLPiece : clsPiece
	{
		public clsLPiece()
		{
			this.Grid_Piece_Orientation = new bool[4, 4]
			{
			{ false , false,  true, false },
			{ false , false,  true, false },
			{ false , false,  true, false },
			{ false , false , true, true  }
				};

			this.Type = PieceType.LPiece;
			this.Rotation_State = 0;
		}

		
	}
}
