# "Game" of pinball using Unity2d

Video: https://drive.google.com/file/d/1K01ns27NOE8qW_Y6wDFRLQeo8mQ05N0A/view?usp=sharing

# Codigo para los flippers:
```
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
```
