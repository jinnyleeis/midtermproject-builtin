using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class particlebullet : MonoBehaviour {
    public float speed = 8f; // 총알 이동 속력
    //private Rigidbody bulletRigidbody; // 이동에 사용할 리지드바디 컴포넌트
    public bool isdestroy;
    private timelinecontrol tmctrl;
    

    void Start()
    {

        tmctrl = FindObjectOfType<timelinecontrol>();
        
        // 수명 끝나면 자신의 게임 오브젝트 파괴 -> 씬 이동.
        if (isdestroy == true)
        {
            Destroy(gameObject, 3f);
        }
    }

    // 트리거 충돌 시 자동으로 실행되는 메서드
    void OnTriggerEnter(Collider other) {
        // 충돌한 상대방 게임 오브젝트가 Player 태그를 가진 경우
        if (other.tag == "Player1")
        {
           
          
           print("player1");
           tmctrl.pd1();
           //StartCoroutine(COROUTINE());
         
           
        }
        
        if (other.tag == "Player2")
        {
            if (tmctrl.isplayed2 == false)
            {
                tmctrl.isplayed2 = true;
                print("player2");
                tmctrl.pd2();
                //StartCoroutine(COROUTINE());
            }



        }
        if (other.tag == "Player3")
        {
           
          
            print("player3");
            if (tmctrl.isplayed1 == false)
            {
                tmctrl.isplayed1 = true;
                tmctrl.pd3();
            }
            //StartCoroutine(COROUTINE());
         
           
        }
    }

    

    IEnumerator COROUTINE()
    {

        yield return new WaitForSeconds(3f);

    }
}