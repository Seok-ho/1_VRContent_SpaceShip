주의점
1. 메인 카메라에 상속시키면 자동으로 Alt+마우스를 통하여 움직일 수 있음
2. 빈 게임오브젝트에 Head라는 이름을 주고 메인 카메라를 넣어줌
-> 이유는 메인카메라는 GvrEditorEmulator에 의해서 위치값을 변경시킬 수 없음 
3. Head.transform.Translate(Cam.transform.forward * Time.deltaTime * 5f);
-> 메인카메라가 바a라보는 방향으로 Time.deltaTime * 5f 만큼 이동함 
4. transform.GetComponent<MeshRenderer>().enabled = false;
-> 메시렌더러를 꺼줘서 물체와 충돌하면 안보이게 해줌 (Destroy랑 다른게 계속 오브젝트는 살아있음)
-> Invoke("DestoryObj", 2f); 나중에 인보크 통해서 삭제 (오브젝트 계속 남으면 랙걸리니까)
5. PlayerPrefs.SetInt("ShipType", 1); , if(PlayerPrefs.GetInt("ShipType")==1)
-> 사용할 비행기 정보를 SetInt로 저장하고 GetInt로 뽑아와줌

Scene, Script 설명 
1. MenuScene 메인씬
· ButtonManager - 어느 씬으로 갈지 함수를 저장하고 있는 스크립트

2. SelectScene 비행기 고르는 씬 
· SelectShip -  PlayerPrefs.SetInt를 통해서 추후 GameScene에 사용할 비행기를 저장함 

3. GameScene
· SelectedShip - SelectShip에서 골랐던 비행기를  if (PlayerPrefs.GetInt("ShipType") == 1)를 통해 가져옴
· SpaceShipMovement - 비행기 움직임 관련 스크립트 (나아갈 방향, 회전 등등)
· Asteroid - 행성관련 스크립트 만약 트리거가 발생하면 렌더러를 꺼주고 2초후 행성을 Destroy시킴
· XRSetting - VR기능? 받아옴  

그 외
PhysicsTest, PhysicsTest - 동영상에서 테스트로 만든 스크립트 