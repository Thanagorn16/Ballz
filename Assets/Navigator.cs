using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Navigator : MonoBehaviour
{
    Vector2 mousePosition;
    public Vector2 GetMousePosition()
    {
        mousePosition = Mouse.current.position.ReadValue();
        Debug.Log(mousePosition);
        return mousePosition;
    }

}
