using UnityEngine;
using System.Collections;

public static class Extensions_Color
{
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Edit the colors alpha value without changing the color.
	/// </summary>
	/// <returns>
	/// The alpha.
	/// </returns>
	/// <param name='color'>
	/// Color.
	/// </param>
	/// <param name='alpha'>
	/// Alpha.
	/// </param>
	public static Color WithAlpha(this Color color, float alpha)
	{
   		return new Color(color.r, color.g, color.b, alpha);
	}
}
