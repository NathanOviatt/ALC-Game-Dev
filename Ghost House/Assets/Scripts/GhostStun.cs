using UnityEngine;
using System.Collections;

public class GhostStun : MonoBehaviour {

	//bool lightCheck;

	void Start () {
		//lightCheck = GetComponent<Flashlight>().lightOn;
	}
	
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){

		if(other.gameObject.name == "Ghost"){
			print("Ghost is stunned!");
		}
	}
}
