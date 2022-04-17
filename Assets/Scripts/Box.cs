using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Box : MonoBehaviour
{
    Round round;
    TMP_Text roundText;

    void Awake()
    {
        round = FindObjectOfType<Round>();
        roundText = GetComponent<TMP_Text>();
    }

    void Start()
    {
        roundText.text = round.GetCurrentRound().ToString(); // get each round number
    }
}
