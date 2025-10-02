using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {

    if (Input.GetKey(KeyCode.D))
    {
        Vector3 movementRight = new Vector3(moveSpeed = Time.deltaTime, 0f, 0f));
        transform.Translate(movementRight);
    }
    if (Input.GetKey(KeyCode.A))
    {
        Vector3 movementLeft = new Vector3(moveSpeed = Time.deltaTime, 0f, 0f));
        transform.Translate(movementLeft);
    }

    if (Input.GetKey(KeyCode.W))
    {
    Vector3 movementForward = new Vector3(moveSpeed = Time.deltaTime, 0f, 0f));
    transform.Translate(movementForward);
    }

    if (Input.GetKey(KeyCode.S))
    {
    Vector3 movementBackward = new Vector3(moveSpeed = Time.deltaTime, 0f, 0f));
    transform.Translate(movementBackward);
    }

    }
}
