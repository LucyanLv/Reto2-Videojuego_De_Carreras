using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateParticles : MonoBehaviour
{
    public ParticleSystem nieve;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.layer == 7)
        {
            nieve.Play();
        }
    }
}
