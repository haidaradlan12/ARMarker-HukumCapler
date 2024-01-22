using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManagerMain : MonoBehaviour
{
    public GameObject Object1, Object2;
    Animator Animator1, Animator2;
    float prevSpeed1, prevSpeed2, locprevspeed1, locprevspeed2;
    private void Update()
    {
        locprevspeed1 = prevSpeed1;
        locprevspeed2 = prevSpeed2;
    }
    public void AnimasiPause()
    {
        Animator1 = Object1.GetComponent<Animator>();
        Animator2 = Object2.GetComponent<Animator>();
        prevSpeed1 = Animator1.speed;
        prevSpeed2 = Animator2.speed;
        Animator1.speed = 0;
        Animator2.speed = 0;
    }

    public void AnimasiPlay()
    {
        Animator1 = Object1.GetComponent<Animator>();
        Animator2 = Object2.GetComponent<Animator>();
        Animator1.speed = locprevspeed1;
        Animator2.speed = locprevspeed2;
    }
}
