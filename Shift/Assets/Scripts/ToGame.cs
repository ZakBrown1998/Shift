using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ToGame : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        // Resets the score
        PlayerPrefs.DeleteKey("score");

        // Resets the lives
        PlayerPrefs.DeleteKey("lives");
        //Used to make the game scene transition from the Controls screen to the Caves Of Rememberance.
        //The transisition activates when the "Space Bar" has been pressed by the player.
        if (Input.GetButtonDown("Submit")) { SceneManager.LoadScene("Caves-Of-Rememberance");
        }
    }
}


