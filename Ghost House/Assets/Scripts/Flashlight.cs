using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Flashlight : MonoBehaviour {

	public bool lightOn = true;
	// Flashlight power capacity
	public int maxPower = 4;
	// Usable flashlight power
	public int currentPower;

	public int batDrainAmt;

	public float batDrainDelay;

	Light light;

	bool draining = false;

	long count = 0;

	public Text batteryText;

	void Start () {
		currentPower = maxPower;
		//Add power to flashlight
		print("Power = " + currentPower);

		light = GetComponent<Light> ();
		//Set Light default to On
		lightOn = true;
		print("Turn light on when Flashlight is initiated");
		light.enabled = true;
	}

	void Update () {
		//Toggle light on/off when E key is pressed
		if (Input.GetKeyUp (KeyCode.E) && lightOn) {
			print("Light Off");
			lightOn = false;
			light.enabled = false;
		}

		else if (Input.GetKeyUp (KeyCode.E) && !lightOn && currentPower > 0){
			print("Light On");
			lightOn = true;
			light.enabled = true;
		}

		//Update battery life
		batteryText.text = currentPower.ToString();

		//Drain battery life
		if(currentPower > 0 && lightOn){
				if(!draining){
					StartCoroutine(BatteryDrain(batDrainDelay,batDrainAmt));
				}
				else if(currentPower <= 0){
					lightOn = false;
					light.enabled = false;
				}
		}

	}
	public void setLightOn(){
		lightOn = true;
	}
	public bool isLightOn(){
		return lightOn;
	}

	IEnumerator BatteryDrain(float delay, int amount){
		if(lightOn){
			draining = true;
			yield return new WaitForSeconds(delay);
			print(currentPower);
			currentPower -= amount;
		}
		if(currentPower <= 0){
			currentPower = 0;
			print("Battery is dead!");
			light.enabled = false;
		}

		draining = false;

	}
}
