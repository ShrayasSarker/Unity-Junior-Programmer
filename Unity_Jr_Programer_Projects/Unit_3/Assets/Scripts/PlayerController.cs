using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 10f;
    public float gravityModifier;
    public bool isGrounded = true;
    public bool gameOver = false;
    private Animator playerAnim;
    private float groundThreshold = 2.9f;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crushSound;
    private AudioSource playerAudio;
    public AudioSource cameraAudioSource;


    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
        cameraAudioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && !gameOver)
        {
            Jump();
        }
        //Landing();
        
    }
    void Jump()
    {
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
        playerAnim.SetTrigger("Jump_trig");
        dirtParticle.Stop();
        playerAudio.PlayOneShot(jumpSound, 1.0f);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            Debug.Log("Game Over!");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crushSound, 1.0f);
            cameraAudioSource.Stop();
        }
    }
    void Landing()
    {
        if (transform.position.y > groundThreshold)
        {
            playerAnim.SetBool("Grounded", false);
        }
        else
        {
            playerAnim.SetBool("Grounded", true);
        }
    }
    

}
