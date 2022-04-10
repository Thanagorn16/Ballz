using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    int count = 0;
    // [SerializeField] List<GameObject> boxes = new List<GameObject>();
    // [SerializeField] GameObject prefab;            
    [SerializeField] GameObject prefab;
    [SerializeField] List<GameObject> prefabs = new List<GameObject>();
    bool newWave = false;
    // [SerializeField] Transform position;

    // void Update()
    // {

    // }
    void Start()
    {
        // Debug.Log("start: " + prefab.transform.position);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ball")
        {
            // count++;
            Counter(count++);
            Debug.Log("count: " + count);
            newWave = true;
            SpawnBoxes();
            newWave = false;
            // Debug.Log("count: " + count);
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
        if(newWave)
        {
            // for(int i = 0; i < 5; i++)
            // {
            //     Instantiate(prefab, prefab.transform.position, Quaternion.identity);
            //     Vector3 newPos = new Vector3();
            //     newPos.x = 0.9f;
            //     prefab.transform.position += newPos; // move the original instance to the right
            //     // Debug.Log("for: " + prefab.transform.position + newPos);

            // }

            // int index = Random.Range(0, prefabs.Count);
            // Debug.Log("index: " + index);
            for(int i = 0; i < 5; i++)
            {
                int index = Random.Range(0, prefabs.Count); // random game object to be spawn
                Instantiate(prefabs[index], prefab.transform.position, Quaternion.identity); // take the game object from above and instantiate it
                Vector3 newPos = new Vector3();
                newPos.x = 0.9f;
                prefab.transform.position += newPos; // move the original instance to the right
                // Debug.Log("for: " + prefab.transform.position + newPos);

            }

            // return the instance to the original position
            // prefab.transform.position = OriginalPosition();
            // Debug.Log("out: " + prefab.transform.position);




            // foreach(GameObject box in boxes)
            // {
                // Instantiate(prefab, box.transform.position * Distance(dist), Quaternion.identity);
                // Debug.Log("aaaa: " + Distance(dist));
                // Vector3 distance = (box.transform.localScale / 2) ;
                // Instantiate(prefab, box.transform.position + (box.transform.right), Quaternion.identity);

                // Vector2 newPos = new Vector2();
                // newPos.x = box.transform.position.x;
                // newPos.y = box.transform.position.y;

                // Random.Range()
            // }
        }
    }
    // float Distance(float dist) {
    //     dist = Vector2.Distance(two.position, one.position);
    //     print("Distance: " + dist);
    //     return dist;
    // }
}
