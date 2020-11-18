using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoManager : MonoBehaviour
{
    public static AmmoManager Instance;

    public int startingAmmo = 6;
    public GameObject[] ammoIcons;

    private int currentAmmo;
    private bool reload = false;

    void Start()
    {
        Instance = this;
        currentAmmo = startingAmmo;
    }

    public static void RemoveAmmo()
    {

        print("Bang");
        Instance.currentAmmo--;

        if (Instance.currentAmmo >= 0)
        {
            Instance.ammoIcons[Instance.currentAmmo].SetActive(false);
        }

        // Reload
        if (Instance.currentAmmo <= 0)
        {
            Instance.reload = true;
        }

    }

    private void OnGUI()
    {
        if (reload)
        {
            GUILayout.Label("Reload!");
        }
    }
}
