using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTest : MonoBehaviour
{
    // [SerializeField] Vector3 origin;
    // [SerializeField] float radius = 1;
    // [SerializeField] List<GameObject> objs = new List<GameObject>();
    // [SerializeField] GameObject prefabs;
    // [SerializeField] List<GameObject> objs = new List<GameObject>(); // for random stuff
    // int index = 0;
    Rigidbody2D rb;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] GameObject[] wayPoints;
    // [SerializeField] GameObject wayPoint;
    [SerializeField] GameObject[] objs;
    [SerializeField] float distanceBtwBox = 1f;

    void Start()
    {
        // transform.position = origin + Random.insideUnitSphere * radius;
        // foreach(GameObject obj in objs)
        // {
        //     Instantiate(prefabs, transform.position, Quaternion.identity);
        // }
        // Debug.Log("111111111");
        // if(index > 0)
        // {
        //     Debug.Log("22222222");
        //     index = Random.Range(0, objs.Count);
            
        //     if(objs.Count > 0)
        //     {
        //         Debug.Log("3333333333");
        //         Instantiate(objs[index], transform.position, Quaternion.identity);
        //     }
        // }

        // work!! --> random instantiate at the specified position (transform.position)
        // int index = Random.Range(0, objs.Count);
        // if(objs.Count > 0)
        // {
        //     Debug.Log("3333333333");
        //     Instantiate(objs[index], transform.position, Quaternion.identity);
        // }

        rb = GetComponent<Rigidbody2D>();
    }

    // void Update()
    // {
    //     TestForMove();
    // }
    void OnEnable()
    {
        TestForMove();
    }

    void TestForMove()
    {
        // rb.velocity = transform.up * moveSpeed;
        // transform.position = Vector3.MoveTowards(transform.position, wayPoint.transform.position, Time.deltaTime * moveSpeed);
        int index = 0;
        // [SerializeField] float distanceBtwBox = 1f;
        // foreach(GameObject obj in objs) // with this code, thing would not work properly
        // {
        //     // transform.position = Vector3.MoveTowards(transform.position, wayPoints[index].transform.position, Time.deltaTime * moveSpeed);
        //     // index++;
        //     transform.position += Vector3.down * distanceBtwBox * Time.deltaTime;
        //     Debug.Log("aaaaaaaa");
        // }

       transform.position += Vector3.down * distanceBtwBox;
       Debug.Log("time: " + Time.deltaTime);
    //    Debug.Log("result: " + Vector3.down * distanceBtwBox * Time.deltaTime);
        
    }
}
