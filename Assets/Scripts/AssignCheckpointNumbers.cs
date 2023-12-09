using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignCheckpointNumbers : MonoBehaviour
{
    private void Awake()
    {
        // Obt�n todos los objetos vac�os en la escena
        GameObject[] emptyObjects = GameObject.FindGameObjectsWithTag("Checkpoint");

        // Comienza el conteo desde 160
        int currentNumber = 160;

        // Itera a trav�s de los objetos vac�os para asignar cpNumber
        for (int i = 0; i < emptyObjects.Length; i++)
        {
            // Aseg�rate de que el objeto vac�o tenga el componente Checkpoint adjunto
            Checkpoint checkpointScript = emptyObjects[i].GetComponent<Checkpoint>();
            if (checkpointScript != null)
            {
                // Asigna el valor actual a cpNumber del objeto vac�o actual y luego decrementa
                checkpointScript.cpNumber = currentNumber;
                currentNumber--;
            }
        }
    }
}
