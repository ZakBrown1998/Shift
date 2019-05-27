using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{



    void Update()
    {

        //Used to make the game scene transition from the Game Over screen to the Thanks-For-Playing screen when the correct input button is pressed by the player.

        if (Input.GetButtonDown("Submit")) { SceneManager.LoadScene("Thanks-For-Playing"); }
    }
}
