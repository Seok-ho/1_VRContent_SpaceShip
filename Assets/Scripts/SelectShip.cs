using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectShip : MonoBehaviour
{
    public void Sparrow1()
    {
        PlayerPrefs.SetInt("ShipType", 1);
        SceneManager.LoadScene("3.GameScene");
    }
    public void Sparrow2()
    {
        PlayerPrefs.SetInt("ShipType", 2);
        SceneManager.LoadScene("3.GameScene");
    }
}
