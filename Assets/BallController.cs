using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidBody;
    [SerializeField] float ballSpeed;
    
    void Start()
    {
        
    }

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidBody.AddForce(inputXZPlane * ballSpeed);
    }

    void Update()
    {
       
    }
}
