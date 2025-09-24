using UnityEngine;
using UnityEngine.InputSystem;

public class Basket : MonoBehaviour
{
    private float movement;

    void OnMouseMove(InputValue value)
    {
        movement = Camera.main.ScreenToWorldPoint(value.Get<Vector2>()).x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector2(movement, transform.position.y);
    }
}
