using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }
    void PrintInstructions()
    {
        Debug.Log("Welcome to Crazy Roomba!");
        Debug.Log("Use WASD or arrow keys to move the Roomba.");
        Debug.Log("The rest of the tutorial goes here... lol.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
