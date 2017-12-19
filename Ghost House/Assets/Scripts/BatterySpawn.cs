using UnityEngine;
using System.Collections;

public class BatterySpawn : MonoBehaviour {

	public Rigidbody battery;

	public Transform spawnPoint;

	public float spawnTime;

	public bool batSpawned;

	// Use this for initialization
	void Start () {
		batSpawned = false;
	}
	
	void Update () {
		if(batSpawned == false){
			//StartCoroutine(SpawnBat(spawnTime, battery));
			print("Spawn Box is Empty");
		}
		else if(batSpawned == true){
			print("Battery has spawned!");
			}
		}

	 void OnTriggerStay(Collider other){

		if(other.gameObject.tag == "Battery"){
			print("Battery is in the trigger");
			batSpawned = true;
			}
			else if(other.gameObject.tag == "Battery"){
				batSpawned = false;
				print("Spawn Box is Empty");
			}
		}

	// IEnumerator SpawnBat(float time, Rigidbody bat){
	// 	yield return new WaitForSeconds(time);
	// 	Instantiate(bat, spawnPoint.position, spawnPoint.rotation);
	// 	batSpawned = true;

	//}
}