using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    int max;
    int min;
    int guess;
    void Start()
    {
        StartGame();

    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard, sir!");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("Highest number you can pick is " + max + ".");
        Debug.Log("Lowest number you can pick is " + min + ".");
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push up = higher, push down = lower, push enter =  correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            
            min = guess;
            NextGuess();
            Debug.Log(guess);
        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            max = guess;
            NextGuess();
            Debug.Log(guess);
        } 
        else if (Input.GetKeyDown(KeyCode.Return)) 
        {
            Debug.Log("I am a genius!");
            StartGame();
        }
     
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than: " + guess);
    }
}
