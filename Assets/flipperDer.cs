using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperDer : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Flipper;
    void Update(){
        if (Input.GetKeyDown("right"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-10,50,0);
            //GetComponent<Rigidbody2D>().velocity = new Vector3(0,-5,0);
        }
        
    }
}
