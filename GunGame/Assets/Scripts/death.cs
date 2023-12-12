using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    Animator animator;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            i--;
            if (i == 0) {
                animator.SetBool("dead", true);
            }
           
        }
    }
}
