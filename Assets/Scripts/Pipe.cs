using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 5.0f;
    public float deadZone = -35f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
