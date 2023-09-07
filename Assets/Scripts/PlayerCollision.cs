using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement Movement;

    void OnCollisionEnter(Collision CollisionInfo)
    {
        // Debug.Log(CollisionInfo.collider.name);

        if(CollisionInfo.collider.tag == "Obstacle"){
            // Debug.Log("We Hit An Obstacle");
            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
