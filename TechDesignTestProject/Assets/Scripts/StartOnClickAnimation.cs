using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartOnClickAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator animator = null;


    private void OnMouseDown()
    {
        if(!animator.GetBool("OpenTrueFalse"))
            animator.SetBool("OpenTrueFalse", true);
        else
            animator.SetBool("OpenTrueFalse", false);
    }
}
