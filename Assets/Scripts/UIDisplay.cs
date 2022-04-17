using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    Round round;

    void Awake()
    {
        round = FindObjectOfType<Round>();
    }
    void Update()
    {
        scoreText.text = round.GetCurrentRound().ToString();
    }
}
