using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOnNoChildren : MonoBehaviour
{
    public ThrowAfterDelay shootAfterDelay0;
    public ThrowAfterDelay shootAfterDelay1;
    public ThrowAfterDelay shootAfterDelay2;
    public ThrowAfterDelay shootAfterDelay3;
    public ThrowAfterDelay shootAfterDelay4;
    public ThrowAfterDelay shootAfterDelay5;

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        print("Shooooot");

        if (shootAfterDelay0 == null)
        {
            shootAfterDelay0.GetComponent<ThrowAfterDelay>();
        }

        if (shootAfterDelay1 == null)
        {
            shootAfterDelay0.GetComponent<ThrowAfterDelay>();
        }

        if (shootAfterDelay2 == null)
        {
            shootAfterDelay0.GetComponent<ThrowAfterDelay>();
        }

        if (shootAfterDelay3 == null)
        {
            shootAfterDelay0.GetComponent<ThrowAfterDelay>();
        }

        if (shootAfterDelay4 == null)
        {
            shootAfterDelay0.GetComponent<ThrowAfterDelay>();
        }

        if (shootAfterDelay5 == null)
        {
            shootAfterDelay0.GetComponent<ThrowAfterDelay>();
        }

        print("Shooooot");
        shootAfterDelay0.Throw();
        shootAfterDelay1.Throw();
        shootAfterDelay2.Throw();
        shootAfterDelay3.Throw();
        shootAfterDelay4.Throw();

        Destroy(gameObject);

    }

}

