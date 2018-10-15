using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoggoSpawner : MonoBehaviour
{
	private float nextSpawnTime;
	
	public GameObject Doggo1; //dog prefab to be spawned
	public float spawnDelay = 3f;  //how long between each spawn
//	public float maxNumber = 25f;
//	private float enemyCount = 0f;



//	void Start()
//	{
//		InvokeRepeating("Spawn", 0, spawnDelay);
//	}
	// Update is called once per frame
	void Update () {

		if (ShouldSpawn())
		{
			Spawn();
		}
		
	}

	private void Spawn()
	{
		nextSpawnTime = Time.time + spawnDelay;
		Instantiate(Doggo1, transform.position, transform.rotation);
		
	}

	private bool ShouldSpawn()
	{
		
//		enemyCount++;
		
//		if (enemyCount >= maxNumber)
//		{
//			CancelInvoke("Spawn");
//		}
		return Time.time >= nextSpawnTime;

		
	}
	
}
