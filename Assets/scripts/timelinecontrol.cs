using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Cinemachine;
using UnityEngine.Audio;


public class timelinecontrol : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip[] AudioClips;
    public PlayableDirector[] _playableDirectors;

    public bool isplayed1 = false;

    public bool isplayed2 = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
        //PlayableDirector[] _playableDirectors = GetComponents<PlayableDirector>();
        print(_playableDirectors.Length);
        foreach(PlayableDirector i in _playableDirectors)
        {
            print(i);
        }
        
        _playableDirectors[0].Play();

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void pd1()
    {
        _playableDirectors[1].Play();
    }
    
    
    public void pd2()
    {
        //_playableDirectors[2].Play();
        audiosource.clip = AudioClips[1];
        audiosource.Play();
        StartCoroutine(COROUTINE1());
        
    }
    
    public void pd3()
    {
        audiosource.clip = AudioClips[0];
        
        print("play!!");
       
          
            audiosource.Play();
            StartCoroutine(COROUTINE());
       
        //_playableDirectors[3].Play();
    }
    
    IEnumerator COROUTINE()
    {

        yield return new WaitForSeconds(10);
        audiosource.Stop();
        isplayed1 = false;


    }
    IEnumerator COROUTINE1()
    {

        yield return new WaitForSeconds(2);
        audiosource.Stop();
        isplayed2 = false;


    }
}
