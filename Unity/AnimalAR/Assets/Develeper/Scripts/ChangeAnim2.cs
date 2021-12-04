using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeAnim2 : MonoBehaviour
{
    public Button Frustration1;

    public Button Fear2;

    public Button loneliness3;

    public Animator animator;

    public AudioSource audio;

    public AudioSource audio2;
        void Start()
    {
        Frustration1.onClick.AddListener(()=> { onStartFrustration1(); });
        Fear2.onClick.AddListener(() => { onStartFear2(); });
        loneliness3.onClick.AddListener(() => { Onstartloneliness3(); });

    }

    public void onStartFrustration1()
    {
        animator.SetBool("IsFear", false);
        animator.SetBool("IsLoneliness", false);

        animator.SetBool("isFrustration", true);
        audio.Stop();
        audio2.Stop();
    }

    public void onStartFear2()
    {
        animator.SetBool("IsLoneliness", false);

        animator.SetBool("isFrustration", false);
        animator.SetBool("IsFear", true);

        audio.Stop();
        audio2.Play();

    }
    public void Onstartloneliness3()
    {
        animator.SetBool("isFrustration", false);
        animator.SetBool("IsFear", false);
        animator.SetBool("IsLoneliness", true);

        audio.Play();
        audio2.Stop();

    }
}
