using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedShip : MonoBehaviour
{
    public GameObject ship01;
    public GameObject ship02;

    private void Start()
    {
        if (PlayerPrefs.GetInt("ShipType") == 1)
        {
            ship01.SetActive(true);
        }
        else
        {
            ship02.SetActive(true);
        }
    }
}
