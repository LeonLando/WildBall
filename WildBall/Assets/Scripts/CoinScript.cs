using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private GameObject Coin;
    [SerializeField] private Animator Anim;
    

    private void Awake()
    {
        Anim = Coin.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Anim.SetBool("Collect", true);
        }
    }


}
