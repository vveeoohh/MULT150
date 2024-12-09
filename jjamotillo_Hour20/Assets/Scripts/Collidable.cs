using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public GameManager manager;
    public float moveSpeed = 20f;
    public float timeAmount = 1.5f;
    void Update()
    {
        transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (gameObject.name == "Obstacle(Clone)") // when the obstacle hits the player, the timer goes down
            {
                manager.AdjustTime(-timeAmount);
            }
            else
            {
                manager.AdjustTime(timeAmount);
            }
            Destroy(gameObject);
        }
    }
}
