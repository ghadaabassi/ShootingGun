using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetButtonDown("Fire1"))
        {
            Rigidbody fire;
            fire=Instantiate(bullet,transform.position,transform.rotation) as Rigidbody;
            fire.AddForce(transform.forward*4000);
        }
        
    }
}
