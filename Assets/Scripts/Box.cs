using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Box : MonoBehaviour
{
    Round round;

    void Awake()
    {
        round = FindObjectOfType<Round>();
    }

    int GetCounter()
    {
        return round.Counter();
    }
}
