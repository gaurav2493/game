using System;
using UnityEngine;
using TouchScript.Gestures;

public class DestroyButton : MonoBehaviour {
	
	public String stickTag;
	private GameObject[] gameObjects;
	// Use this for initialization
	private void OnEnable()
	{
		// subscribe to gesture's Tapped event
		GetComponent<TapGesture>().Tapped += tappedHandler;
	}
	
	private void OnDisable()
	{
		// don't forget to unsubscribe
		GetComponent<TapGesture>().Tapped -= tappedHandler;
	}

	private void tappedHandler(object sender, EventArgs e)
	{
		DestroyAllObjects ();
	}

	private void DestroyAllObjects()
	{
		gameObjects = GameObject.FindGameObjectsWithTag (stickTag);
		Debug.Log ("destroyed");
		for(var i = 0 ; i < gameObjects.Length ; i ++)
		{
			Destroy(gameObjects[i]);
		}
	}

}
