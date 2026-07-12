using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame1.Classes.Pieces
{
	public class clsSPiece : clsPiece
	{
		public clsSPiece()
		{
			this.GridPieceOrientation = new bool[4, 4]{
			{ false , false,  true, true },
			{ false , true,  true, false },
			{ false , false,  false, false },
			{ false , false ,  false, false }
										};
			this.Type = PieceType.SPiece;
			this.RotationState = 0;
		}


		
	}
}
