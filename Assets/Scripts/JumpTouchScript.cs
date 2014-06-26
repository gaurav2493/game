using System;
using UnityEngine;
using System.Collections;
using TouchScript.Gestures;

public class JumpTouchScript : MonoBehaviour {

	public static bool jump = false;

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
		jump = true;
		Debug.Log ("jumped");
	}
}
