using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNewClone : MonoBehaviour
{
    CloneManagement cloneManager;

    void Awake()
    {
        cloneManager = FindObjectOfType<CloneManagement>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        cloneManager.AddClone();   
        Destroy(gameObject);
        // Debug.Log("check: " + cloneManager.GetClone());
    }
}
