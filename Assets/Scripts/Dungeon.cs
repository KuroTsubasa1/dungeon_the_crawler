using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Dungeon {

    private string dungeonName = "DefaultDungeon";
    private int floorCount = 5;
    private List<int> enemyList = { 0, 1 };
    private List<int> itemList = { 0 };
    private int dungeonTheme = 0;
    private List<int> specialFloors = { 99 };

    public Dungeon
        (
            string dungeonNamen,
            int floorCount,
            List<int> enemyList,
            List<int> itemList,
            int dungeonTheme, 
            List<int> specialFloors
        )

    {
        this.dungeonName = dungeonName;
        this.floorCount = floorCount;
        this.enemyList = enemyList;
        this.itemList = itemList;
        this.dungeonTheme = dungeonTheme;
        this.specialFloors = specialFloors;
    }
}
