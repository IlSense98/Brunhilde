using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroy : MonoBehaviour


{
    private GameObject Player;


    // Start is called before the first frame update
    void Start()
    {

        Player = GameObject.FindGameObjectWithTag("Player");


    }

    
    private void OnTriggerEnter2D(Collider2D collision)

    {

        if (collision.tag == "SideBorder")
        {
            Debug.Log("collisione");
            Destroy(this.gameObject);
        }



        else if (collision.tag == "Player")
        {
            if (ObstaclePowerUp.isImmortal == true) {
                print("OKOK");
            }
            else {
                Destroy(Player.gameObject);
            }
        }
    }
}
