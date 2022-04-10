using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTest : MonoBehaviour
{
    // [SerializeField] Vector3 origin;
    // [SerializeField] float radius = 1;
    // [SerializeField] List<GameObject> objs = new List<GameObject>();
    // [SerializeField] GameObject prefabs;
    [SerializeField] List<GameObject> objs = new List<GameObject>();
    // int index = 0;
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
        int index = Random.Range(0, objs.Count);
        if(objs.Count > 0)
        {
            Debug.Log("3333333333");
            Instantiate(objs[index], transform.position, Quaternion.identity);
        }

    }
}
