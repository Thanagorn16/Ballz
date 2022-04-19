using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateClone : MonoBehaviour
{
    CloneManagement cloneManager;
    Rigidbody2D rb;
    Vector3 lastVelocity;
    [SerializeField] GameObject clonePrefab;
    // [SerializeField] float moveSpeed = 3f;

    void Awake()
    {
        cloneManager = FindObjectOfType<CloneManagement>();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void CreateNewClone()
    {
        for(int i = 0; i < cloneManager.GetClone(); i++)
        {
            GameObject instaObject = Instantiate(clonePrefab, transform.position, Quaternion.identity);
            // instaObject.transform.SetParent(gameObject.transform);
        }       

        // rb.velocity = transform.up * moveSpeed; // shoot the ball with velocity from Rigidbody2D.
        // lastVelocity = rb.velocity; // get the last veloxity from before bouncing to then give it to the ball after bounce
    }

    // void Bounce(Collision2D other) //the entire method make the ball bounce properly
    // {
    //     float speed = lastVelocity.magnitude;
    //     Vector3 direction = Vector3.Reflect(lastVelocity.normalized, other.contacts[0].normal);

    //     rb.velocity = direction * Mathf.Max(speed, 0f);
    // }
}
