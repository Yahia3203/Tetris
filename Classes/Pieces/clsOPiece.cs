using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame1.Classes.Pieces
{
	internal class clsOPiece : clsPiece
	{
		public clsOPiece()
		{
			this.GridPieceOrientation = new bool[4, 4]{
			{ true ,  true,  false, false },
			{ true ,  true,   false, false },
			{ false , false,  false, false },
			{ false , false , false, false }
										};
			this.Type = PieceType.OPiece;
			this.RotationState = 0;
		}
	

		public override void RotatePiece()
		{
			throw new NotImplementedException();
		}
	}
}
