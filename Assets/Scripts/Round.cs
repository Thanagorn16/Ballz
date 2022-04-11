using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    int count = 0;
    [SerializeField] GameObject prefab;
    [SerializeField] List<GameObject> prefabs = new List<GameObject>();
    void Start()
    {
        SpawnBoxes();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Counter(count++);
            Debug.Log("count: " + count);
            SpawnBoxes();
        }   
    }

    public int Counter(int count)
    {
        return count;
    }

    // Vector3 OriginalPosition()
    // {
    //     Vector3 originalPos = prefab.transform.position;
    //     Debug.Log("originalPosition: " + originalPos);
    //     return originalPos;
    // }

    void SpawnBoxes()
    {
        Vector3 originalPos = prefab.transform.position; // this's original position of the prefab before making any movement
        // Debug.Log("oriPos: " + originalPos);

        for(int i = 0; i < 5; i++)
        {
            int index = Random.Range(0, prefabs.Count); // random game object to be spawn
            Instantiate(prefabs[index], prefab.transform.position, Quaternion.identity); // take the game object from above and instantiate it
            Vector3 newPos = new Vector3();
            newPos.x = 0.9f;
            prefab.transform.position += newPos; // move the original instance to the right
            // Debug.Log("for: " + prefab.transform.position + newPos);
        }
        // Debug.Log("oriPos1 " + originalPos);
    }
}
