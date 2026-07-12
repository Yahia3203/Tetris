using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame1.Classes.Pieces
{
	internal class clsKKKP : clsPiece
	{
		public clsKKKP()
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
