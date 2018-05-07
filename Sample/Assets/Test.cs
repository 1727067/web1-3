using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Test : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir= endPos - startPos;
        Debug.Log(dir);

        float len=dir.magnitude;
        Debug.Log(len);
    }
    }


    // Update is called once per frame
   
