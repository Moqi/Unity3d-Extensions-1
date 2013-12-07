using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public static class Extensions_Transfrom
{
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Gets a component of any type in family the objects family tree. It will look over all
	/// childern, grandchildren, ext and find the component and return it. This will look
	/// over a max of 100 children. 
	/// </summary>
	/// <returns>
	/// The component in family tree.
	/// </returns>
	/// <param name='gameObject'>
	/// Game object.
	/// </param>
	/// <typeparam name='T'>
	/// The 1st type parameter.
	/// </typeparam>
	public static T GetComponentInFamilyTree<T>(this Transform aTransform)
    where T: Component
	{
		//First we make a list of all the members of the family
	    List<Transform> family = new List<Transform>();
	
		//Now we add the parents Transform
		family.Add(aTransform);
		
		//Now we loop over the family list.
		for(int i = 0, MaxLoops = 100; i < family.Count || i >= MaxLoops; i++)
		{
			//Now we store a ref for the current child we are looking at.
			Transform currentChild = family[i];
			
			//Do they have the component we are looking for?
			if( currentChild.GetComponent<T>() != null )
				return currentChild.GetComponent<T>(); // Yes they do now lets return it
			
			//Lets all all their children to our loop
			family.AddRange( currentChild.transform.GetComponentsInChildren<Transform>());
			
			//We also want to jump ahead 1 space since we are adding this objects transfrom twice (InChildern addes parent)
			i++; 
			
		}
		
		//We did not find anything so lets return null
		return null;
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Gets the component in ancestors. It keeps checking transforms parent for the component until its null. 
	/// </summary>
	/// <returns>
	/// The component in ancestors.
	/// </returns>
	/// <param name='gameObject'>
	/// Game object.
	/// </param>
	/// <typeparam name='T'>
	/// The 1st type parameter.
	/// </typeparam>
	public static T GetComponentInAncestors<T>(this Transform aTransform)
	where T: Component
	{
		//First we make a list of all the members of the family
	    List<Transform> family = new List<Transform>();
		
		//Now we add the parents Transform
		family.Add(aTransform);
		
		//Now we loop over the family list.
		for(int i = 0, MaxLoops = 100; i < family.Count || i >= MaxLoops; i++)
		{
			//Now we store a ref for the current child we are looking at.
			Transform currentChild = family[i];
			
			//Do they have the component we are looking for?
			if( currentChild.GetComponent<T>() != null )
				return currentChild.GetComponent<T>(); // Yes they do now lets return it
			
			//Lets all all their children to our loop
			if( currentChild.transform.parent != null )
				family.Add( currentChild.transform.parent );
			else
				return default(T); //We ran out of parents to look into. 
		}
		
		//We did not find anything so lets return null
		return default(T);
	}
}
