using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossController : MonoBehaviour
{
    public Slider healthBar;
    public int bossHealth;
    public GameObject objectToDisable;
    public GameObject player;
    public GameObject winScreen;
    public bool boss1;
    public bool boss2;
    public GameObject playerBullet;
    public Text levelText;
    public bool isDead;
    //public bool boss2Start;
    //public int bossDamage;
    private IgnoreLayerScript ignore;
    private Lives playerLive;
    private int level;
    // Start is called before the first frame update
    void Start()
    {
        ignore = GetComponent<IgnoreLayerScript>();
        level = 1;
        //boss1Died = false;
        //boss2Start = false;
        isDead = false;
        SetLevelText();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = bossHealth;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet") && boss1 == true)
        {
            bossHealth = bossHealth - 1;
            DeductHealth();
        }
        if (collision.CompareTag("Bullet") && boss2 == true)
        {
            bossHealth = bossHealth - 1;
            DeductHealth();
        }
    }

    public void DeductHealth()
    {
        if (bossHealth == 0 && boss2 == true)
        {
            BossDead();
            winScreen.SetActive(true);
            PauseMenu.winLoseCondition = true;
            Time.timeScale = 0f; //freeze the game
        }
        if (bossHealth == 0 && boss1 == true)
        {
            //ignore.boss1Died == true;
            //IgnoreLayerScript.boss1Died = true;
            isDead = true;
            Debug.Log("Boss1Died");
            //GameObject.FindGameObjectsWithTag("Player").transform.position = new Vector2(-4f, -0.7f);
            //player.transform.position = new Vector2(-4f, -0.7f);
            level = level + 1;
            BossDead();
            SetLevelText();
            teleportPlayer();
        }
    }




    void BossDead()
    {
        //Physics2D.IgnoreLayerCollision(30, 31, false);
        Destroy(objectToDisable);
        Destroy(gameObject);
    }

    void teleportPlayer()
    {
        player.transform.position = new Vector2(-4f, -0.7f);
        
    }
    private void SetLevelText()
    {
        levelText.text = "Level: " + level.ToString();
    }
}
