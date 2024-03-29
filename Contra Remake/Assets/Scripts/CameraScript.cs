﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //this.transform.position = new Vector3(player.transform.position.x, this.transform.position.y, this.transform.position.z);
        transform.position = player.transform.position + offset;
    }
}
