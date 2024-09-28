using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public float mapSpeed;
    private float mapOffset;

    void Start()
    {
        
    }

    
    void Update()
    {
        mapOffset += Time.deltaTime * mapSpeed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(mapOffset, 0f);
    }
}
