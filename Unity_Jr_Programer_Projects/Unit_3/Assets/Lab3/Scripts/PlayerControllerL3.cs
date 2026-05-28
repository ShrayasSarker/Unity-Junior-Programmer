using NUnit.Framework;
using UnityEngine;

public class PlayerControllerL3 : MonoBehaviour
{
    public Rigidbody playerRb;
    public float verticalMove;
    public float horizontalMove;
    public float jumpForce = 5f;
    public float speed = 5f;
    public bool isGrounded = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalMove = Input.GetAxis("Vertical");
        horizontalMove = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalMove);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalMove);

        if (Input.GetKeyDown(KeyCode.Space)&& isGrounded ==true)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.CompareTag("Ground");
        isGrounded= true;
    }
}
