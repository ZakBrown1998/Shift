using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Allow use of the scene management functions.
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    //Allows access to the Character's score.
    public Score scoreObject;

    //Allows the next scene to be loaded after the Character collides with the portal.
    public string sceneToLoad;

    //Runs a function when the Character collides with the portal.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks if the object the portal collided with is the Character. (Aka has the Character script)
        Character CharacterScript = collision.collider.GetComponent<Character>();
        {
            //Function to save the Character's score and load the next level.
            if (CharacterScript != null)
            {
                //saves the score using the score object reference.
                scoreObject.SaveScore();

                //Loads the next level.
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}