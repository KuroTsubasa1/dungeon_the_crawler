using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room{

    // class variables
    private int size_x;
    private int size_y;

    private string startpoint;
    private int floor_x;
    private int floor_y;

    public Room(int floor_x,int floor_y)
    {
        this.size_x = Random.Range(10, 40);
        this.size_y = Random.Range(10, 40);
        this.startpoint = getRandomStartPoint();
    }

    public string getRandomStartPoint()
    {
        string x = Random.Range(0, floor_x).ToString();
        string y = Random.Range(0, floor_y).ToString();
        return x +" " + y;
    }



}
