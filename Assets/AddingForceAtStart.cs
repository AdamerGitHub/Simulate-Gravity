using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingForceAtStart : MonoBehaviour
{
    const float G = 667408f; // Magic number

    public Rigidbody rb;
    public Vector3 forcePower = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
        rb.AddForce(forcePower * G / 10);
    }
}
