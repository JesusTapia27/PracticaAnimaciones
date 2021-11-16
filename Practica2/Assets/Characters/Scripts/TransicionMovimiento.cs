using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransicionMovimiento : MonoBehaviour
{
    public float Velocidad = 0.0f;
    public float aceleracion = 0.1f;
    public float desaceleracion = 0.5f;

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
        bool MoverseOprimido = Input.GetKey("p");
        bool DisparoOprimido = Input.GetKey("space");

        if (MoverseOprimido && Velocidad < 1.0f)
        {
            Velocidad += Time.deltaTime * aceleracion;
        }

        if (!MoverseOprimido && Velocidad > 0.0f)
        {
            Velocidad -= Time.deltaTime * desaceleracion;
        }

        if (!MoverseOprimido && Velocidad < 0.0f)
        {
            Velocidad = 0.0f;
        }

        if (Input.GetKey("e"))
        {
            anim.SetBool("IsDancing", true);
        }
        if (!Input.GetKey("e"))
        {
            anim.SetBool("IsDancing", false);
        }

        if (Input.GetKey("d"))
        {
            anim.SetBool("Disparando", true);
        }
        if (!Input.GetKey("d"))
        {
            anim.SetBool("Disparando", false);
        }

        anim.SetFloat("Velocidad", Velocidad);

        
    }
}
