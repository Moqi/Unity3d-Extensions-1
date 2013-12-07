using UnityEngine;
using System.Collections;
using System;
public static class Extensions_Vector3
{
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Returns a Vector2 with only the X and Y values
	/// </summary>
	/// <param name='aVector'>
	/// X and Y Values
	/// </param>
	public static Vector2 xy( this Vector3 aVector)
	{
		return new Vector2(aVector.x, aVector.y); 
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Returns a Vector2 with only the Y and Z values
	/// </summary>
	/// <param name='aVector'>
	/// Z and Y Values
	/// </param>
	public static Vector2 yz( this Vector3 aVector)
	{
		return new Vector2(aVector.y, aVector.z); 
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Returns a Vector2 with only the Y and Z values
	/// </summary>
	/// <param name='aVector'>
	/// Y and Z Values
	/// </param>
	public static Vector2 xz( this Vector3 aVector)
	{
		return new Vector2(aVector.x, aVector.z); 
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Returns a Vector3 with the X value zeroed out.
	/// </summary>
	/// <returns>
	/// Vector( 0.0f, Y, Z);
	/// </returns>
	/// <param name='aVector'>
	/// A vector.
	/// </param>
	public static Vector3 IgnoreX(this Vector3 aVector)
	{
		aVector.x = 0;
		return aVector; 
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Returns a Vector3 with the Y value zeroed out.
	/// </summary>
	/// <returns>
	/// Vector( X, 0.0f, Z);
	/// </returns>
	/// <param name='aVector'>
	/// A vector.
	/// </param>
	public static Vector3 IgnoreY(this Vector3 aVector)
	{
		aVector.y = 0;
		return aVector; 
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Returns a Vector3 with the Z value zeroed out.
	/// </summary>
	/// <returns>
	/// Vector( X, Y, 0.0f);
	/// </returns>
	/// <param name='aVector'>
	/// A vector.
	/// </param>
	public static Vector3 IgnoreZ(this Vector3 aVector)
	{
		aVector.z = 0;
		return aVector; 
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Gets the distance between two vectors ignoring the Z values
	/// </summary>
	/// <returns>
	/// The Distance
	/// </returns>
	/// <param name='aVector'>
	/// A second vector.
	/// </param>
	/// <param name='aSecondVector'>
	/// A second vector.
	/// </param>
	public static float DistanceXY(this Vector3 aVector, Vector3 aSecondVector)
	{
		aVector.z = 0;
		aSecondVector.z = 0;
		
		return Vector3.Distance(aVector, aSecondVector); 
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Gets the distance between two vectors ignoring the X values
	/// </summary>
	/// <returns>
	/// The Distance
	/// </returns>
	/// <param name='aVector'>
	/// A second vector.
	/// </param>
	/// <param name='aSecondVector'>
	/// A second vector.
	/// </param>
	public static float DistanceYZ(this Vector3 aVector, Vector3 aSecondVector)
	{
		aVector.x = 0;
		aSecondVector.x = 0;
		
		return Vector3.Distance(aVector, aSecondVector); 
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Gets the distance between two vectors ignoring the Y values
	/// </summary>
	/// <returns>
	/// The Distance
	/// </returns>
	/// <param name='aVector'>
	/// A second vector.
	/// </param>
	/// <param name='aSecondVector'>
	/// A second vector.
	/// </param>
	public static float DistanceXZ(this Vector3 aVector, Vector3 aSecondVector)
	{
		aVector.y = 0;
		aSecondVector.y = 0;
		
		return Vector3.Distance(aVector, aSecondVector); 
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Returns the same Vector3 but with a new value for X
	/// </summary>
	/// <returns>
	/// The edited Vector3
	/// </returns>
	/// <param name='aVector'>
	/// A vector.
	/// </param>
	/// <param name='newValue'>
	/// The new value to set X too. 
	/// </param>
	public static Vector3 ReplaceX(this Vector3 aVector, float newValue)
	{
		return new Vector3(newValue, aVector.y, aVector.z);
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Returns the same Vector3 but with a new value for Y
	/// </summary>
	/// <returns>
	/// The edited Vector3
	/// </returns>
	/// <param name='aVector'>
	/// A vector.
	/// </param>
	/// <param name='newValue'>
	/// The new value to set Y too. 
	/// </param>
	public static Vector3 ReplaceY(this Vector3 aVector, float newValue)
	{
		return new Vector3(aVector.x, newValue, aVector.z);
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Returns the same Vector3 but with a new value for Z
	/// </summary>
	/// <returns>
	/// The edited Vector3
	/// </returns>
	/// <param name='aVector'>
	/// A vector.
	/// </param>
	/// <param name='newValue'>
	/// The new value to set Z too. 
	/// </param>
	public static Vector3 ReplaceZ(this Vector3 aVector, float newValue)
	{
		return new Vector3(aVector.x, aVector.y, newValue);
	}
	

}

