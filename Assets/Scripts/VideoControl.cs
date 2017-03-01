﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoControl : MonoBehaviour {

    bool rayHit = false;

    GameObject tempGameObject;
    int layer_mask1;

    private void Start() {
        layer_mask1 = LayerMask.GetMask("Player");
    }


    void FixedUpdate() {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1, layer_mask1) && rayHit == false) {
            tempGameObject = hit.transform.gameObject;
            tempGameObject.SendMessage("HitByRay");
            rayHit = true;
        } else {
            if (rayHit) {
                tempGameObject.SendMessage("Pause");
                rayHit = false;
            } else {
                return;
            }

        }
    }

   
}
