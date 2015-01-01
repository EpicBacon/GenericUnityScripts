using UnityEngine;
using System.Collections;

public class IntVector2 {

	
	private int _x;
	private int _y;
	
	public int x { get { return this._x; } set { this._x = value; } }
	public int y { get { return this._y; } set { this._y = value; } }

 		
	public IntVector2(int x, int y)
	{
		_x = x;
		_y = y;
	}
	
    int sqrMagnitude
    {
        get { return _x * _x + _y * _y; }
    }
	
	
}
