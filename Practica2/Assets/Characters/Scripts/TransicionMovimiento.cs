using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransicionMovimiento : MonoBehaviour
{

    //Animator
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent <Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            anim.SetBool("isMove", true);
        }
        if (!Input.GetKey("w"))
        {
            anim.SetBool("isMove", false);
        }

        if (Input.GetKey("e"))
        {
            anim.SetBool("IsDancing", true);
        }
        if (!Input.GetKey("e"))
        {
            anim.SetBool("IsDancing", false);
        }
    }
}
