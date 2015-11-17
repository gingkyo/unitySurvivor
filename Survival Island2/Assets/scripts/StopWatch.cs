using UnityEngine;
using System.Collections;

public class StopWatch : MonoBehaviour {
	GUIText timerText;
	int minutes;
	float seconds;
	// Use this for initialization
	void Start () {
		timerText = GetComponent<GUIText> ();
		seconds = 0.0f;
		minutes = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		string secondsString;
		string minutesString;
		seconds += Time.deltaTime;
		if (seconds >= 60) {
			seconds-=60;
			minutes++;
		}
		if (minutes < 10) {
			minutesString="0"+minutes;
		} else{
			minutesString=minutes.ToString();
		}

		if (seconds < 10) {
			secondsString = "0" + seconds.ToString("F2");
		} else {
			secondsString=seconds.ToString("F2");
		}

		timerText.text =minutesString +":" + secondsString+"\nBEKO";
	}
}
