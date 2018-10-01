using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoggoSpawner : MonoBehaviour
{
	private float nextSpawnTime;
	
	public GameObject Doggo1; //dog prefab to be spawned
	public float spawnDelay = 3f;  //how long between each spawn
	

	
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
		return Time.time >= nextSpawnTime;
	}
	
}
