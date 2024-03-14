using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel; 
    public GameObject player;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 1.0f;
            Destroy(player);
            

        }
    }


}
