using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject player;


    // Update is called once per frame
    void Update()

    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            if (ObstaclePowerUp.isImmortal == true)
            {
                print("NAH");
            }
            else
            {
                gameOverPanel.SetActive(true);
            }

        }


    }

    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
