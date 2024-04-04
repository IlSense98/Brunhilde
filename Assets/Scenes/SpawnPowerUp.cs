using UnityEngine;

public class SpawnPowerUp : MonoBehaviour
{
    public GameObject obstacle;
    public float maxx;
    public float minx; public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    // Update is called once per frame
    void Update()

    {

        if (Time.time > spawnTime)
    {

            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;

        }


    }

    void Spawn()

    {
        float randomX = Random.Range(minx, maxY);
        float randomy = Random.Range(minx, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomy, 0), transform.rotation);

    }


}


