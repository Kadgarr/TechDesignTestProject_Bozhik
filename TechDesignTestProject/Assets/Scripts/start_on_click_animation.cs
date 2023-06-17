using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start_on_click_animation : MonoBehaviour
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
