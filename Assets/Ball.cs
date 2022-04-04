using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    Navigator navigator;
    Vector2 rawInput;
    bool getClick = false;
    [SerializeField] float moveSpeed = 3;

    void Awake()
    {
        navigator = FindObjectOfType<Navigator>();
    }

    // Update is called once per frame
    void Update()
    {
        // navigator.GetMousePosition();
        // StickToMosue();
        Shoot();
        GetAngle();
    }

    void Shoot()
    {
        if(getClick)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }
    }

    void OnClick(InputValue value)
    {
        getClick = value.isPressed;
    }
    // void OnClick(InputValue value)
    // {
    //     rawInput = value.Get<Vector2>();
    // }
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
