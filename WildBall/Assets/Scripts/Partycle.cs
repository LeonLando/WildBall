using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Partycle : MonoBehaviour
{
    [SerializeField] private GameObject PartycleObj;

    public void GetPartycle()
    {
        PartycleObj.SetActive(true);
    }


}
