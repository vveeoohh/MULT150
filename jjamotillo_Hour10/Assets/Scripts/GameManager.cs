using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GoalScript blue, green, red, orange;
    private bool isGameOver = false;
    private bool isYouLose = false;
    float countdownTime = 30.0f;
    // Update is called once per frame
    void Update()
    {
        // If all four goals are solved then the game is over
       isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;

        countdownTime -= Time.deltaTime;
        if ( countdownTime < 0)
        {
            isYouLose = true;
            isGameOver = true;
        }
    }
    void OnGUI()
    {
        if (isGameOver)
        {
            Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, isYouLose ? "You Lose" : "Good Job!");
        }
        if (isYouLose)
        {
            Rect buttonRect = new Rect(Screen.width / 2 - 50, Screen.height / 2 + 25, 100, 30);
            if (GUI.Button(buttonRect, "Try Again?"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (!isGameOver || !isYouLose)
        {
            Rect timerRect = new Rect(10, 10, 100, 30);
            GUI.Label(timerRect, "Time: " + Mathf.Ceil(countdownTime).ToString());
        }
    }

}
