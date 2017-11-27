using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Flashlight : MonoBehaviour {

	public bool lightOn = true;
	// Flashlight power capacity
	public int maxPower = 4;
	// Usable flashlight power
	public int currentPower;

	Light light;

	void Start () {
		currentPower = maxPower;
		//Add power to flashlight
		print("Power = " + currentPower);

		light = GetComponent<Light> ();
		//Set Light default to On
		lightOn = true;
		light.enabled = true;
	}

	void Update () {
		//Toggle light on/off when E key is pressed
		if (Input.GetKeyUp (KeyCode.E) && lightOn) {
			lightOn = false;
			light.enabled = false;
		}

		else if (Input.GetKeyUp (KeyCode.E) && !lightOn){
			lightOn = true;
			light.enabled = true;
		}

	}
	public void setLightOn(){
		lightOn = true;
	}
	public bool isLightOn(){
		return lightOn;
	}
}
