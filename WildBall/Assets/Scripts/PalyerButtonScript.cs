using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalyerButtonScript : MonoBehaviour
{
    [SerializeField] private GameObject Obj;
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

    public void ActivateObj()
    {
        Obj.SetActive(true);
    }
}
