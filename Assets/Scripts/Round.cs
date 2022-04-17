using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    int round = 1;
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
        if(other.gameObject.tag == "Ball") //collision for everytime the ball hit the bottom
        {
            Counter();
            Debug.Log("count: " + round);
            SpawnBoxes();
        }   
    }

    public int GetCurrentRound()
    {
        return round;
    }
    public int Counter()
    {
        return round++;
    }

    void SpawnBoxes()
    {
        Vector3 originalPos = prefab.transform.position; // this's original position of the instance before making any movement

        for(int i = 0; i < 6; i++)
        {
            int index = Random.Range(0, prefabs.Count); // random game object to be spawn
            GameObject instaObject = Instantiate(prefabs[index], prefab.transform.position, Quaternion.identity); // take the game object from above and instantiate it
            Vector3 newPos = new Vector3();
            newPos.x = 0.9f; // move the instantiate the object a little bit to the right
            // instaObject.transform.parent = box.transform; //instantiate the object as a child of box (from hierachy window)
            // the one above is the old version syntax of setting parent game object. If you use it with UI, it will generate warning in project window.
            instaObject.transform.SetParent(box.gameObject.transform); //instantiate the object as a child of box (from hierachy window)
            prefab.transform.position += newPos; // move the original instance to the right
        }

        foreach(Transform child in box.transform) // loop through all the instance which are children of Boxes
        {
            child.transform.position += child.transform.up * -distanceBtwBox; // move them all down
        }

        prefab.transform.position = originalPos; // return the original instance to the original position
    }
}
