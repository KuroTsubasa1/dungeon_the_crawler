using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {

    public int x { get; set; }
    public int y { get; set; }
    public int floorTileID { get; set; }
    public int itemID { get; set; }

    public Tile(int x, int y, int floorTileID, int itemID)
    {
        this.x = x;
        this.y = y;
        this.floorTileID = floorTileID;
        this.itemID = itemID;
    }


   

}
