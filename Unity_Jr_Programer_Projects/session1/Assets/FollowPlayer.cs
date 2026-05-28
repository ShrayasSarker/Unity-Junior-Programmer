
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset; // Offset from the player position

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        offset = new Vector3(0, 2, -3);
        transform.position = player.transform.position + offset; // Set the camera position to follow the player with an offset
    }
}
