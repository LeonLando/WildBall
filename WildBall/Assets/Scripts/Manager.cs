using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ToLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ToLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void ToLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void ToLevel4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void ToLevel5()
    {
        SceneManager.LoadScene("Level5");
    }

    public void ToLevel6()
    {
        SceneManager.LoadScene("Level6");
    }
}
