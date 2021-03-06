﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
​
        if (tries == 0) {
            SceneManager.LoadScene("Game Over");
            tries = 3;
        }
        
        else {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
            tries--;
            currentScore -= pointsPerBlockDestroyed;
            scoreText.text = currentScore.ToString();
​
        }
        
    }
}