using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//USAGE: put this on a destroyable prefab with sphere colliders

public class Destroy : MonoBehaviour
{
    public float maxDistance = 8f;
    public GameObject halo;
  
    void Update()
    {
        
        //checks if the user clicks the mouse button
       
       
            //raycast to check if the player hits the object
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, maxDistance)&& hit.transform == this.transform)
            {
                SphereCollider sc = hit.collider as SphereCollider;
                halo.SetActive(true);
                             //if the collider is a sphere collider, then it destroys the object


                if (Input.GetMouseButtonUp(0))
                {
                    if (sc != null)
                    {
                        ScoreText.Score++;
                        Destroy(sc.gameObject);
                    }
                }
                
        }
        else
        {
            halo.SetActive(false);
        }
    }
   
}
