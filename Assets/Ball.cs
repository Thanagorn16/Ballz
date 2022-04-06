using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    Navigator navigator;
    Vector2 rawInput;
    bool getClick = false;
    Rigidbody2D rb;
    Vector3 lastVelocity;
    [SerializeField] float moveSpeed = 3;


    void Awake()
    {
        navigator = FindObjectOfType<Navigator>();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Shoot();
        GetAngle();
    }

    void GetAngle()
    {
        Vector3 mousePostion = Camera.main.ScreenToWorldPoint(navigator.GetMousePosition()); //get mouse position 
        Vector2 direction = mousePostion - transform.position; // getting a direction works by subtracting the starting position from the target.
        float angle = Vector2.SignedAngle(Vector2.up, direction); // find the angle between Vector2.up and the direction of the mouse from the object
        transform.eulerAngles = new Vector3(0,0,angle); // rotate the object by setting the object’s Z rotation to the angle value
    }

    void Shoot()
    {
        if(getClick)
        {
            rb.velocity = transform.up * moveSpeed; // shoot the ball with velocity from Rigidbody2D.
        }

        lastVelocity = rb.velocity; // get the last veloxity from before bouncing to then give it to the ball after bounce
    }
    void OnClick(InputValue value)
    {
        getClick = value.isPressed;
    }

    void OnCollisionEnter2D(Collision2D other) // the entire method make the ball bounce properly
    {
        float speed = lastVelocity.magnitude;
        Vector3 direction = Vector3.Reflect(lastVelocity.normalized, other.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 0f);
    }


    // void StickToMosue()
    // {
    //     Vector2 mousePostion = Camera.main.ScreenToWorldPoint(navigator.GetMousePosition());
    //     transform.position = mousePostion;
    // }
}
