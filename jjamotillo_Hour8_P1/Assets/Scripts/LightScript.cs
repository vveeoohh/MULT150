using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Light LightBulb;
    // Start is called before the first frame update
    void Start()
    {
        LightBulb.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            LightBulb.enabled = !LightBulb.enabled;
        }
    }
}
