﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour {
    [SerializeField]
    private float force;
  public  Transform shotSpawn;

    [SerializeField]
    private Rigidbody bullet;

    public int counter;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        transform.Rotate(new Vector3(0, 1, 0));
       
        Disparar();
     
    }

    public void Disparar()
    {
        Rigidbody shot = Instantiate(bullet, shotSpawn.position, shotSpawn.rotation);

        shot.velocity = transform.right * force;
    }
  
}
