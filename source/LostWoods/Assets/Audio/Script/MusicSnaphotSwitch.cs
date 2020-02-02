using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicSnaphotSwitch : MonoBehaviour
{
    public AudioMixerSnapshot mySnapshot;
    public float fadeTime = 3.0f;
    public float delayTime = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        mySnapshot.TransitionTo(fadeTime);


    }
}
