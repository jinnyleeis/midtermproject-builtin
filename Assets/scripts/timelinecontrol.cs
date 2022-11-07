using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Cinemachine;


public class timelinecontrol : MonoBehaviour
{
    public PlayableDirector[] _playableDirectors;
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
        _playableDirectors[2].Play();
    }
    
    public void pd3()
    {
        _playableDirectors[3].Play();
    }
}
