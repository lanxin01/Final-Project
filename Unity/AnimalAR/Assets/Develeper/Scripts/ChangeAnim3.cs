using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeAnim3 : MonoBehaviour
{
    public Button SluggishResponse;

    public Button Burnout;

    public Button Depression;

    public Animator animator;

    public AudioSource audio;
        void Start()
    {
        SluggishResponse.onClick.AddListener(()=> { onStartFrustration1(); });
        Burnout.onClick.AddListener(() => { onStartFear2(); });
        Depression.onClick.AddListener(() => { Onstartloneliness3(); });

    }

    public void onStartFrustration1()
    {
        animator.SetBool("IsTwo", false);
        animator.SetBool("IsThree", false);

        animator.SetBool("IsOne", true);

        audio.Stop();
    }

    public void onStartFear2()
    {
        animator.SetBool("IsOne", false);
        animator.SetBool("IsThree", false);
        audio.Stop();

        animator.SetBool("IsTwo", true);
    }
    public void Onstartloneliness3()
    {
        animator.SetBool("IsOne", false);
        animator.SetBool("IsTwo", false);
        audio.Play();

        animator.SetBool("IsThree", true);
    }
}
