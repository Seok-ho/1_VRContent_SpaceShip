using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    public GameObject Head; //Head 오브젝트
    public GameObject Cam;  //메인 카메라 
    public GameObject SpaceShip;


    float CurrRot;  //현재 로테이션 
    float PrevRot;  //이전 로테이션
    float DeltRot;  //바로 직전 로테이션 

    void Update()
    {
        //캠이라는 오브젝트가 바라보는 방향으로 이동한다. 
        Head.transform.Translate(Cam.transform.forward * Time.deltaTime * 5f);

        tile();
    }

    // 비행선 회전 코드 오른쪽 왼쪽 어느 방향으로 돌고 있는지 확인 
    void tile()
    {
        CurrRot = Cam.transform.eulerAngles.y;  //현재 카메라의 로테이트값을 가져옴(내 시야는 카메라를 통해 보고 있으니까)
        DeltRot = CurrRot - PrevRot;    // 1. 115 - 0 = 115 (오른쪽으로 회전중), 2. 100 - 115 = -15 (왼쪽으로 회전중)
        PrevRot = CurrRot;

        if (DeltRot > 0)   //우측으로 회전 https://gnaseel.tistory.com/14 <- Lerp 설명 
        {
            SpaceShip.transform.localRotation =
                Quaternion.Lerp(SpaceShip.transform.localRotation,
                Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, -45),
                Time.deltaTime);
        }
        else if (DeltRot < 0)  //좌측으로 회전
        {
            SpaceShip.transform.localRotation =
               Quaternion.Lerp(SpaceShip.transform.localRotation,
               Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, 45),
               Time.deltaTime);
        }
        else //가만히 있을 때 원상복귀  DeltRot == 0 
        {
            SpaceShip.transform.localRotation =
              Quaternion.Lerp(SpaceShip.transform.localRotation,
              Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, 0),
              Time.deltaTime);
        }
    }
}
