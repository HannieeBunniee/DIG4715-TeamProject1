using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    /*void OnTriggerExit(Collider other) //anything that leave the box get destroyed
    {
        Destroy(other.gameObject);
    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            Destroy(collision.collider.gameObject);
        }
        if (collision.collider.tag == "EB")
        {
            Destroy(collision.collider.gameObject);
        }
    }
}