using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame.Classes.Pieces
{
	internal class clsZPiece : clsPiece
	{
		public clsZPiece()
		{
			this.GridPieceOrientation = new bool[4, 4]{
			{ false , true,  true, false },
			{ false , false,  true, true },
			{ false , false,  false, false },
			{ false , false ,  false, false }
										};
			this.Type = PieceType.JPiece;
			this.RotationState = 0;
		}

	
	}
}
