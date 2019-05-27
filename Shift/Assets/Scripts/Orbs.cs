using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbs : MonoBehaviour
{

    //Variable to let us add to the score
    //Public so we can drag and drop
    public Score scoreObject;

    public AudioSource Orb;
    // Variable to hold the Orb's value
    //It's public so we can change it in the editor

    public int OrbValue;

    // Used for initialization.
    void Start()
    {

    }

    // Update is called once per frame.
    void Update()
    {

    }

    //Unity calls this function when the Orb touches any other object.
    //If the player touched it, the Orb should vanish and score will go up.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks if the object collided with was the Character.
        Character CharacterScript = collision.collider.GetComponent<Character>();

        //If the object collided with has a Character script then score is added and the orb is destroyed.
        if (CharacterScript)
        {

            //Add to the player's score based on the orb's value.
            scoreObject.AddScore(OrbValue);

            //Plays the Orb sound effect.
            Orb.Play();

    //Destroy the gameObject that this script is attached to (i.e.The Orb)
    Destroy(gameObject);
        }
    }
}
