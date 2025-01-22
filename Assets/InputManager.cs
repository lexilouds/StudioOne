using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        if (Input.GetKey(KeyCode.W)) {
            inputVector += Vector2.up;
       }

       if (Input.GetKey(KeyCode.S)) {
            inputVector += Vector2.down;
       }

       if (Input.GetKey(KeyCode.D)) {
            inputVector += Vector2.right;
       }

       if (Input.GetKey(KeyCode.A)) {
            inputVector += Vector2.left;
       }

       OnMove?.Invoke(inputVector);
    }
}
