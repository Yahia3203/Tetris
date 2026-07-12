using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame1.Classes.Pieces
{
	public class clsOPiece : clsPiece
	{
		public clsOPiece()
		{
			this.Grid_Piece_Orientation = new bool[4, 4]{
			{ true ,  true,  false, false },
			{ true ,  true,   false, false },
			{ false , false,  false, false },
			{ false , false , false, false }
										};
			this.Type = PieceType.OPiece;
			this.Rotation_State = 0;
		}
	

		
	}
}
