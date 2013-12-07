using UnityEngine;
using System.Collections;
using System;

public static class AudioSourceExtension
{
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Sets the audio to a new clip and plays it.
	/// </summary>
	/// <param name='aAudioClip'>
	/// A audio clip.
	/// </param>
	public static void playClip( this AudioSource aAudioSource, AudioClip aAudioClip )
	{
		aAudioSource.clip = aAudioClip;
		aAudioSource.Play();
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Sets the audio clip and plays its. Once this is complete it calls the action.
	/// </summary>
	/// <returns>
	/// The clip.
	/// </returns>
	/// <param name='aAudioSource'>
	/// A audio source.
	/// </param>
	/// <param name='aAudioClip'>
	/// A audio clip.
	/// </param>
	/// <param name='onComplete'>
	/// On complete action. Syntax " () => { 'the stuff to do' } "
	/// </param>
	public static IEnumerator playClip ( this AudioSource aAudioSource, AudioClip aAudioClip, Action onComplete )
	{
		aAudioSource.playClip( aAudioClip ); 
		while( aAudioSource.isPlaying )
			yield return null;
		onComplete(); 
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Plays the random clip for a array provided.
	/// </summary>
	/// <param name='aClipsArray'>
	/// An array of audio clips.
	/// </param>
	public static void playRandomClip( this AudioSource aAudioSource, AudioClip[] aClipsArray )
	{
		int clipIndex = UnityEngine.Random.Range(0, aClipsArray.Length ); 	
		aAudioSource.playClip( aClipsArray[clipIndex] );
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Fades out an audio clip over time. Once the fadeout has been complete the action is called. 
	/// </summary>
	/// <param name='audioClip'>
	/// The audio clip you want to play
	/// </param>
	/// <param name='aDuration'>
	/// How long to fade out for
	/// </param>
	/// <param name='onComplete'>
	///  On complete action. Syntax " () => { 'the stuff to do' } ". Null also works. 
	/// </param>
	public static IEnumerator fadeOut( this AudioSource aAudioSource, AudioClip aAudioClip, float aDuration, Action onComplete )
	{
		aAudioSource.playClip( aAudioClip ); 
		
		var startingVolume = aAudioSource.volume;
		
		// fade out the volume
		while( aAudioSource.volume > 0.0f )
		{
			aAudioSource.volume -= Time.deltaTime * startingVolume / aDuration;
			yield return null;
		}
		
		// done fading out
		if(onComplete != null )
			onComplete(); 
	}
	
	/// By: Byron Mayne, Nov 2, 2013
	/// <summary>
	/// Fades in an audio clip over time. Once the fadein has been complete the action is called. 
	/// </summary>
	/// <param name='audioClip'>
	/// The audio clip you want to play
	/// </param>
	/// <param name="aFinalVolume">
	/// The volume you want to fadein to. 
	/// </param>
	/// <param name='aDuration'>
	/// How long to fade in for
	/// </param>
	/// <param name='onComplete'>
	///  On complete action. Syntax " () => { 'the stuff to do' } ". Null also works. 
	/// </param>
	public static IEnumerator fadeIn( this AudioSource aAudioSource, AudioClip aAudioClip, float aDuration, float aFinalVolume, Action onComplete )
	{
		aAudioSource.playClip( aAudioClip ); 
		
		// fade out the volume
		while( aAudioSource.volume < aFinalVolume )
		{
			aAudioSource.volume -= Time.deltaTime * aFinalVolume / aDuration;
			yield return null;
		}
		
		// done fading in
		if(onComplete != null )
			onComplete(); 
	}
}
