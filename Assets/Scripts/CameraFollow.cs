using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Main hub
    public GameObject Target;
    private float Offset;
    void Start()
    {
        Offset = transform.position.y - Target.transform.position.y;  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Target.transform.position.y+Offset, transform.position.z);
        
    }
}
