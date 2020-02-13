using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
	public Rigidbody2D  rb;

    //damage enemy
    [SerializeField]
    float damageBoss = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		rb.velocity = transform.right * speed;
        Awake();
    }

    void Awake()
    {
        Destroy(gameObject, 1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Boss"))
        {

        }
    }

}