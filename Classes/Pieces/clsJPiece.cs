using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame1.Classes.Pieces
{
	public class clsJPiece : clsPiece
	{
		public clsJPiece() {
			this.Grid_Piece_Orientation = new bool[4, 4]{
			{ false , false,  true, false },
			{ false , false,  true, false },
			{ false , false,  true, false },
			{ false , true ,  true, false }
										};
			this.Type = PieceType.JPiece;
			this.Rotation_State = 0;
		}
		
	}
}
