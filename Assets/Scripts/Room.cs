using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    int size_x;
    int size_y;


    public Room()
    { 
        this.size_x = Random.Range(50, 100);
        this.size_y = Random.Range(50, 100);
    }

}
