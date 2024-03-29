using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class border_bottom : MonoBehaviour
{
    public float minYPosition = -10f; // Adjust this value to set the minimum Y position

    void Update()
    {
        // Check if the player's Y position is below the minimum
        if (transform.position.y < minYPosition)
        {
            // Restart the game by reloading the current scene
            RestartGame();
        }
    }

    void RestartGame()
    {
        // Reload the current scene
        int currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneIndex);
    }
}