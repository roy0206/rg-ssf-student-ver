using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void clickStart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void chickExit()
    {
        Application.Quit();
    }
    
    public void clickmenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
