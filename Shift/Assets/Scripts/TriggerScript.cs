using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //makes the animator visible in the inspector 
    [SerializeField] private Animator timeJewelController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //this is stops the boulder from moving when colliding with the trigger
        if (other.CompareTag("Player"))
            timeJewelController.SetBool("ChangeBackground", true);
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        //this is if the boulder hasnt hit the trigger and the animation still plays
        if (other.CompareTag("Player"))
            timeJewelController.SetBool("ChangeBackground", false);
    }
}
