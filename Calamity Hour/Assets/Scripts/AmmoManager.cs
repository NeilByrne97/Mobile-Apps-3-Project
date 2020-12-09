using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Functionally identical to HealthManager script
public class AmmoManager : MonoBehaviour
{ 
   // public static AmmoManager Instance;
    public ShootAtClickPosition shootAtClickPosition;

    public int startingAmmo = 6;
    public GameObject[] ammoIcons;
    public GameObject reloadSplash;

    private int currentAmmo;
    public bool infinteAmmo = false;

    void Start()
    {
        currentAmmo = startingAmmo;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            if (currentAmmo >= 0)
            {
                currentAmmo--;
                ammoIcons[currentAmmo].SetActive(false); // Remove bullet icon
            }
            print("Current ammo is " + currentAmmo);

           
            // Reload
            if (currentAmmo <= 0)
            {
                print("No ammo");
                reloadSplash.SetActive(true);   // RELOAD splash screen true
                shootAtClickPosition.enabled = false;
            }
        }
    }

    public void Reload()
    {
        print("Reload");
        currentAmmo = 6;
        print("Current ammo is " + currentAmmo);
        reloadSplash.SetActive(false);   // RELOAD splash screen false
        shootAtClickPosition.enabled = true;

        for(int i = 0; i<=currentAmmo; i++)
        {
            ammoIcons[i].SetActive(true);
        }
        

    }


    public void InfiniteAmmo()
    {
        //StartCoroutine(InfiniteAmmoTime());
        currentAmmo = 1000000;
        currentAmmo = 6;
        infinteAmmo = false;
    }

    IEnumerator InfiniteAmmoTime()
    {
        yield return new WaitForSeconds(10);
    }

}
