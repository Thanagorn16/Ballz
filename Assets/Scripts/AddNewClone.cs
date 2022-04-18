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
        // add clone to clone manager, then destroy the game object(clone) which is instantiate from Round
        cloneManager.AddClone();
        Destroy(gameObject);
    }
}
