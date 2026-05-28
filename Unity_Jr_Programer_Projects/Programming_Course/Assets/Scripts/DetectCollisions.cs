using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);//destroy the object this script is attached to when it collides with another object
        Destroy(other.gameObject);//destroy the other object that this object collided with
    }
}
