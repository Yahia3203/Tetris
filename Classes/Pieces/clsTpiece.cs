using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame.Classes.Pieces
{
	public class clsTPiece : clsPiece
	{
	public  clsTPiece(){ 
	  
	this.GridPieceOrientation = new bool[4, 4]{


			{ true , true, true,false },
			{ false ,true, false,false },
			{ false ,false,false,false },
			{ false ,false ,false,false }
		};
			this.Type = PieceType.JPiece;
			this.RotationState = 0;
		}
	

		
	}
}
