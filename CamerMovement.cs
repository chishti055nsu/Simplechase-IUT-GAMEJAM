using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMovement : MonoBehaviour
{
    public GameObject target;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, transform.position.y ,- 10);
    }
}
