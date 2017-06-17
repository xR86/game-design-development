using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : Main {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);

        print("Object collided !");
        print(other.gameObject.name);

        //if (other.gameObject.name == "Checkpoint")
        GameObject child = this.transform.GetChild(0).gameObject;
        GameObject grandChild = child.transform.GetChild(0).gameObject;

        bool light = grandChild.GetComponent<Light>().enabled;
        grandChild.GetComponent<Light>().enabled = !light;

        print(grandChild.name);

        if (!light == true) {
            lightsOrder.Add(grandChild.name);
        } else
        {
            lightsOrder.Remove(grandChild.name);
        }

        print("lightsOrder: " + lightsOrder.ToString());
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        print("Controller collided !");
    }
}
