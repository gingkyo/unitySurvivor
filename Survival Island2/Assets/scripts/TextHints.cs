using UnityEngine;
using System.Collections;

public class TextHints : MonoBehaviour {
	float timer;
	GUIText hint;

	// Use this for initialization
	void Start () {
		timer = 0.0f;
		hint=GetComponent<GUIText> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (hint.enabled) {
			timer+=Time.deltaTime;
		}
		if (timer >= 4) {
			hint.enabled=false;
			timer=0.0f;
		}
	}
	void ShowHint(string message){
		hint.text = message;
		if (!hint.enabled) {
			hint.enabled=true;
		}
	}
}
