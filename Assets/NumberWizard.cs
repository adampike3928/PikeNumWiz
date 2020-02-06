using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{//varables that are globle to the class
    int intmax;
    int intmin;
    int intguess;
    // Start is called before the first frame update
  
    void Start()
    {//calls on VoidGameStart commands
        VoidStartGame();
    }
    void VoidStartGame()
    {
        intmax = 1000;
        intmin = 1;
        intguess = 500;

        //Greetings comments
        Debug.Log("Sup, this is num wiz bro. ");
        Debug.Log("Pick a number my dude or dudet ");
        Debug.Log("The highest number you may input is " + intmax);
        Debug.Log("The lowest number you can put in is " + intmin);
        //Instructions for input
        Debug.Log("is your number higher or lower than 500?");
        Debug.Log("Up = higher, down = lower, enter = correct");
        //Bugfix for not going to 1000
        intmax = intmax + 1;
    }
    // Update is called once per frame
    void Update()
    {//In put keys, update constantly checked
        //Cheacks for up arrow input
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            
            intmin = intguess;
            VoidNextGuess();
        }
        //Cheacks for down arrow input
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            
            intmax = intguess;
            VoidNextGuess();
            
        }
        //Cheacks for enter key input
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            intmax = intguess;
            VoidNextGuess();
            //Starts game again
            VoidStartGame();
        }
    }
    //Void to simplfy input commands
    void VoidNextGuess()
    {
        intguess = (intmax = intmin) / 2;
        Debug.Log("Is it higher or lower than" + intguess);
    }

}

