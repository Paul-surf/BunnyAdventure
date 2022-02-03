using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowLevels : MonoBehaviour
{
    public GameObject Target;
    private Vector3 Offset;
    void Start()
    {
        Offset = transform.position - Target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position+Offset;
    }
}
