using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Square")
        {
            LoadGamePlay();       
        }

    }

    public void LoadGamePlay()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
