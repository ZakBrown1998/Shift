using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ToThanks : MonoBehaviour {

	// Used for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Used to make the game scene transition from the Game Over or Victory Screens to the Thanks For Playing one.
        //The transisition activates when the "Space Bar" has been pressed by the player.
        if (Input.GetButtonDown("Submit"))
        {
            SceneManager.LoadScene("Thanks-For-Playing");
        }
    }
}
