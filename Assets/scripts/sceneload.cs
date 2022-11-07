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

    public bool mainscene;
    public bool bigbangscene;
    private float lifespan;
    private bool ismainscene=false;
    public bool startscene2;
    public bool startscene1;
    private float lifetime;
    private float speed;
    public GameObject startbutton;
    public GameObject mainbutton;
    
    // Start is called before the first frame update
    void Start()
    {
        lifetime = 0;
        lifespan = Random.Range(30f, 35f);

        if (startscene2)
        {

            Button button = startbutton.gameObject.GetComponent<Button>(); //접근
            //접근 & 이벤트 등록
            button.onClick.AddListener(startClicked);
        }

        if (startscene1)
        {

            StartCoroutine(COROUTINE1(2f, "StartScene2", false));
        }

        if (bigbangscene)
        {
           // StartCoroutine(COROUTINE2(9f, "MainScene",true));
           Button button1 = mainbutton.gameObject.GetComponent<Button>(); //접근
           //접근 & 이벤트 등록
           button1.onClick.AddListener(mainClicked);
        }





    }

    // Update is called once per frame
    void Update()
    {
        if (mainscene)
        {
            lifetime += Time.deltaTime;
            tmp.text = "Your Life Time:" + (int)lifetime + "\nYour RANDOM Life span:" + (int)lifespan;
        }

    }

    void startClicked()//스타트씬 -> 빅뱅 씬으로 이동!
    {
        SceneManager.LoadScene("Bigbangscene");
        
        

    }
    
    void mainClicked()//스타트씬 -> 빅뱅 씬으로 이동!
    {
        SceneManager.LoadScene("Mainscene");
        
        

    }
    
    IEnumerator COROUTINE1(float a,string scene,bool main)
    {

        yield return new WaitForSeconds(a);
        SceneManager.LoadScene(scene);
        ismainscene = main;

    }
    //IEnumerator COROUTINE2(float a,string scene,bool main)
   // {

    //    yield return new WaitForSeconds(a);
    //    SceneManager.LoadScene(scene);
    //    ismainscene = main;

  //  }
    
    
    
}
