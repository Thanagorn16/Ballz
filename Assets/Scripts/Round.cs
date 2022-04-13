using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    int count = 0;
    GameObject box;
    [SerializeField] GameObject prefab;
    [SerializeField] List<GameObject> prefabs = new List<GameObject>();
    [SerializeField] float distanceBtwBox = 0.5f;
    void Start()
    {
        box = GameObject.Find("Boxes");
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

    void SpawnBoxes()
    {
        Vector3 originalPos = prefab.transform.position; // this's original position of the instance before making any movement
        // Debug.Log("oriPos: " + originalPos);
        // List<GameObject> spawnedObject = new List<GameObject>();
        // List<List<GameObject>> newObjs = new List<List<GameObject>>();

        for(int i = 0; i < 6; i++)
        {
            int index = Random.Range(0, prefabs.Count); // random game object to be spawn
            GameObject instaObject = Instantiate(prefabs[index], prefab.transform.position, Quaternion.identity); // take the game object from above and instantiate it
            Vector3 newPos = new Vector3();
            newPos.x = 0.9f; // move the instantiate the object a little bit to the right
            instaObject.transform.parent = box.transform; //instantiate the object as a child of box (from hierachy window)
            prefab.transform.position += newPos; // move the original instance to the right
        }

        foreach(Transform child in box.transform) // loop through all the instance which are children of Boxes
        {
            // Debug.Log("child: " + child);
            child.transform.position += child.transform.up * -distanceBtwBox; // move them all down
            // Debug.Log("obj: " + obj.transform.position);
        }

        prefab.transform.position = originalPos; // return the original instance to the original position
    }
}
