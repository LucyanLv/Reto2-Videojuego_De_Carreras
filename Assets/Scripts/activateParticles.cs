using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateParticles : MonoBehaviour
{
    public GameObject nieve;
    public bool isSnowing;

    private void Start()
    {
        isSnowing = false;
        nieve.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            if (!isSnowing) Snow();
        }

        if (other.gameObject.layer == 9)
        {
            if (isSnowing) StopSnow();
        }
    }

    void Snow()
    {
        print("Iniciará a nevar");
        isSnowing=true;
        nieve.SetActive (true);
    }

    void StopSnow()
    {
        print("Dejará De Nevar");
        isSnowing=false;
        nieve.SetActive(false);
    }
}
