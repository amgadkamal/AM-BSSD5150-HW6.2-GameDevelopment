using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //press w for walking, release W for idle
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetInteger ("State", 1);
        }
        if (Input.GetKeyUp (KeyCode.W))
        {
            anim.SetInteger("State", 0);
        }
        //press R for runing, release w for idle
        if (Input.GetKeyDown(KeyCode.R))
        {
            anim.SetInteger("State", 2);
         }
        if (Input.GetKeyUp(KeyCode.R))
            {
                anim.SetInteger("State", 0);
            }

    }
    
}
