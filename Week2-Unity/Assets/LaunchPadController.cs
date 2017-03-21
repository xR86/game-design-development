using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPadController : MonoBehaviour {
    GameObject controller;

    // initialization
    void Start () {
        controller = GameObject.Find("FPSController");
        controller.GetComponent<Rigidbody>().isKinematic = true;
    }
	
	// Update is called once per frame
	void Update () {}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("<color=green>other.tag:</color> " + other.tag);
        Debug.Log("<color=green>other.name:</color> " + other.name);
        Debug.Log("<color=green>other.attachedRigidbody:</color> " + other.attachedRigidbody);

        if (other.tag == "FirstPersonCharacter")
        {
            Debug.Log("Ka-Blowey!");
            //var controller = GameObject.Find("Main Camera");
            controller.GetComponent<Rigidbody>().isKinematic = false;
            controller.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision !");
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
    }
}
