using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using Color = UnityEngine.Color;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour
{
    #region
    public GameObject finishHole;
    public GameObject gameManager;

    public float speed;

    bool leftCheck;
    bool rightCheck;
    bool upCheck;
    bool downCheck;
    
    float _inHoleTime;
    public float leftFinishTime = 3f;

    public static Color playerColor;
    public SpriteRenderer playerSprite;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        // Random Start Position of the Player
        RandomPlayerPos();

        // sets the color of the player
        playerSprite.color = playerColor;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        HoleCheck();

        PlayerOutOfCamera();

        LoseTime();
    }

    void Movement()
    {
        // Movement of the Player
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(x, y, 0);
    }

    void HoleCheck()
    {
        // X Position of the Finish Hole for checking left range
        float holeLeftXPos = finishHole.transform.position.x;
        
        // Max Left Range where Player can go in the Hole
        float leftHoleXRange = holeLeftXPos -= 0.2f;
        // Check if Player is too far to the left of the Finish Hole 
        if (this.transform.position.x >= leftHoleXRange)
        { 
            leftCheck = true;
        }
        else
        {
            leftCheck = false;
        }
        
        // X Position of the Finish Hole for checking right range
        float holeRightXPos = finishHole.transform.position.x;
        
        // Max Right Range where Player can go off the Hole
        float rightHoleXRange = holeRightXPos += 0.2f;
        // Check if Player is too far to the right of the Finish Hole 
        if (this.transform.position.x <= rightHoleXRange)
        { 
            rightCheck = true;
        }
        else
        {
            rightCheck = false;
        }
        
        // Y Position of the Finish Hole for checking up range
        float holeUpYPos = finishHole.transform.position.y;
        
        // Max Up Range where Player can go off the Hole
        float upHoleYRange = holeUpYPos += 0.2f;
        // Check if Player is too far up of the Finish Hole 
        if (this.transform.position.y <= upHoleYRange)
        { 
            upCheck = true;
        }
        else
        {
            upCheck = false;
        }
        
        // Y Position of the Finish Hole for checking down range
        float holeDownYPos = finishHole.transform.position.y;
        
        // Max Down Range where Player can go off the Hole
        float downHoleYRange = holeDownYPos -= 0.2f;
        // Check if Player is too far down of the Finish Hole 
        if (this.transform.position.y >= downHoleYRange)
        { 
            downCheck = true;
        }
        else
        {
            downCheck = false;
        }

        // Check if Player is in Hole
        if (leftCheck == true && rightCheck == true && upCheck == true && downCheck == true)
        {
            _inHoleTime -= Time.deltaTime;
            
            // Check if player is long enough in the hole to add Score, update player and hole position and update leftFinishTime
            if (_inHoleTime <= 0)
            {
                FindObjectOfType<AudioManager>().Play("IncreaseHighscore");
                gameManager.GetComponent<ScoreSystem>().AddScore();
                RandomPlayerPos();
                finishHole.GetComponent<FinishHole>().RandomHolePos();
                leftFinishTime = 3f;
            }
        }
        else
        {
            // Resets the time you have to be in the hole to get to the next level if you are out of the Hole
            _inHoleTime = 0.3f;
        }
    }
    
    void RandomPlayerPos()
    {
        // Random Position of the Player
        float xSpawnRange = Random.Range(-7.5f, 7.5f);
        float ySpawnRange = Random.Range(-4f, 2.5f);
        
        transform.position = new Vector2(xSpawnRange, ySpawnRange);
    }

    void PlayerOutOfCamera()
    {
        // If player is right out of the cam he will come out of the left
        if (transform.position.x >= 9.5f)
        {
            float leftOutOfCamXPos = -9.45f;
            transform.position = new Vector2(leftOutOfCamXPos, transform.position.y);
        }
        
        // If player is left out of the cam he will come out of the right
        if (transform.position.x <= -9.5f)
        {
            float rightOutOfCamXPos = 9.45f;
            transform.position = new Vector2(rightOutOfCamXPos, transform.position.y);
        }
    }

    void LoseTime()
    {
        leftFinishTime -= Time.deltaTime;

        // If the time is over the game ends
        if (leftFinishTime <= 0)
        {
            Time.timeScale = 0;
        }
    }

    void Sprinting()
    {
        speed = 6;
    }
    
    void NotSprinting()
    {
        speed = 3;
    }
}
