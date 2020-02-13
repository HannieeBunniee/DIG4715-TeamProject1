using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreLayerScript : MonoBehaviour
{
    private BossController BossController;
    public bool boss1Died;

    void Start()
    {
        BossController = GetComponent<BossController>();
        boss1Died = false;
        //boss2Start = false;
    }
    private void Update()
    {
        if (BossController.isDead == true)
        {
            boss1Died = true;
            //Physics2D.IgnoreLayerCollision(30, 31, true);
        }

        if (boss1Died == true)
        {
            Physics2D.IgnoreLayerCollision(30, 31, false);
        }
    }
    //public GameObject playerBullet;
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            //Physics2D.IgnoreCollision(gameObject.CompareTag("Bullet"));
            //Physics2D.IgnoreLayerCollision(8, 9);
            
        }
    }*/



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && boss1Died == false)
        {
            //Physics2D.IgnoreLayerCollision(30, 31, false);
            Physics2D.IgnoreLayerCollision(30, 31, true);
        }
        else if (collision.CompareTag("Player") && boss1Died == true)
        {
            //Physics2D.IgnoreLayerCollision(30, 31, false);
            Physics2D.IgnoreLayerCollision(30, 31, true);
        }

        /*if (collision.CompareTag("Player") && BossController.boss1Died == false)
        {
            Physics2D.IgnoreLayerCollision(30, 31);
            //Physics2D.IgnoreCollision.CompareTag("Bullet");
        }
        if (collision.CompareTag("Player") && BossController.boss1Died == true)
        {
            Physics2D.IgnoreLayerCollision(30, 31);
            //Physics2D.IgnoreCollision.CompareTag("Bullet");
        }*/
    }



}
