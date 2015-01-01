
/*
 * Emonides Pierre-Emmanuel
 */

using UnityEngine;
using System.Collections;

public class Pair<U, V> {

	private	U 	_first;
	private V	_second;

	public 	U 	First{get{return this._first;} set{this._first = value;}}
	public 	V 	Second{get{return this._second;} set{this._second = value;}}

	public	Pair(U first, V second)
	{
		this._first = first;
		this._second = second;
	}
}
