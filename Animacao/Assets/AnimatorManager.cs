using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;
    public void PlayGinga()
    {
        animator.SetBool("meiaLua", false);
        animator.SetBool("au", false);
        animator.SetBool("esquiva", false);
        animator.SetBool("armada", false);
    }

    public void PlayArmada()
    {
        animator.SetBool("meiaLua", false);
        animator.SetBool("au", false);
        animator.SetBool("esquiva", false);
        animator.SetBool("armada", true);
    }

    public void PlayAu()
    {
        animator.SetBool("meiaLua", false);
        animator.SetBool("au", true);
        animator.SetBool("esquiva", false);
        animator.SetBool("armada", false);
    }

    public void PlayMeiaLua()
    {
        animator.SetBool("meiaLua", true);
        animator.SetBool("au", false);
        animator.SetBool("esquiva", false);
        animator.SetBool("armada", false);
    }

    public void PlayEsquiva()
    {
        animator.SetBool("meiaLua", false);
        animator.SetBool("au", false);
        animator.SetBool("esquiva", true);
        animator.SetBool("armada", false);
    }
}
