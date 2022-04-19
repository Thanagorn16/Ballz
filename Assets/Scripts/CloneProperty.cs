using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CloneProperty : MonoBehaviour
{
    Navigator navigator;
    CloneManagement cloneManager;
    Vector2 rawInput;
    // bool getClick = false;
    Rigidbody2D rb;
    Vector3 lastVelocity;
    CreateClone createClone;
    [SerializeField] float moveSpeed = 3;
    // [SerializeField] int clone = 0;
    [SerializeField] bool isClone;
    // [SerializeField] GameObject ballPrefab;

    void Awake()
    {
        navigator = FindObjectOfType<Navigator>();
        cloneManager = FindObjectOfType<CloneManagement>();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        createClone = GetComponent<CreateClone>();
    }

    void Update()
    {
        Shoot();
        // GetAngle();
    }

    // void GetAngle()
    // {
    //     Vector3 mousePostion = Camera.main.ScreenToWorldPoint(navigator.GetMousePosition()); //get mouse position 
    //     Vector2 direction = mousePostion - transform.position; // getting a direction works by subtracting the starting position from the target.
    //     float angle = Vector2.SignedAngle(Vector2.up, direction); // find the angle between Vector2.up and the direction of the mouse from the object
    //     transform.eulerAngles = new Vector3(0,0,angle); // rotate the object by setting the object’s Z rotation to the angle value
    // }

    void Shoot()
    {
        // rb.velocity = transform.up * moveSpeed; // shoot the ball with velocity from Rigidbody2D.
        if(isClone)
        {
            rb.velocity = transform.up * moveSpeed; // shoot the ball with velocity from Rigidbody2D.
        }

        // // for(int i = 0; i < cloneManager.GetClone(); i++)
        // // {
        // //     // Debug.Log("clone" + i);
        // //     // GameObject instaObj = Instantiate(ballPrefab, transform.position, Quaternion.identity);
        // // }

        lastVelocity = rb.velocity; // get the last veloxity from before bouncing to then give it to the ball after bounce
        // Debug.Log("shoot");
    }

    // void OnClick(InputValue value)
    // {
    //     getClick = value.isPressed;
    // }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag != "Bottom")
        {
            Bounce(other);
            // Debug.Log("bounce");
        }
        else 
        {
            rb.velocity =  Vector2.zero;// stop every motion once hit the bottom
            // createClone.CreateNewClone(); //create new clone following the amount in CloneManagement once the ball hit the bottom.
        }

    }

    // void CreateClone()
    // {   
    //     if(cloneManager.GetClone() != 0)
    //     {
    //         for(int i = 0; i < cloneManager.GetClone(); i++)
    //         {
    //             GameObject instaObj = Instantiate(ballPrefab, transform.position, Quaternion.identity);
    //         }
    //     }
        // for(int i = 0; i < cloneManager.GetClone(); i++)
        // {
        //     GameObject instaObj = Instantiate(ballPrefab, transform.position, Quaternion.identity);
        // }
    // }

    void Bounce(Collision2D other) //the entire method make the ball bounce properly
    {
        float speed = lastVelocity.magnitude;
        Vector3 direction = Vector3.Reflect(lastVelocity.normalized, other.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 0f);
        // Debug.Log("clone is here");
    }

    // void StickToMosue()
    // {
    //     Vector2 mousePostion = Camera.main.ScreenToWorldPoint(navigator.GetMousePosition());
    //     transform.position = mousePostion;
    // }
}
