using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {//prints the text inputed
        int intmax = 1000;
        int intmin = 1;
        Debug.Log("Sup, this is num wiz bro. ");
        Debug.Log("Pick a number my dude or dudet ");
        Debug.Log("The highest number you may input is " + intmax);
        Debug.Log("The lowest number you can put in is " + intmin);
       //Instructions for input
        Debug.Log("is your number higher or lower than 500?");
        Debug.Log("Up = higher, down = lower, enter = correct");

    }

    // Update is called once per frame
    void Update()
    {//In put keys, update constantly checked
        //Cheacks for up arrow input
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            Debug.Log("Up Arrow key was pressed"); 
        }
        //Cheacks for down arrow input
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            Debug.Log("Down Arrow key pressed");
        }
        //Cheacks for enter key input
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key pressed");
        }
    }
}
