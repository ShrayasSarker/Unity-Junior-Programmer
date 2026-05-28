using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offset =new Vector3(0, 5, -6); // Offset to keep the follower behind the player

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;// Keep the follower at the player's position
    }
}
