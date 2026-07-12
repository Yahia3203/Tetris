using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame1.Classes.Pieces
{
	public class clsZpiece : clsPiece
	{
		public clsZpiece()
		{
			this.Grid_Piece_Orientation = new bool[4, 4]{
			{ false , true,  true, false },
			{ false , false,  true, true },
			{ false , false,  false, false },
			{ false , false ,  false, false }
										};
			this.Type = PieceType.JPiece;
			this.Rotation_State = 0;
		}

		
	}
}
