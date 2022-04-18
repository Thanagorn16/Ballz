using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateClone : MonoBehaviour
{
    CloneManagement cloneManager;
    [SerializeField] GameObject clonePrefab;

    void Awake()
    {
        cloneManager = FindObjectOfType<CloneManagement>();
    }

    public void CreateNewClone()
    {
        for(int i = 0; i < cloneManager.GetClone(); i++)
        {
            Instantiate(clonePrefab, transform.position, Quaternion.identity);
        }       
    }
}
