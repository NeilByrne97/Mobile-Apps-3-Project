using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtClickPosition : MonoBehaviour
{
    public Rigidbody bullet;
    public float force = 10.0f;
    public ForceMode forceMode;
    public string fireButton = "Fire1";
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(fireButton)) {
        Rigidbody instance = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
        instance.AddForce(transform.forward * force, forceMode);
    }
    }
}
