using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
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
        if(math.sqrt(Input.GetAxisRaw("Horizontal")) != 0 || math.sqrt(Input.GetAxisRaw("Vertical")) != 0)
            isRun = true;         
        else
            isRun = false;

        anim.SetBool("isRuning", isRun);
    }
}
