using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignCheckpointNumbers : MonoBehaviour
{
    private void Awake()
    {
        // Obt�n todos los objetos vac�os en el objeto padre con el tag "Checkpoint"
        Transform checkpointParent = transform; // Aseg�rate de asignar el objeto padre correcto en el Inspector
        GameObject[] emptyObjects = GetChildObjectsWithTag(checkpointParent, "Checkpoint");

        // Obt�n la cantidad total de objetos vac�os
        int totalEmptyObjects = emptyObjects.Length;

        // N�mero inicial deseado para los checkpoints
        int initialCheckpointNumber = 1;

        // Itera a trav�s de los objetos vac�os para asignar cpNumber
        for (int i = 0; i < totalEmptyObjects; i++)
        {
            // Aseg�rate de que el objeto vac�o tenga el componente Checkpoint adjunto
            Checkpoint checkpointScript = emptyObjects[i].GetComponent<Checkpoint>();
            if (checkpointScript != null)
            {
                // Asigna el valor actual a cpNumber del objeto vac�o actual
                checkpointScript.cpNumber = initialCheckpointNumber + i;
            }
        }
    }

    // Funci�n para obtener objetos hijos con un tag espec�fico
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
