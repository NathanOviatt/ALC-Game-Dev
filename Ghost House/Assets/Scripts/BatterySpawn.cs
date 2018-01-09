﻿using UnityEngine;
using System.Collections;

public class BatterySpawn : MonoBehaviour {

	public Rigidbody battery;

	public Transform spawnPoint;

	public float spawnTime;

	public bool batSpawned;
	private bool spawning = false;

	// Use this for initialization
	void Start () {
		batSpawned = false;
	}
	
	void Update () {
		if(batSpawned == false){
			if(!spawning){
				spawning = !spawning;
				StartCoroutine(SpawnBat(spawnTime, battery));
				print("Spawn Box is Empty");
			}
		}
		else if(batSpawned == true){

			print("Battery has spawned!");
		}
	}

	 void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "Battery"){
			print("Battery is in the trigger");
			batSpawned = true;
			}
	 	}
		void OntriggerExit(Collider other){
			if(other.gameObject.tag == "Battery"){
				print("Spawner is Empty");
				batSpawned = false;
			}
		}

		IEnumerator SpawnBat(float time, Rigidbody bat){
			yield return new WaitForSeconds(time);
				Instantiate(bat, spawnPoint.position, spawnPoint.rotation);
				batSpawned = true;
				spawning = !spawning;
		}

			public void BatteryPickup(){
				print("Spawner is Empty");
				batSpawned = false;
	}
}