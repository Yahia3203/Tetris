using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisGame1.Classes.Pieces
{
	public class clsTpiece : clsPiece
	{
	public  clsTpiece(){ 
	  
	this.Grid_Piece_Orientation = new bool[4, 4]{


			{ true , true, true,false },
			{ false ,true, false,false },
			{ false ,false,false,false },
			{ false ,false ,false,false }
		};
			this.Type = PieceType.JPiece;
			this.Rotation_State = 0;
		}
	

		
	}
}
