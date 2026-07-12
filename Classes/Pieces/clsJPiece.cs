using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame1.Classes.Pieces
{
	internal class clsJPiece : clsPiece
	{
		public clsJPiece() {
			this.GridPieceOrientation = new bool[4, 4]{
			{ false , false,  true, false },
			{ false , false,  true, false },
			{ false , false,  true, false },
			{ false , true ,  true, false }
										};
			this.Type = PieceType.JPiece;
			this.RotationState = 0;
		}
        
    }
}
