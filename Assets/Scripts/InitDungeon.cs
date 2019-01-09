using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitDungeon : MonoBehaviour {

    public int map_size_x = 100;
    public int map_size_y = 100;

    public int room_count =  1;

    private List<Room> rooms = new List<Room>();

    // Use this for initialization
    void Start()
    {
        Debug.Log("Start");
        Debug.Log(" ");
        Debug.Log("Map Size X: " + map_size_x);
        Debug.Log("Map Size Y: " + map_size_y);
        Debug.Log("Initialization Floor");
        Debug.Log(" ");

        Floor floor = new Floor(100, 100);
        Debug.Log(" ");

        Debug.Log("Initialization Room");
        Debug.Log("Number of Rooms: " + room_count);

        for(int i = 0; i< room_count; i++)
        {
            rooms.Add(new Room(map_size_x, map_size_y));
        }

        foreach(Room room in rooms)
        {
            Debug.Log(room.getRandomStartPoint());
        }

    }
	// Update is called once per frame
	void Update () {
		
	}

}