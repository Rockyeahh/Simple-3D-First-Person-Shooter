﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

    public float speed = 10f;
	
	// Update is called once per frame
	void Update () {
        print("Alive");
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
