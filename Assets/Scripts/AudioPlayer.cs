﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour {

    bool isPlaying = false;
    private GvrAudioSource audioSource;
    
	void Start () {
        audioSource = GetComponent<GvrAudioSource>();
	}

    void HitByRay() {
        if (isPlaying == false) {
            audioSource.Play();
            isPlaying = true;
        }
        
    }

    void Pause() {
        if (isPlaying) {
            audioSource.Pause();
            isPlaying = false;
        }
        
    }
}