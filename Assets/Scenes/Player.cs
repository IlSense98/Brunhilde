using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()

{

rb = GetComponent<Rigidbody2D>();

}

// Update is called once per frame
void Update()


{
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                
                rb.AddForce(Vector2.up * 25, ForceMode2D.Impulse);
            }


        }
    }


void FixedUpdate()

{

        

    }

    }


