using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 1.0f;
    public Animator characterAnim;
    public Rigidbody body;
    public bool isMoving = false; // This checks to see if the character is moving.
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float verticial = Input.GetAxis("Verticial");
        Vector3 moveDirection = new Vector3(horizontal, 0, verticial).normalized;
        isMoving = moveDirection.magnitude > 0;
    }
}
