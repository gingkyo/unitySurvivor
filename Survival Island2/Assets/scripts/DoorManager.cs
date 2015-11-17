using UnityEngine;
using System.Collections;

public class DoorManager : MonoBehaviour {
	private bool doorIsOpen=false;
	private float doorTimer=0.0f;
	public float doorOpenTime=3.0f;
	private GameObject currentDoor;
	public AudioClip doorOpenSound;
	public AudioClip doorCloseSound;
	// Use this for initialization
	void Start () {
		doorTimer = 0.0f;
	}
	// Update is called once per frame
	void Update () {
		if (doorIsOpen) {
			doorTimer+=Time.deltaTime;
			if(doorTimer> doorOpenTime){
				AnimateDoor(false,doorCloseSound,"doorshut");
				doorTimer=0.0f;
			}
		}
	}
	void DoorCheck(){
		if (!doorIsOpen) {
			AnimateDoor(true,doorOpenSound,"dooropen");

		}
	}
	void AnimateDoor(bool doorStatus,AudioClip aClip,string animationName){
		doorIsOpen = doorStatus;
		GetComponent<AudioSource> ().PlayOneShot (aClip);
		transform.parent.GetComponent<Animation> ().Play (animationName);
	}
}
