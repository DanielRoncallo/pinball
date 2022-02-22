using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperIzq : MonoBehaviour
{
    // Start is called before the first frame updat
    // Update is called once per frame
    public float speed = 2;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x, 0, z);
        movement = Vector3.ClampMagnitude(movement, 1);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
