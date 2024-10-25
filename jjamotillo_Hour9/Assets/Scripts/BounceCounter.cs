using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private int counter = 1;
    void OnCollisionEnter(Collision other)
    {
        
        if (gameObject.name == "Cube")
        {
            print(counter);
            counter++;
        }
    }
}
