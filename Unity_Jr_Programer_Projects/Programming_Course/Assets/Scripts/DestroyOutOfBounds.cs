using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topbounds = 50f;
    private float lowerbounds = -10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topbounds)
        {
            Destroy(gameObject); // Destroy the object if it goes above the top bounds
        }
        else if(transform.position.z < lowerbounds)
        {
            Destroy(gameObject); // Destroy the object if it goes below the lower bounds
        }
    }
}
