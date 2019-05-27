
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{


    // Designer variables
    public AudioSource Jump; //Jump Audio variable
    public float speed = 10; //Float Speed variable
    public float jumpSpeed = 10;//Jump Speed variable
    public Rigidbody2D physicsBody; //Rigidbody 2D variable
    public string horizontalAxis = "Horizontal"; //Horizontal Axis variable
    public string jumpButton = "jump"; //JumpButton variable
    public Animator CharacterAnimator; //Animator variable
    public SpriteRenderer CharacterSprite; //Sprite Rendered variable
    public Collider2D CharacterCollider; //Collider variable
    public Lives livesObject; //Lives variable

    // Used for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {





        // Gets axis input from Unity.
        float leftRight = Input.GetAxis(horizontalAxis);


        // Creates a direction vector from axis input.
        Vector2 direction = new Vector2(leftRight, 0);

        // Makes direction vector length 1.
        direction = direction.normalized;

        // Calculates the velocity
        Vector2 velocity = direction * speed;
        velocity.y = physicsBody.velocity.y;

        // Gives the velocity to the rigidbody.
        physicsBody.velocity = velocity;

        //Gives the animatior the walking speed.
        CharacterAnimator.SetFloat("MoveSpeed", Mathf.Abs(velocity.x));

        //Flips the sprite if it is moving in the opposite direction.
        if (velocity.x < 0)
        {
            CharacterSprite.flipX = true;
        }
        else
        {
            CharacterSprite.flipX = false;
        }



        //Code for Jumping

        //Checks if the Character is touching the ground.
        //Gets the LayerMask from Unity using the name of the layer.
        LayerMask groundLayerMask = LayerMask.GetMask("Ground");

        //Checks the Character's collider to see if they are touching the LayerMask.
        bool touchingGround = CharacterCollider.IsTouchingLayers(groundLayerMask);

        CharacterAnimator.SetBool("TouchingGround", touchingGround);
        //Checks to see if the jump button has been pressed.
        bool jumpButtonPressed = Input.GetButtonDown(jumpButton);
        if (jumpButtonPressed == true && touchingGround == true)

        {

            //Sets the upward velocity to the player's jump speed when they have pressed jump.
            velocity.y = jumpSpeed;
            Jump.Play();

            //Gives the velocity to the rigidbody.
            physicsBody.velocity = velocity;
        }

        //Sets the Character to a falling state when their velocity is lower than 0.
        if (physicsBody.velocity.y < 0)
            CharacterAnimator.SetBool("Falling", true);
        else
            CharacterAnimator.SetBool("Falling", false);


    }


    //Used to kill the Character and program the after effects.
    public void Kill()
    {
        //Takes away one of the player's lives
        livesObject.LoseLife();
        //Saves the changes when a life has been taken away.
        livesObject.SaveLives();

        //Checks to see if the player has lost all their lives and is in the game over state.

        bool gameOver = livesObject.isGameOver();


        //If it is game over then game over screen is loaded.

        //Checks if the game is in game over state
        if (gameOver == true)
        {
            //Resets the player's lives
            livesObject.ResetLives();
            //Loads the game over scene.
            SceneManager.LoadScene("GameOver");

        }
        else
        {

            //If it is not game over, the current level is reset
            Scene currentLevel = SceneManager.GetActiveScene();
            //Checks Unity to find the current level
            SceneManager.LoadScene(currentLevel.buildIndex);
        }

    }



}