using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public float speed = 8f; // 이동 속력
    public GameObject compare;
    public GameObject player1;
    public GameObject player2;
    private GameObject player;
    
    private followcam changemethodscript;

    private void Start()
    {
        player = player1;
        changemethodscript = FindObjectOfType<followcam>();
    }


    void Update() {
        if (compare.transform.position.x <= player.transform.position.x)
        {
            changemethodscript.nearspot();
            player = player2;
            
            //player1.SetActive(false);
            
            
        }
        // 수평과 수직 축 입력 값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // 실제 이동 속도를 입력 값과 이동 속력을 통해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;
        
       // Vector3 destination = new Vector3 (35770, -6850, -2632);

        // Vector3 속도를 (xSpeed, 0, zSpeed)으로 생성
        Vector3 newVelocity = new Vector3(zSpeed, 0f, xSpeed);
        // 리지드바디의 속도에 newVelocity를 할당
        
      
            player.transform.position += newVelocity * Time.deltaTime;
        
    }

    public void Die() {
        // 자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);
    }
}