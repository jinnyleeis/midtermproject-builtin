using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Cinemachine;


public class timelinecontrol : MonoBehaviour
{
    [SerializeField] private PlayableDirector[] _playableDirectors;
    // Start is called before the first frame update
    void Start()
    {
        
        PlayableDirector[] _playableDirectors = GetComponents<PlayableDirector>();
        
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
}
