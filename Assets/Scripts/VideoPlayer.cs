﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayer : MonoBehaviour {

    public MediaPlayerCtrl scrMedia;

    public void HitByRay() {
        scrMedia.Play();
    }

    public void Pause() {
        scrMedia.Pause();
    }
}
