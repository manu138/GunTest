using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGun : Gun
{


    [SerializeField]
    private int counter=0;

	// Use this for initialization
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            while (counter <= 10) 
            {
                Shoot();
                counter++;
            } 
        }
        if (Input.GetMouseButtonDown(1))
        {
         //   StartCoroutine(Example());
            counter = 0;
        }
    }

    // Update is called once per frame
    public override void Shoot()
    {
                   
            
                base.Shoot();
          
                   
           

        

    }
    IEnumerator Example()
    {
      
        yield return new WaitForSeconds(3);
      
    }
}
