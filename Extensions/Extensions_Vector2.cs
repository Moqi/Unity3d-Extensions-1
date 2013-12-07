using UnityEngine;
using System.Collections;

public static class Extensions_Vector2 
{
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Converts a Vector2 into a Vector3 by adding a 0.0 to the Z.
	/// </summary>
	/// <returns>
	/// The vector3.
	/// </returns>
	/// <param name='aVector'>
	/// A vector.
	/// </param>
	public static Vector3 ToVector3(this Vector2 aVector)
	{
		return new Vector3(aVector.x, aVector.y, 0.0f); 	
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	///  Converts a Vector2 into a Vector3 by adding a value to the Z.
	/// </summary>
	/// <returns>
	/// The vector3.
	/// </returns>
	/// <param name='aVector'>
	/// A vector.
	/// </param>
	/// <param name='ZValue'>
	/// The value to set Z too. 
	/// </param>
	public static Vector3 ToVector3(this Vector2 aVector, float ZValue)
	{
		return new Vector3(aVector.x, aVector.y, ZValue); 	
	}
}
