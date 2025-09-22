using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Apple : MonoBehaviour
{
    private bool isDestroying = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Basket")
        {
            isDestroying = true;
            Destroy(gameObject);
        }
    }
    void OnBecameInvisible()
    {
        if (!isDestroying)
        {
            try { Destroy(GameObject.Find("Basket")); }//this doesn't work
            catch { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }
            //Destroy(gameObject);
        }
        else isDestroying = false;
    }
}
