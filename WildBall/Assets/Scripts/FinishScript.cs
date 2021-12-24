using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    [SerializeField] private GameObject FinishPanel;
    [SerializeField] private GameObject Partycle1;
    [SerializeField] private GameObject Partycle2;
    [SerializeField] private GameObject Partycle3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FinishPanel.SetActive(true);
            Partycle1.SetActive(true);
            Partycle2.SetActive(true);
            Partycle3.SetActive(true);
        }
    }

}
