using UnityEngine;

public class Apple : MonoBehaviour
{
    void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
}
