using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    private int score;
    public TextMeshProUGUI scoreText;
    public Button restartButton;
    void Start()
    {
        UpdateScore(0);
        gameOverText.gameObject.SetActive(false); 
        
    }
    void Update()
    {
    }

    private void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
    public void GameOver() {
        gameOverText.gameObject.SetActive(true); 
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car")){
            UpdateScore(-score);
            Camera.main.transform.SetParent(null);
            GameOver(); 
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
        else if (other.CompareTag("Meta"))
        {
            UpdateScore(1);
        }
    }
}