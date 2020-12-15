using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Functionally identical to HealthManager script
public class AmmoManager : MonoBehaviour
{ 
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
           
            // Reload
            if (currentAmmo <= 0)
            {
                reloadSplash.SetActive(true);   // RELOAD splash screen true
                shootAtClickPosition.enabled = false;
            }
        }
    }

    public void Reload()
    {
        currentAmmo = 6;
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
