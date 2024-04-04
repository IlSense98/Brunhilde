using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePowerUp : MonoBehaviour
{
    private GameObject Player;
    public static bool isImmortal = false;

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
        else if (collision.tag == "Player" && !isImmortal)
        {
            //  isImmortal = true;
            //ImmortalityTimer(5f);

            Destroy(this.gameObject);
        }
    }

    IEnumerator ImmortalityTimer(float duration)
    {
        // Make the player invincible
        //  Player.SetInvincible(true);

        // Wait for the duration
       
      

        // Reset player's invincibility after duration
        // Player.SetInvincible(false);
        
        yield return new WaitForSeconds(duration);
        isImmortal = false;

    }



    private void ActivateImmortality()
    {
        isImmortal = true;


        // Set isImmortal to false after 5 seconds
        Invoke(nameof(DeactivateImmortality), 5f);
    }

    private void DeactivateImmortality()
    {
       
      
        isImmortal = false;
    }
}
