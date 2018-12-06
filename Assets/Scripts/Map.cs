using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map
{ 
    // class variables
    private int size_x;
    private int size_y;
    private Dictionary<string, int> floor = new Dictionary<string, int>();

    public Map(int size_x, int size_y, bool random_size = false)
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

        floor = prepareMap();
    }

    // read the size of x
    public int getSizeX()
    {
        return size_x;
    }

    // read the size of y
    public int getSizeY()
    {
        return size_y;
    }

    // read the map
    public Dictionary<string, int> getFloor()
    {
        return floor;
    }

    // fill the map with values (everything will be filled with 0)
    private Dictionary<string, int> prepareMap()
    {
        for(int i = 0; i < size_x; i++)
        {
            for (int ii = 0; ii < size_y; ii++)
            {
                string array_key_name = i.ToString() + ii.ToString();
                Debug.Log(array_key_name);
                floor[array_key_name] = 0;
            }
        }

        return floor;
    }
}
