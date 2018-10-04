using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMove : MonoBehaviour
{

	public float speed = 5f;
	
	
	
	// Update is called once per frame
	void Update ()
	{
		Ray eyeRay = new Ray(transform.position, transform.forward);

		float maxRaycastDist = 1f;
		
		Debug.DrawRay(eyeRay.origin, eyeRay.direction*maxRaycastDist, Color.red);

		if (Physics.Raycast(eyeRay, maxRaycastDist))
		{
			int randomNumber = Random.Range(0, 100);

			if (randomNumber < 50)
			{
				transform.Rotate(0f,-90f,0f);
			}
			else
			{
				transform.Rotate(0f,90f,0f);
			}
		}

		else
		{
			transform.Translate(0f, 0f, speed *Time.deltaTime);
		}

	}
}
