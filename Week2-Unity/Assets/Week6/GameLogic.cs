using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/*
needs for FPSController
http://answers.unity3d.com/questions/768615/detect-if-player-is-facing-an-object.html
 */

public class GameLogic : MonoBehaviour {
    protected static List<string> match;
    protected static List<GameObject> matchObjects;

    private float lastFrameTime;
    private float keypressDelta;

    // Use this for initialization
    void Start () {
        match = new List<string> { };
        lastFrameTime = Time.time;
        keypressDelta = 0.2F;
    }
	
	// Update is called once per frame
	void Update () {
        //if F is pressed and delta is passed (player doesn't mash the keys)
        //check if combo is good (and give feedback)
        if (Input.GetKey(KeyCode.F) && Time.time - keypressDelta > lastFrameTime)
        {
            print("F pressed !");

            //If there is no element in the match
            if (match.ElementAtOrDefault(0) == null)
            {
                print("Select a box !");
            }
            //If there is only one element in the match
            else if (match.ElementAtOrDefault(1) == null)
            {
                print("Select another box !");
            }
            //If the match is good
            else if (match[0] == match[1])
            {
                print("You had the correct match !");
                Destroy(matchObjects[0]);
                Destroy(matchObjects[1]);
                print("Objects destroyed !");
                
                match.Clear();
                matchObjects.Clear();
                print("Combination cleared.");
            }
            //If the match is bad
            else
            {
                print("Match is bad !");
                match.Clear();
                matchObjects.Clear();
                print("Combination cleared.");
            }

            lastFrameTime = Time.time;
            print("Time set: " + lastFrameTime);
        }
        //if R is pressed and delta is passed (player doesn't mash the keys)
        //clear combo
        else if (Input.GetKey(KeyCode.R) && Time.time - keypressDelta > lastFrameTime)
        {
            match.Clear();
            matchObjects.Clear();
            print("Combination cleared.");

            lastFrameTime = Time.time;
            print("Time set: " + lastFrameTime);
        }
    }
}
