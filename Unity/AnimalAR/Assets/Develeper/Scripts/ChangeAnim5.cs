using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeAnim5 : MonoBehaviour
{
    public Button Frustration1;

    public Button Fear2;

    public Button loneliness3;

    public Animator animator;
    public Animator animatorRotate;

    public AudioSource audio;

    public AudioSource audio2;
        void Start()
    {
        Fear2.onClick.AddListener(()=> { onStartFrustration1(); });
        Frustration1.onClick.AddListener(() => { onStartFear2(); });
        loneliness3.onClick.AddListener(() => { Onstartloneliness3(); });

    }

    public void onStartFrustration1()
    {
        animator.SetBool("IsTwo", false);
        animator.SetBool("IsThree", false);
        animatorRotate.SetBool("IsThree", false);
        audio.Play();
        audio2.Stop();
        animator.SetBool("IsOne", true);
    }

    public void onStartFear2()
    {
        animator.SetBool("IsOne", false);
        animator.SetBool("IsThree", false);
        animatorRotate.SetBool("IsThree", false);
        audio.Stop();
        audio2.Stop();
        animator.SetBool("IsTwo", true);
    }
    public void Onstartloneliness3()
    {
        animator.SetBool("IsOne", false);
        animator.SetBool("IsTwo", false);
        audio.Stop();
        audio2.Play();
        animator.SetBool("IsThree", true);
        animatorRotate.SetBool("IsThree",true);
    }
}
