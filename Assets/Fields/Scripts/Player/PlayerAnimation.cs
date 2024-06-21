using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;

    bool isRun = true;

    Vector3 change;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        CreatAnimation();
    }

    public void CreatAnimation()
    {
         change.x = Input.GetAxisRaw("Horizontal");
         change.y = Input.GetAxisRaw("Vertical");

        if (change != Vector3.zero)
        {
            anim.SetFloat("Horizontal", change.x);
            anim.SetFloat("Vertical", change.y);
            isRun = true;
        }
        else
            isRun = false;

        anim.SetBool("isRuning", isRun);
    }
}
