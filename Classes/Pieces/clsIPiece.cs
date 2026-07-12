using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TetrisGame1.Classes.Pieces
{
	public class clsIPiece : clsPiece
	{
		public clsIPiece() {
			this.Grid_Piece_Orientation = new bool[4, 4]{
			{ false, true,  false, false },
			{ false, true,  false, false },
			{ false, true,  false, false },
			{ false, true,  false, false }
										};
			this.Type = PieceType.IPiece;
			this.Rotation_State = 0;
		}

		
	}
}
