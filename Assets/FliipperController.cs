using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FliipperController : MonoBehaviour
{
    // Update is called once per frame
    public bool Flipper;
    void Update(){
        if (Input.GetKeyDown("left"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(10,50,0);
            //GetComponent<Rigidbody2D>().velocity = new Vector3(0,-5,0);
        }
        
    }
}
