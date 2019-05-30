using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {


    public AudioSource Warp;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //This makes the animator visible in the inspector 
    [SerializeField] private Animator timeJewelController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //this changes the background when the Character touches the Jewel. 
        if (other.CompareTag("Player"))
            timeJewelController.SetBool("ChangeBackground", true);
        Warp.Play();
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        //this is if the Character hasn't hit the Jewel and it makes sure the original background animation still plays.
        if (other.CompareTag("Player"))
            timeJewelController.SetBool("ChangeBackground", false);
    }
}
