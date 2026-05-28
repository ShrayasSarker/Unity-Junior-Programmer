using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public GameObject projecttilePrefab;
    public float horizontalInput;
    public float speed = 50f;
    public float xRange = 11f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projecttilePrefab, transform.position, projecttilePrefab. transform.rotation);
        }
    }
}
