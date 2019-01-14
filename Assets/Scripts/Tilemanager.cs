using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilemanager {

	private List<Tile> TileList  = new List<Tile>();

    public Tilemanager()
    {

    }

    public List<Tile> getTiles()
    {
        return this.TileList;
    }

    public List<Tile> getTile(int x, int y)
    {
        return TileList.Find(); // TODO create Search / Research .Find() Function
    }

       
}
