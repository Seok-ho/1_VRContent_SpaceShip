using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public GameObject ExplosionObj; //폭발하는 파티클 갖고옴 
    private void OnTriggerEnter(Collider other)
    {
        ExplosionObj.SetActive(true);
        transform.GetComponent<MeshRenderer>().enabled = false; //안보이게 해줌 
        Invoke("DestoryObj", 2f);
        //Destroy(this.gameObject);
    }

    void DestoryObj()
    {
        Destroy(this.gameObject);
    }
}
