using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignCheckpointNumbers : MonoBehaviour
{
    private void Awake()
    {
        // Obtén todos los objetos vacíos en la escena
        GameObject[] emptyObjects = GameObject.FindGameObjectsWithTag("Checkpoint");

        // Comienza el conteo desde 160
        int currentNumber = 160;

        // Itera a través de los objetos vacíos para asignar cpNumber
        for (int i = 0; i < emptyObjects.Length; i++)
        {
            // Asegúrate de que el objeto vacío tenga el componente Checkpoint adjunto
            Checkpoint checkpointScript = emptyObjects[i].GetComponent<Checkpoint>();
            if (checkpointScript != null)
            {
                // Asigna el valor actual a cpNumber del objeto vacío actual y luego decrementa
                checkpointScript.cpNumber = currentNumber;
                currentNumber--;
            }
        }
    }
}
