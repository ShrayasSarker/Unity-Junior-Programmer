using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float MoveLeftSpeed = 15f;
    private PlayerController playerControllerScript;
    private float leftBound = -20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)//move left only if the game is not over
        {
            transform.Translate(Vector3.left * MoveLeftSpeed * Time.deltaTime);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
