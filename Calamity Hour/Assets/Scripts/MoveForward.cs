using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 1.0f;
    public bool useRigidbodyMove = false;

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
