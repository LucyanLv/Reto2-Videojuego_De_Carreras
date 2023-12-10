using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignCheckpointNumbers : MonoBehaviour
{
    private void Awake()
    {
        // Obtén todos los objetos vacíos en el objeto padre con el tag "Checkpoint"
        Transform checkpointParent = transform; // Asegúrate de asignar el objeto padre correcto en el Inspector
        GameObject[] emptyObjects = GetChildObjectsWithTag(checkpointParent, "Checkpoint");

        // Obtén la cantidad total de objetos vacíos
        int totalEmptyObjects = emptyObjects.Length;

        // Número inicial deseado para los checkpoints
        int initialCheckpointNumber = 1;

        // Itera a través de los objetos vacíos para asignar cpNumber
        for (int i = 0; i < totalEmptyObjects; i++)
        {
            // Asegúrate de que el objeto vacío tenga el componente Checkpoint adjunto
            Checkpoint checkpointScript = emptyObjects[i].GetComponent<Checkpoint>();
            if (checkpointScript != null)
            {
                // Asigna el valor actual a cpNumber del objeto vacío actual
                checkpointScript.cpNumber = initialCheckpointNumber + i;
            }
        }
    }

    // Función para obtener objetos hijos con un tag específico
    private GameObject[] GetChildObjectsWithTag(Transform parent, string tag)
    {
        List<GameObject> childObjects = new List<GameObject>();

        foreach (Transform child in parent)
        {
            if (child.CompareTag(tag))
            {
                childObjects.Add(child.gameObject);
            }
        }

        return childObjects.ToArray();
    }
}
