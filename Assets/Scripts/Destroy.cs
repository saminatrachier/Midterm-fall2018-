using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    void Update()
    {
        
        //checks if the user clicks the mouse button
        if (Input.GetMouseButton(0))
        {
            Debug.Log("What");
            //raycast to check if the player hits the object
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hi");
                SphereCollider sc = hit.collider as SphereCollider;
                //if the collider is a sphere collider, then it destroys the object
                if(sc != null)
                {
                    Debug.Log("hello");
                    Destroy(sc.gameObject);
                }
            }
        }
    }
   
}
