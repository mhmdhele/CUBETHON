using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 Offset;


    void Update()
    {
        // Debug.Log(Player.position);
        transform.position = Player.position + Offset;
    }
}
