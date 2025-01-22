using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidBody;
    [SerializeField] float ballSpeed;
    [SerializeField] float jumpForce;
    [SerializeField] private bool isGrounded;

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidBody.AddForce(inputXZPlane * ballSpeed);
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            Jump();
       }
    }

    void Jump() 
    {
        sphereRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) {
            isGrounded = true;
        }
    }
}
