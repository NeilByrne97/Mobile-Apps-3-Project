using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtClickPosition : MonoBehaviour
{
    public float force = 10.0f;
    public Rigidbody bullet;
    public ForceMode forceMode;

    bool hasAmmo = true;
    
    public static void noAmmo()
    {
        print("Ammo set to false");
    }



    // Update is called once per frame
    void Update()
    {
        if(hasAmmo == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    // Where curser is on screen
                Quaternion rotation = Quaternion.LookRotation(ray.direction);   // Rotation of bullet

                Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane)); // Spawn of bullet

                Rigidbody instance = Instantiate(bullet, transform.position, rotation) as Rigidbody; // Instance of bullet
                instance.AddForce(ray.direction * force, forceMode); // Add force to bullet        
                AmmoManager.RemoveAmmo();
            }
        }
        
    }
}
