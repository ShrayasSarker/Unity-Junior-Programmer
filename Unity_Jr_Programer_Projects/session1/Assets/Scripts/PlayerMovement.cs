using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardspeed = 10f; // Speed of the player movement
    public float sidespeed = 5f; // Speed of the player movement
    private float verticalInput; // Variable to store vertical input
    private float horizontalInput; // Variable to store horizontal input
    private Rigidbody playerRb;
    public float jumpForce = 5f; // Force applied when jumping
    public float gravityModifier = 1f; // Gravity modifier for the player
    public bool isGrounded = true; // Check if the player is on the ground

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); // Get the Rigidbody component attached to the player
        Physics.gravity *= gravityModifier;// Modify the gravity for the player
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) // Check if the space key is pressed and the player is grounded
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // Set isGrounded to false when the player jumps
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * sidespeed * Time.deltaTime); // Get horizontal input (A/D keys or Left/Right arrows)
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * forwardspeed * Time.deltaTime); // Move the player forward at a speed of 5 units per second
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true; // Set isGrounded to true when the player collides with the ground
    }
}
