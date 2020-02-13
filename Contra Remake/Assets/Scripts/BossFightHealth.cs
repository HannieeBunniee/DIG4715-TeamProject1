using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFightHealth : MonoBehaviour
{
    public GameObject objectToEnable;
    public GameObject objectToEnable1;
    //public GameObject objectToEnable2;
    //public static bool disabled;

    /*private void Update()
    {
        if (disabled)
        {
            objectToEnable.SetActive(true);
        }
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Touched");
            objectToEnable.SetActive(true);
            objectToEnable1.SetActive(true);
            gameObject.SetActive(false);

            //disabled = true;
        }

    }
}
