using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	public static int charge =0;
	public AudioClip collectSound;
	public Texture2D [] batteryCharge;
	public Texture2D [] meterCharge;
	public GUITexture chargeHudGUI;	
	public Renderer meter;

	void Start () {
		charge = 0;
		meter.material.mainTexture = meterCharge [charge];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void CellPickup(){
		HUDOn();
		AudioSource.PlayClipAtPoint (collectSound, transform.position);
		charge++;
		chargeHudGUI.texture = batteryCharge [charge];
		meter.material.mainTexture = meterCharge [charge];
	}
	void HUDOn(){
		if (!chargeHudGUI.enabled) {
			chargeHudGUI.enabled=true;
		}
	}
}
