using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Apple : MonoBehaviour
{
    private bool isDestroying = false;
    public GameObject[] baskets = new GameObject[3];
    private ScoreManager scoreManager;
    void Start()
    {
        GameObject parentObject = GameObject.Find("Baskets");
        scoreManager = FindFirstObjectByType<ScoreManager>();
        for (int i = 0; i < parentObject.transform.childCount; i++)
        {
            baskets[i] = parentObject.transform.GetChild(i).gameObject;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Basket")
        {
            if (gameObject.name == "Bomb(Clone)")
            {
                gameObject.GetComponent<Animator>().SetTrigger("splode");
                if (baskets.Length <= 1) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                else Destroy(collision.gameObject);
            }
            else scoreManager.AddScore(10);
    
            isDestroying = true;
            Destroy(gameObject);
        }
    }
    void OnBecameInvisible()
    {
        if (!isDestroying && gameObject.name == "Apple(Clone)")
        {
            if (baskets.Length <= 1) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            else Destroy(baskets[0]);

            Destroy(gameObject);
        }
        else isDestroying = false;
    }
}
