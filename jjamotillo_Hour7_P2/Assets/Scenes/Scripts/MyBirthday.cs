using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int birthday = 12;
        int daysinMonth = 31;

        for (int i = 1; i <= daysinMonth; i++)
        {
            if (i == birthday)
            {
                Debug.Log("Its my birthday!");
            }
            else
            {
                Debug.Log(i);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
