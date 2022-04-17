using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Box : MonoBehaviour
{
    Round round;
    TMP_Text roundText;
    int num; // create this variable so that we won't involve the number with those from Round

    void Awake()
    {
        round = FindObjectOfType<Round>();
        roundText = GetComponent<TMP_Text>(); //access tmp.text of the game object
    }

    void Start()
    {
        roundText.text = round.GetCurrentRound().ToString(); // get each round number for new boxes
        num = round.GetCurrentRound(); //store round number to num as a new
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        num--;
        roundText.text = num.ToString();
        if(num <= 0)
        {
            Destroy(gameObject);
        }
        // Debug.Log("num: " + num);

    }
}
