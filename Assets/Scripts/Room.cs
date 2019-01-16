using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room{

    // class variables
    private int size_x;
    private int size_y;

    private List<int> startpoint;
    private int floor_x;
    private int floor_y;

    public Room(int floor_x,int floor_y)
    {
        Debug.Log("Room floor_x " + floor_x.ToString());
        Debug.Log("Room floor_y " + floor_y.ToString());

        this.size_x = Random.Range(10, 40);
        this.size_y = Random.Range(10, 40);
        this.floor_x = floor_x;
        this.floor_y = floor_y;
        this.startpoint = getRandomStartPoint();

        insertRoom(startpoint);
    }

    private List<int> getRandomStartPoint()
    {
        List<int> cord = new List<int>();

        Debug.Log("Room floor_x " + floor_x.ToString());
        Debug.Log("Room floor_y " + floor_y.ToString());

        cord.Add(Random.Range(0, floor_x));
        cord.Add(Random.Range(0, floor_y));

        return cord;
    }

    private bool validateRoom(List<int> startpoint)
    {

        Debug.Log("--------------------------");
        Debug.Log("Room Validation");

        // check if startpoint + room size is out of bounds

        Debug.Log(startpoint[0].ToString() + " + " + size_x.ToString() + " > " + floor_x.ToString());
        
        if(startpoint[0] + size_x > floor_x)
        {
            Debug.Log("NOT PASSED");
            return false;
        }
        Debug.Log("PASSED");

        Debug.Log(startpoint[1].ToString() + " + " + size_y.ToString() + " > " + floor_y.ToString());
        if (startpoint[1] + size_y > floor_y)
        {
            Debug.Log("NOT PASSED");
            return false;
        }
        Debug.Log("PASSED");

        return true;
    }

    private void insertRoom(List<int> startpoint)
    {
        if(validateRoom(startpoint))
        {
            Debug.Log("YAY");
            // apply room to map
        }
    }


    // getter setter

    public List<int> getStartpoint()
    {
        return this.startpoint;
    }




}
