using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endsceneloader : MonoBehaviour
{
    //public GameObject button1;
    // Start is called before the first frame update
    void Start()
    {
        //Button button = button1.gameObject.GetComponent<Button>(); //접근
        //접근 & 이벤트 등록
       // button.onClick.AddListener(startClicked);
        
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.A))
        { SceneManager.LoadScene("EndScene");}
    }

    
        
        

    
}
