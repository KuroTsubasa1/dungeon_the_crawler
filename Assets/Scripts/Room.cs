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
        this.size_x = Random.Range(10, 40);
        this.size_y = Random.Range(10, 40);
        this.startpoint = getRandomStartPoint();
    }

    private List<int> getRandomStartPoint()
    {
        List<int> cord = new List<int>();

        cord.Add(Random.Range(0, floor_x));
        cord.Add(Random.Range(0, floor_y));

        return cord;
    }

    private void validateRoom()
    {

    }

    private void insertRoom(Floor floor)
    {

    }


    // getter setter

    public List<int> getStartpoint()
    {
        return this.startpoint;
    }




}
