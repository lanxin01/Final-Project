using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeAnim4 : MonoBehaviour
{
    public Button Despair1;

    public Button Memory2;

    public Button Neurosis3;

    public Animator animator;

    public AudioSource audio1;

    public AudioSource audio2;
        void Start()
    {
        Despair1.onClick.AddListener(()=> { onStartFrustration1(); });
        Memory2.onClick.AddListener(() => { onStartFear2(); });
        Neurosis3.onClick.AddListener(() => { Onstartloneliness3(); });

    }
    public void onStartFrustration1()
    {
        animator.SetBool("IsTwo", false);
        animator.SetBool("IsThree", false);
        audio2.Stop();

        audio1.Play();
        animator.SetBool("IsOne", true);
    }

    public void onStartFear2()
    {
        audio1.Stop();

        audio2.Play();
        animator.SetBool("IsOne", false);
        animator.SetBool("IsThree", false);

        animator.SetBool("IsTwo", true);
    }
    public void Onstartloneliness3()
    {

        audio1.Stop();
        audio2.Stop();
        animator.SetBool("IsOne", false);
        animator.SetBool("IsTwo", false);

        animator.SetBool("IsThree", true);
    }
}
