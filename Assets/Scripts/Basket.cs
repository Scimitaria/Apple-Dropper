using UnityEngine;
using UnityEngine.InputSystem;

public class Basket : MonoBehaviour
{
    private float movement;
    public float speed;
    private Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void OnMouseMove(InputValue value)
    {
        Debug.Log("moving");
        movement = value.Get<float>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x + movement * speed * Time.deltaTime, transform.position.y);
    }
}
