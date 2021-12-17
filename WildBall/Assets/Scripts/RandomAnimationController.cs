using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimationController : MonoBehaviour
{
    public Animator Anim;
    public int RandomNumber;
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }

    public void GetRandomNumber()
    {
        RandomNumber = Random.Range(1, 3);
        Anim.SetInteger("RandomInt", RandomNumber);
    }
}
