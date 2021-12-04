using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeAnim1 : MonoBehaviour
{
    public Button irritability;

    public Button Anxiety;

    public Button frustration;

    public Animator animator;

    public AudioSource audio;

    public AudioSource audio2;
        void Start()
    {
        irritability.onClick.AddListener(()=> { onStartFrustration1(); });
        Anxiety.onClick.AddListener(() => { onStartFear2(); });
        frustration.onClick.AddListener(() => { Onstartloneliness3(); });

    }

    public void onStartFrustration1()
    {
        animator.SetBool("IsTwo", false);
        animator.SetBool("IsThree", false);
        audio.Stop();
        audio2.Stop();
        animator.SetBool("IsOne", true);
    }

    public void onStartFear2()
    {
        animator.SetBool("IsOne", false);

        animator.SetBool("IsThree", false);
        animator.SetBool("IsTwo", true);
        audio.Play();
        audio2.Stop();
    }
    public void Onstartloneliness3()
    {
        animator.SetBool("IsOne", false);
        animator.SetBool("IsTwo", false);
        animator.SetBool("IsThree", true);
        audio.Stop();
        audio2.Play();

    }
}
