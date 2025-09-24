using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Apple : MonoBehaviour
{
    private Score score;
    public float speed;
    private Rigidbody2D rb;
    private bool isDestroying = false;
    void Start()
    {
        score = FindFirstObjectByType<Score>();
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocityY = speed;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Basket"))
        {
            if (gameObject.name == "Bomb(Clone)")
            {
                gameObject.GetComponent<Animator>().SetTrigger("splode");
                rb.gravityScale = 0;
                rb.linearVelocity = Vector2.zero;
                gameObject.GetComponent<Collider2D>().enabled = false;
                Destroy(collision.gameObject);
            }
            else score.AddScore(10);

            isDestroying = true;
            if (gameObject.name == "Apple(Clone)") Destroy(gameObject);
        }
    }
    void OnBecameInvisible()
    {
        if (gameObject.name == "Apple(Clone)" && !isDestroying) score.OOB();
        Destroy(gameObject);
    }
    void explodeOver()
    {
        Destroy(gameObject);
    }
}
