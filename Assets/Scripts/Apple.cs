using UnityEngine;

public class Apple : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Basket") Destroy(gameObject);
    }
    void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
}
