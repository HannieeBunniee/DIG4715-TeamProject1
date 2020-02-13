using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosion;

	// Start is called before the first frame update
    void Start()
    {
        
    }
	
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.tag == "Bullet")
		{
			Instantiate(explosion, transform.position, transform.rotation);
		}
	}
}