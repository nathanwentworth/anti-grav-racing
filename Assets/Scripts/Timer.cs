using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
	
	public float timer = 0.0f;
	public bool timerStarted = true;
	
	void Update()
	{
		if( Input.GetKeyDown( KeyCode.N ) )     // Use the N-key to toggle the timer On and Off
		{
			if( timerStarted == false )
				timerStarted = true;
			else
				timerStarted = false;
		}
		
		if( timerStarted )
			timer += Time.deltaTime;
	}
	
	void OnGUI()
	{
		GUI.Label( new Rect( 40, 40, 120, 50 ), "Timer: " + timer );
	}
	
}