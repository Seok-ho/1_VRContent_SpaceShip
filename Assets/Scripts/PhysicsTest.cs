using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("진입했습니다.");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("머무르는 중");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit");
    }
}
