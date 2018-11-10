using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Movement movement;
    public Follow follow;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            follow.enabled = false;
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
