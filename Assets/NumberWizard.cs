using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max = 1000;
    int min = 10;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard, yo ");
        Debug.Log("Pick a number, dont tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame----
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            
            min = guess;
            NextGuess();
            
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow was pressed.");

            max = guess;
            NextGuess();

        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter was pressed");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = ( min + max ) / 2;
        Debug.Log("Is it higher or lower than: " + guess);
    }
}
