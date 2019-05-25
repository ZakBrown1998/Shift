using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Spirit: MonoBehaviour
{

    //Unity calls this function automatically when the enemy touches any other object.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks if the object the enemy has collided with has a player script and is therefore the player.
        Character CharacterScript = collision.collider.GetComponent<Character>();

        //Kills the player if they collide with the enemy.
        if (CharacterScript != null)
        {

            CharacterScript.Kill();
         
        }
    }
}