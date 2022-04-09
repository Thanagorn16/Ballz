using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    int count = 0;
    float dist = 0;
    [SerializeField] List<GameObject> boxes = new List<GameObject>();
    [SerializeField] GameObject prefab;            
    bool newWave = false;

    // void Update()
    // {

    // }
    // void Start()
    // {
    // }

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

    void SpawnBoxes()
    {
        if(newWave)
        {
            foreach(GameObject box in boxes)
            {
                // Instantiate(prefab, box.transform.position * Distance(dist), Quaternion.identity);
                // Debug.Log("aaaa: " + Distance(dist));
                // Vector3 distance = (box.transform.localScale / 2) ;
                // Instantiate(prefab, box.transform.position + (box.transform.right), Quaternion.identity);

                Vector2 newPos = new Vector2();
                newPos.x = box.transform.position.x;
                newPos.y = box.transform.position.y;
                // try to convert vector to float so that it can be used with random.range
                // for now, I find the article on internet useful. however, not sure that it gonna be any help for this.
                

                // float newPos = box.transform.position.x;
                

                // float newPos = pos.x;
                // Random.Range(0f, newPos );
                
            // }
            // Random.Range(0f, );
            // for(int i = 0; i < 7; i++)
            // {
            //     // Instantiate(prefab, box.transform.right)
            // }
            }
        }
    }
    // float Distance(float dist) {
    //     dist = Vector2.Distance(two.position, one.position);
    //     print("Distance: " + dist);
    //     return dist;
    // }
}
