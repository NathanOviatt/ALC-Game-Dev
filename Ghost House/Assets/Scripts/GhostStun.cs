using UnityEngine;
using System.Collections;

public class GhostStun : MonoBehaviour {

	bool lightCheck;
	Flashlight flash;
	public GameObject ghost;
	public float stunDelay;

	void Start () {
		flash = gameObject.GetComponentInChildren<Light>().GetComponentInChildren<Flashlight>();
		print("Obj:" + flash);
		flash.setLightOn();
		print("Start" + flash.isLightOn());
	}
	
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		print(other.gameObject.name);
		print("Collider" + flash);
		if(other.gameObject.name == "Ghost" && flash == true){
			print("Ghost is stunned!");

			other.GetComponent<GhostAI>().moveSpeed = 0f;
			StartCoroutine(Wait(stunDelay, other));
		}
	}

	IEnumerator Wait(float time, Collider other){
		yield return new WaitForSeconds(time);
		other.gameObject.GetComponent<GhostAI>().moveSpeed = 4f;
		print("Ghost is unstunned");
	}
}
