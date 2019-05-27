using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Spirit: MonoBehaviour
{

    //Unity calls this function automatically when the Spirit touches any other object.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks if the object the Spirit has collided with has a Character script and is therefore the Character.
        Character CharacterScript = collision.collider.GetComponent<Character>();

        //Kills the Character if they collide with the Spirit.
        if (CharacterScript != null)
        {

            CharacterScript.Kill();
         
        }
    }
}