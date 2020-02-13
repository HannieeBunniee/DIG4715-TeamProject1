using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{

    public Text winText;
    public Text livesText;
    //public Text levelText;
    public GameObject winScreen;
    public GameObject loseScreen;
    private int lives;
    //private int level;
    private int score;

    private PauseMenu pauseMenuScript;
    // Start is called before the first frame update
    void Start()
    {
        //level = 1;
        lives = 5;
        score = 0;
        winText.text = "";
        SetLivesText();
        //SetLevelText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            lives = lives - 1;
            livesText.text = lives.ToString();
            //Destroy(collision.collider.gameObject);
            //collision.gameObject.SetActive(false);
            SetLivesText();
        }
        if (collision.collider.tag == "Boss")
        {
            lives = lives - 1;
            livesText.text = lives.ToString();
            SetLivesText();
            //collision.gameObject.SetActive(false);
            //code below not gonna be in this if function once the bullet work
            /*level = level + 1;
            levelText.text = "Level: " + level.ToString();
            transform.position = new Vector2(-4.0f, -0.8f);*/
        }
		if (collision.collider.tag == "EB")
		{
			lives = lives - 1;
            livesText.text = lives.ToString();
            SetLivesText();
        }
    }

    private void SetLivesText()
    {
        livesText.text = "Lives: " + lives.ToString();
        if (lives == 0)
        {
            loseScreen.SetActive(true);
            //Object.Destroy(gameObject);
            PauseMenu.winLoseCondition = true;
            Time.timeScale = 0f; //freeze the game
            //winText.text = "You Lose!";
        }
    }

}
