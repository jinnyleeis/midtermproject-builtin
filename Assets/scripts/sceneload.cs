using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Cinemachine;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;



public class sceneload : MonoBehaviour
{
    public TextMeshProUGUI tmp;
   
    private float lifespan;
    private bool ismainscene=false;
    public bool startscene2;
    private float lifetime;
    private float speed;
    public GameObject startbutton;
    
    // Start is called before the first frame update
    void Start()
    {
        lifetime = 0;
        lifespan = Random.Range(50f, 200f);

        if (startscene2)
        {

            Button button = startbutton.gameObject.GetComponent<Button>(); //접근
            //접근 & 이벤트 등록
            button.onClick.AddListener(startClicked);
        }

        StartCoroutine(COROUTINE(2f,"StartScene2",false));
        




    }

    // Update is called once per frame
    void Update()
    {
        if (ismainscene)
        {
            lifetime += Time.deltaTime;
            tmp.text = "Your Life Time:" + (int)lifetime + "\nYour RANDOM Life span:" + (int)lifespan;
        }

    }

    void startClicked()//스타트씬 -> 빅뱅 씬으로 이동!
    {
        SceneManager.LoadScene("Bigbangscene");
        StartCoroutine(COROUTINE(5f, "MainScene",true));
        

    }
    
    IEnumerator COROUTINE(float a,string scene,bool main)
    {

        yield return new WaitForSeconds(a);
        SceneManager.LoadScene(scene);
        ismainscene = main;

    }
    
    
    
}
