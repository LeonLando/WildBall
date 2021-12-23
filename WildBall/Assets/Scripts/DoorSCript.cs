using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSCript : MonoBehaviour
{
    public GameObject DoorHelpPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DoorHelpPanel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DoorHelpPanel.SetActive(false);
        }
    }
}
