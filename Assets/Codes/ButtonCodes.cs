using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCodes : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("TitleScene");
    }
    
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GameQuit()
    {
        Application.Quit();
    }
}
