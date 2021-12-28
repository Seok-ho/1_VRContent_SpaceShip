using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("3.GameScene");
    }

    public void GoSelectScene()
    {
        SceneManager.LoadScene("2.SelectScene");
    }
}
