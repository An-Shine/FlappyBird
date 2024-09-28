using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed;

   

   
    void Update()
    {
        gameObject.transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
       
        if(transform.position.x  <= -6.0f)
        {
             Destroy (gameObject);                        
        }

    }
}
