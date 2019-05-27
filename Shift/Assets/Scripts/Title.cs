﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{



    void Update()
    {
        //Used to make the game scene transition from the Title to the Story.
        //The transisition activates when the "Space Bar" has been pressed by the player.
        if (Input.GetButtonDown("Submit")) { SceneManager.LoadScene("Story"); }
    }
}
