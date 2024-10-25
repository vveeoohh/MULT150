using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
    SphereController();
    }

    void SphereController() //arrow key controls for sphere
    {
        float speed = 2f;
        Vector3 movement = Vector3.zero;


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement += Vector3.right;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement += Vector3.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement += Vector3.down;
        }
        transform.Translate(movement * Time.deltaTime * speed);
    }
}
