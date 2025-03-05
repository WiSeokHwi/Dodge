using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        else if (Input.GetKey(KeyCode.S) == true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        else if (Input.GetKey(KeyCode.D) == true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        else if (Input.GetKey(KeyCode.A) == true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }

    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
