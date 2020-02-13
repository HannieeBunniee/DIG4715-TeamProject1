using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20f;
	public Rigidbody2D  rb;

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

    
}