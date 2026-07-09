using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace TetrisGame1.Classes
{
	public abstract class clsPiece
	{
		public enum PieceType
		{
			IPiece, JPiece, LPiece, OPiece, SPiece, TPiece, ZPiece
		}
		public PieceType Type { get; protected set; }
		public bool[,] GridPieceOrientation { get;  set;}
		public int RotationState{ get; protected set; }
		Vector2 positiononboard = new Vector2(0,0);



		
		public  bool[,] GetOccupiedCells(){
			 
		}
		public abstract void RotatePiece();

	}
}
