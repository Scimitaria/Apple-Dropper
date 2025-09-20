using System.Collections;
using UnityEngine;

public class AppleDropper : MonoBehaviour
{
    private static WaitForSeconds _waitForSeconds1 = new WaitForSeconds(1f);
    public GameObject[] ApplePrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DropApples());
    }

    IEnumerator DropApples()
    {
        float y = transform.position.y;
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        while (true)
        {
            transform.position = new Vector2(Random.Range(-8, 8),y);
            Instantiate(ApplePrefabs[0], transform.position, rotation);
            yield return _waitForSeconds1;
        }
    }
}
