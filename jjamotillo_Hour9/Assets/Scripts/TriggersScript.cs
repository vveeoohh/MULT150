using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "RTrigger")
        {
            print(other.gameObject.name + " has entered RTrigger");
        }
        else if (gameObject.name == "LTrigger")
        {
            print(other.gameObject.name + " has entered LTrigger");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (gameObject.name == "RTrigger")
        {
            print(other.gameObject.name + " is inside RTrigger");
        }
        else if (gameObject.name == "LTrigger")
        {
            print(other.gameObject.name + " is inside LTrigger");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "RTrigger")
        {
            print(other.gameObject.name + " has exited RTrigger");
        }
        else if (gameObject.name == "LTrigger")
        {
            print(other.gameObject.name + " has exited LTrigger");
        }
    }
}
