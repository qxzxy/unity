﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void DestroyGameObject()
    {
        Destroy(gameObject);//谁用销毁谁
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}