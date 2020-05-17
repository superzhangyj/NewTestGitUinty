using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatToDo : MonoBehaviour
{
    public int testtxt = 123;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("创建项目");
         Debug.Log("本地不同路径测试");
    }

    // Update is called once per frame
    void Update()
    {
        if(testtxt>=123)
        {
            //test1 20200517 makefor ZYP
            print("test1");
            testtxt -= 1;
        }
        
    }
}
