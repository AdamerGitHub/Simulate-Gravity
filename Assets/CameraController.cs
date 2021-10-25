using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform lookAt;
    public float speed = 10f;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = lookAt.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.S))
        {
            offset += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            offset -= transform.forward * speed * Time.deltaTime;
        }

        transform.position = lookAt.position - offset;
    }
}
