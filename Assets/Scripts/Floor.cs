using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Floor {

    // class variables
    private int size_x;
    private int size_y;
    private Tile[,] floor = new Tile[0, 0];


    public Floor(int size_x, int size_y, bool random_size = false)
    {
        if (!random_size)
        {
            this.size_x = size_x;
            this.size_y = size_y;
        }
        else
        {
            this.size_x = Random.Range(50, 100);
            this.size_y = Random.Range(50, 100);
        }

        /*
        Debug.Log("-----");
        Debug.Log(this.size_x);
        Debug.Log(this.size_y);
        */

        this.floor = new Tile[size_x, size_y];

        for (int i = 0; i < size_x ; i++)
        {
            for (int ii = 0; ii < size_y ; ii++)
            {
                this.floor[i, ii] = new Tile(i, ii, 0, 0);
            }

        }
    }

    public Tile[,] getFloor()
    {
        return this.floor;
    }


    public List<int>getFloorDimensions()
    {
        List<int> dimensions = new List<int>();
        dimensions.Add(this.size_x);
        dimensions.Add(this.size_y);
        return dimensions;
    }

}

    

