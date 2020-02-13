using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public AudioSource musicSource;
	public AudioClip musicClipOne;
	public AudioClip musicClipTwo;
	public AudioClip musicClipThree;

    /*public Text winText;
	

	private int lives;*/

    void Start ()
	{
		/*lives = 3;
		winText.text = "";
		SetLivesText ();*/
	}

	/*private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.tag == "Enemy")
		{
			lives = lives - 1;
			livesText.text = lives.ToString();
			Destroy(collision.collider.gameObject);
			SetLivesText();
		}
	}

	private void SetLivesText()
	{
		livesText.text = "Lives: " + lives.ToString ();
		if (lives == 0)
		{
			Object.Destroy(gameObject);
			winText.text = "You Lose!";
			musicSource.clip = musicClipThree;
			musicSource.Play();
		}
	}*/
}