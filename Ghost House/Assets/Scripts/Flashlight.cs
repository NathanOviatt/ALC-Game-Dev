using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Flashlight : MonoBehaviour {

	public bool lightOn;

	Light light;

	void Start () {
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
}
