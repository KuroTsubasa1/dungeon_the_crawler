using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour {

    public GameObject player;
    public GameObject enemy;

    int gamestate = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		
        switch(gamestate)
        {
            case 0:
                UserInput();
                break;
            case 1:
                EnemyMove();
                break;
        }

	}

    void UserInput()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + 1);

            gamestate = 1;
            return;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position = new Vector3(player.transform.position.x -1, player.transform.position.y, player.transform.position.z);

            gamestate = 1;
            return;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            player.transform.position = new Vector3(player.transform.position.x + 1, player.transform.position.y, player.transform.position.z);

            gamestate = 1;
            return;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 1);

            gamestate = 1;
            return;
        }
    }

    void EnemyMove()
    {

        int num = 0;

        // try to near player
        // interesting values are x,z
        // check if values are positiv or negativ



        // validation
        bool x = player.transform.position.x - enemy.transform.position.x > 0;
        bool z = player.transform.position.z - enemy.transform.position.z > 0;

        /*
         Move List
         0  ->  up
         1  ->  left
         2  ->  right
         3  ->  down
         */

        if (x && z)
        {
            switch(Random.Range(0,2))
            {
                case 0:
                    num = 0;
                    break;
                case 1:
                    num = 2;
                    break;
            }
        }

        if (!x && !z)
        {
            switch (Random.Range(0, 2))
            {
                case 0:
                    num = 3;
                    break;
                case 1:
                    num = 1;
                    break;
            }
        }

        if (!x && z)
        {
            switch (Random.Range(0, 2))
            {
                case 0:
                    num = 0;
                    break;
                case 1:
                    num = 1;
                    break;
            }
        }

        if (x && !z)
        {
            switch (Random.Range(0, 2))
            {
                case 0:
                    num = 3;
                    break;
                case 1:
                    num = 2;
                    break;
            }
        }

        // int num = Random.Range(0, 4);

      //  Debug.Log("Choosen Number: " + num);


        switch (num)
        {
            case 0:
                enemy.transform.position = new Vector3(enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z + 1);
                gamestate = 0;
                return;

            case 1:
                enemy.transform.position = new Vector3(enemy.transform.position.x - 1, enemy.transform.position.y, enemy.transform.position.z);
                gamestate = 0;
                return;

            case 2:
                enemy.transform.position = new Vector3(enemy.transform.position.x + 1, enemy.transform.position.y, enemy.transform.position.z);
                gamestate = 0;
                return;

            case 3:
                enemy.transform.position = new Vector3(enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z - 1);
                gamestate = 0;
                return;

        }
        gamestate = 0;
    }
}
