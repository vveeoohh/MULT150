using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Xvalue, Yvalue;
        Xvalue = Input.GetAxis("Mouse X"); // x axis movement
        Yvalue = Input.GetAxis("Mouse Y"); // y axis movement
        if (Xvalue != 0)
        {
            transform.Translate(Xvalue, 0f, 0f);
        }
        if (Yvalue != 0)
        {
            transform.Translate(0f, Yvalue, 0f);
        }
    }
}
