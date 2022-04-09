using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] List<GameObject> boxes = new List<GameObject>();
    [SerializeField] GameObject prefab;
    bool newWave = false;

    void Update()
    {

    }
    void SpawnBoxes()
    {
        if(newWave)
        {
            foreach(GameObject box in boxes)
            {
                Instantiate(prefab, box.transform.position, Quaternion.identity);
            }
        }
    }
}
