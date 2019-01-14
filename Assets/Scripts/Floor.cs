using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Floor {

    // class variables
    private int size_x;
    private int size_y;
    List<Tile> Tilemanager = new List<Tile>();

    private Dictionary<string, int> floor = new Dictionary<string, int>();

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

        bool full = false;

        int ix = 0;
        int iy = 0; 

        do
        {
            if(ix < size_x -1 && iy < size_y -1)
            {
                Tilemanager.Add(new Tile(ix, iy, 99, 0));
                
                if(ix == size_x - 1)
                {
                    if (iy == size_y - 1)
                    {
                        full = true;
                    }
                    ix = 0;
                    iy++;
                }
                ix++;
            }

        } while (full);

    }

    public List<int> getFloorSize()
    {
        List<int> cords = new List<int>();
        cords.Add(size_x);
        cords.Add(size_y);

        return cords;
    }

    public List<Tile> getTileManager()
    {
        return this.Tilemanager;
    }

}
