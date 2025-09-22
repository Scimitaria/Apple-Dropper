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
        int selector = 0;
        while (true)
        {
            selector = 0;
            if (Random.Range(0, 9) == 1) selector = 1;
            transform.position = new Vector2(Random.Range(-8, 8), y);
            Instantiate(ApplePrefabs[selector], transform.position, rotation);
            yield return _waitForSeconds1;
        }
    }
}
