using UnityEngine;
using System.Collections;

public class TriggerZone : MonoBehaviour {
	public AudioClip lockedSound;
	public Light doorLight;
	public GUIText textHint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag=="Player"){
			if(Inventory.charge==4){
				transform.FindChild("door").SendMessage("DoorCheck");
				if(GameObject.Find ("GUIBattery")){
					Destroy(GameObject.Find("GUIBattery"));
					doorLight.color=Color.green;
				}
			} else{
				transform.FindChild("door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
				string hintMessage;
				if(Inventory.charge==0){
					hintMessage="This door seems locked.maybe that generator needs power...";
				} else{
					hintMessage="Still won't budge.Perhaps it needs more power.";
				}
				textHint.SendMessage("ShowHint", hintMessage );
				col.gameObject.SendMessage("HUDOn");
			}
		}
	}
}
