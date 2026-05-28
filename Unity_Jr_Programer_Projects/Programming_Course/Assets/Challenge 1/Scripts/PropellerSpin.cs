using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float rotationSpeed = 1000f; // Speed of the propeller rotation
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
