using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingAnimation : MonoBehaviour {
    public float thrust;
    public Rigidbody rb;
    public float timeInt;
    public bool direction;
    public bool secondFlag;

    // initialization
    void Start () {
        thrust = 10;
        rb = GetComponent<Rigidbody>();
        timeInt = 0;
        direction = true; //upward

        secondFlag = false;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        timeInt += Time.fixedDeltaTime; //will increase by 1 every second
        double roundedTimeInt = System.Math.Round(timeInt);
        Debug.Log("<color=red>rounded timeInt:</color> " + roundedTimeInt);

        //every 5 seconds, the direction changes
        if (roundedTimeInt != 0 && roundedTimeInt % 5 == 0) //short-circuiting implicit
        {
            if (secondFlag == false)
            {
                secondFlag = true;
                direction = !direction;
            }
        } else
        {
            secondFlag = false;
        }

        if (direction)
        {
            Debug.Log("rise up");
            rb.AddForce(transform.up * thrust);
        } else
        {
            Debug.Log("bow down");
            rb.AddForce(transform.up * (thrust - 0.5f)); //(-1) only adds more thrust to gravity
        }
    }
}
