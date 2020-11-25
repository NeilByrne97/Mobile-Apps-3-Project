using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Functionally identical to HealthManager script
public class AmmoManager : MonoBehaviour
{ 
    public static AmmoManager Instance;

    public int startingAmmo = 6;
    public GameObject[] ammoIcons;
    public GameObject reloadSplash;

    private int currentAmmo;
    private bool reload = false;

    public bool infinteAmmo = false;
    public bool canShoot = true;

    void Start()
    {
        Instance = this;
        currentAmmo = startingAmmo;
    }

    public static void RemoveAmmo()
    {
        if(Instance.canShoot == true)
        {
            print("Bang");
            Instance.currentAmmo--;

            if (Instance.currentAmmo >= 0)
            {
                Instance.ammoIcons[Instance.currentAmmo].SetActive(false); // Remove bullet icon
            }
            print("Current instance is " + Instance.currentAmmo);
            // Reload
            if (Instance.currentAmmo <= 0)
            {
                ShootAtClickPosition.noAmmo();
                print("We made it");
                Instance.reload = true;
                Instance.canShoot = false;
            }
        }
        

    }

    public static void InfiniteAmmo()
    {
        //StartCoroutine(InfiniteAmmoTime());
        Instance.currentAmmo = 1000000;
        Instance.currentAmmo = 6;
        Instance.infinteAmmo = false;
    }

    IEnumerator InfiniteAmmoTime()
    {
        yield return new WaitForSeconds(10);
    }


    private void OnGUI()
    {
        if (reload)
        {
            ShootAtClickPosition.noAmmo();  // Player unable to shoot
            reloadSplash.SetActive(true);   // RELOAD splash screen
        }
    }
}
