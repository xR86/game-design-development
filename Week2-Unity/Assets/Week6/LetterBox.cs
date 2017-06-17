using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LetterBox : GameLogic{
    private string textContent;

	// Use this for initialization
	void Start () {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int num = Random.Range(0, 4);

        GameObject thisIniObject = this.transform.GetChild(0).gameObject;
        TextMesh textObject = thisIniObject.GetComponent<TextMesh>();
        
        textObject.text = chars[num].ToString();
        textContent = textObject.text;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);

        print("Object collided !");
        print(other.gameObject.name);

        //don't add to list if the combination overflowed
        if(match.Count < 3 ) {
            GameObject thisObject = this.transform.GetChild(0).gameObject;
            
            //if there is no element, add object
            if (match.ElementAtOrDefault(0) == null)
            {
                match.Add(textContent);
                matchObjects.Add(thisObject);
            }
            //if there is 1 element, add only if current gameobject is different
            else if (matchObjects[0] != thisObject)
            {
                //condition: !GameObject.Equals(matchObjects[0], thisObject)
                //condition: matchObjects[0] != thisObject
                //print(thisObject.ToString());
                //print(matchObjects[0].ToString());

                match.Add(textContent);
                matchObjects.Add(thisObject);
            }
            
        }
    }
}
