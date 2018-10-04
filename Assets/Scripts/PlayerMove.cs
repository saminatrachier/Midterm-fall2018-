using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

	public GameObject MainCamera;
	public float moveSpeed = 10;
	//mouse sensitivity:
	public float lookSpeed = 300f;
	Vector3 inputVector; // pass data from Update() to FixedUpdate()
	// Use this for initialization
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//mouse look
		//if (MainCamera.transform.rotation.y > 0)
		{
		//	MainCamera.transform.rotation= new Vector3(0)
		}
		float mouseX = Input.GetAxis("Mouse X")* lookSpeed * Time.deltaTime; //mouseX = horizontal mouseDelta
		float mouseY = Input.GetAxis("Mouse Y")* lookSpeed * Time.deltaTime; //mouseY = vertical mouseDelta
		
		//rotate capsule left/right, but rotate camera up/down
		transform.Rotate(0f, mouseX, 0f);
		Camera.main.transform.localEulerAngles += new Vector3(-mouseY, 0f, 0f);
		
		//solution: after applying rotations, un-roll the camera
		Camera.main.transform.localEulerAngles -= new Vector3(0,0, Camera.main.transform.localEulerAngles.z);
		
		//first-person player movement

		float vertical = Input.GetAxis("Vertical"); //corresponds to W/S or Up/Down on a Keyboard, -1 for down +1 for up
		float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right on Keyboard, -1 is left, +1 is right
		
		inputVector = transform.forward * vertical * moveSpeed; //forward/back direction
		inputVector += transform.right * horizontal * moveSpeed; //left/right direction
	}
	void FixedUpdate() //all physics code should go in FixedUpdate!!!
	{
		//apply our forces to move the object around
		GetComponent<Rigidbody>().velocity = inputVector; //no need for Time.deltatime, already fixed framerate
		
		//one problem: gravity doesn't work anymore

	}
}
