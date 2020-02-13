using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	private Rigidbody2D rd2d;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public AudioSource musicSource;

	private float nextFire;
    private Rigidbody rb;

    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			GetComponent<AudioSource>().Play ();
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "EB")
        {
            Destroy(collision.collider.gameObject);
        }
        
    }
}