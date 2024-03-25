using UnityEngine;

public class ObstacleDestroy : MonoBehaviour


{
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {

        player= GameObject.FindGameObjectWithTag("Obstacle1");


    }
    private void OnTriggerEnter2D(Collider2D collision)

    {

        if (collision.tag == "Border")
        {

            Destroy(this.gameObject);
        }



        else if (collision.CompareTag("Obstacle1"))
        {
            Destroy(player.gameObject);
        }
    }
}
