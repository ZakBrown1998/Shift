using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class TitleReturn : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        //Used to make the game scene transition from the Thank You For Playing Screen to the Title Screen.
        //The transisition activates when the "Space Bar" has been pressed by the player.
        if (Input.GetButtonDown("Submit")) { SceneManager.LoadScene("Title"); }
    }
}
