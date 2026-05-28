using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private float turnSpeed =25f;
    private float horizontalInput;
    private float verticalInput;

    void FixedUpdate()
    {
        // Get the horizontal input
        horizontalInput =Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Move the player forward continuously
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);// Rotate the player based on horizontal input
    }
}
