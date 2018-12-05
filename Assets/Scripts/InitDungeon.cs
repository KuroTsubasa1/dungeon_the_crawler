using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitDungeon : MonoBehaviour {

    public Canvas canvas;

    // Use this for initialization
    void Start ()
    {
        /*
        Map map = new Map(100,100,true);
        Debug.Log(map.getFloor());*/
        // Debug.Log(map.getSizeX()); 

        var test = canvas.GetComponent(typeof(GameObject));
        Debug.Log(test);
    }
	// Update is called once per frame
	void Update () {
		
	}
}