using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSCript : MonoBehaviour
{
    public Animator Anim;
    
    private void Awake()
    {
        Anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Anim.SetBool("Activate", true);
        }
    }
    public void ResetBool()
    {
        Anim.SetBool("Activate", false);
    }
}
