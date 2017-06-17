using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Main : MonoBehaviour {
    protected static List<string> lightsOrder;
    private List<string> lightsOrderConstant = new List<string> { "Light1", "Light2", "Light3" };

    private float lastFrameTime;
    private float keypressDelta;

    // Use this for initialization
    void Start () {
        lightsOrder = new List<string> { };
        lastFrameTime = Time.time;
        keypressDelta = 0.2F;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            print("F pressed !");
            if (Enumerable.SequenceEqual(lightsOrder, lightsOrderConstant) && Time.time - keypressDelta > lastFrameTime)
            {
                print("You had the correct order !");
                bool light = this.GetComponent<Light>().enabled;
                this.GetComponent<Light>().enabled = !light;
            }
            else
            {
                print("You didn't have the correct order !");
            }

            lastFrameTime = Time.time;
            print("Time set: " + lastFrameTime);
        }
    }
}
