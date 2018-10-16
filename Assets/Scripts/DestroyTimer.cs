using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;

//USAGE: Destroy the Doggo Prefabs after a certain amount of time 


public class DestroyTimer : MonoBehaviour {
    
    public float Delay = 5f; //5 seconds of delay

   void Update()
    {
        Destroy(gameObject, Delay);
    }
}
