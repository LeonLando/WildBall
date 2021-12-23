using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public void ToLevel(Text LevelText)
    {
        SceneManager.LoadScene(LevelText.text.ToString());
    }
    
}
