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
    [SerializeField] float moveSpeed = 3;
    // [SerializeField] float moveSpeedx = 3;
    // [SerializeField] float moveSpeedy = 3;

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

    void Shoot()
    {
        if(getClick)
        {
            rb.velocity = transform.up * moveSpeed; // shoot the ball with velocity from Rigidbody2D.
            // Debug.Log("speed: " + rb.velocity);
            // Debug.Log("11111111111111");
            // Vector2 vel = rb.velocity;
            // rb.velocity = transform.up * new Vector2(Mathf.Clamp(vel.x, -(moveSpeedx), moveSpeedx), Mathf.Clamp(vel.y, -(moveSpeedy), moveSpeedy));
            // Debug.Log("222222222");
            Debug.Log("rb: " + rb.velocity);
            Debug.Log(this.rb.velocity);
        }
    }

    void OnClick(InputValue value)
    {
        getClick = value.isPressed;
    }
    void GetAngle()
    {
        Vector3 mousePostion = Camera.main.ScreenToWorldPoint(navigator.GetMousePosition()); //get mouse position 
        Vector2 direction = mousePostion - transform.position; // getting a direction works by subtracting the starting position from the target.
        float angle = Vector2.SignedAngle(Vector2.up, direction); // find the angle between Vector2.up and the direction of the mouse from the object
        transform.eulerAngles = new Vector3(0,0,angle); // rotate the object by setting the object’s Z rotation to the angle value
    }
    // void StickToMosue()
    // {
    //     Vector2 mousePostion = Camera.main.ScreenToWorldPoint(navigator.GetMousePosition());
    //     transform.position = mousePostion;
    // }
}
