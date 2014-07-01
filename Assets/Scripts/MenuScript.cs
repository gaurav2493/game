using System;
using UnityEngine;
using TouchScript.Gestures;

public class MenuScript : MonoBehaviour {

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
		Application.LoadLevel (0);
	}
	


	
	
}
