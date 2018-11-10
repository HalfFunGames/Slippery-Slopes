using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {

    public float Speed = 2000f;
    public float Control = 2000f;

    public Rigidbody rb;
	
	
	void FixedUpdate () {
        rb.AddForce(Speed * Time.deltaTime, 0, 0);

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, Control * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -Control * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
